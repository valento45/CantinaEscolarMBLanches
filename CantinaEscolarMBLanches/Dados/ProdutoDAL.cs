using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//precisa
using System.Data.SqlClient;//precisa

namespace CantinaEscolarMBLanches.Dados
{
    class ProdutoDAL
    {
        
        //instancia / referencia da classe de conexão
        Conexao con = new Conexao();

        //método cadastrar
        public void Cadastrar(Classe.Produto produto)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO MBLanches.PRODUTO (DESCRICAO, IDCATEGORIA, PRECOBRUTO, PRECOVENDA, VALIDADE, IMAGEM, QUANTIDADE, ANOTACOES)
                                            VALUES (@DESCRICAO, @IDCATEGORIA, @PRECOBRUTO, @PRECOVENDA, @VALIDADE, @IMAGEM, @QUANTIDADE, @ANOTACOES)", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
            cmd.Parameters.AddWithValue("@IDCATEGORIA", produto.IDCategoria);
            cmd.Parameters.AddWithValue("@PRECOBRUTO", produto.PrecoBruto);
            cmd.Parameters.AddWithValue("@PRECOVENDA", produto.PrecoVenda);
            cmd.Parameters.AddWithValue("@VALIDADE", produto.Validade);
            cmd.Parameters.AddWithValue("@IMAGEM", produto.Imagem);
            cmd.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);
            cmd.Parameters.AddWithValue("@ANOTACOES", produto.Anotacoes);

            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }
        //método Atualizar
        public void Atualizar(Classe.Produto produto)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE MBLanches.PRODUTO SET DESCRICAO = @DESCRICAO, IDCATEGORIA = @IDCATEGORIA, PRECOBRUTO = @PRECOBRUTO, PRECOVENDA = @PRECOVENDA, VALIDADE = @VALIDADE, IMAGEM = @IMAGEM, QUANTIDADE = @QUANTIDADE, ANOTACOES = @ANOTACOES WHERE IDPRODUTO = @IDPRODUTO", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@IDPRODUTO", produto.IDProduto);
            cmd.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
            cmd.Parameters.AddWithValue("@IDCATEGORIA", produto.IDCategoria);
            cmd.Parameters.AddWithValue("@PRECOBRUTO", produto.PrecoBruto);
            cmd.Parameters.AddWithValue("@PRECOVENDA", produto.PrecoVenda);
            cmd.Parameters.AddWithValue("@VALIDADE", produto.Validade);
            cmd.Parameters.AddWithValue("@IMAGEM", produto.Imagem);
            cmd.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);
            cmd.Parameters.AddWithValue("@ANOTACOES", produto.Anotacoes);
            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }

        //método para baixar o estoque
        public void BaixarEstoque(Classe.Produto produto)
        {
            SqlCommand cmd = new SqlCommand("UPDATE MBLanches.PRODUTO SET QUANTIDADE = QUANTIDADE - @QUANTIDADE WHERE IDPRODUTO = @IDPRODUTO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDPRODUTO", produto.IDProduto);
            cmd.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }



        //método consultar Todos
        public DataTable ConsultarTodos()
        {
            //passando comando de consulta
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT PRO.IDPRODUTO AS CÓD, PRO.DESCRICAO AS DESCRIÇÃO, CAT.Categoria AS CATEGORIA, PRO.PRECOVENDA AS PREÇO, PRO.VALIDADE, PRO.QUANTIDADE AS QTD, PRO.ANOTACOES AS ANOTAÇÕES
                                                    FROM MBLanches.PRODUTO AS PRO JOIN MBLanches.CATEGORIA AS CAT ON PRO.IDCategoria = CAT.IDCategoria", con.Conectar());
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        //método consultar por nome
        public DataTable ConsultaPorProduto(Classe.Produto produto)
        {
            //passando comando de consulta
            //SqlDataAdapter da = new SqlDataAdapter("SELECT IDPRODUTO AS CÓD, DESCRICAO AS DESCRIÇÃO, IDCATEGORIA AS CATEGORIA, PRECOVENDA AS PREÇO, VALIDADE, QUANTIDADE AS QTD, ANOTACOES AS ANOTAÇÕES FROM MBLanches.PRODUTO WHERE DESCRICAO LIKE @DESCRICAO", con.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT PRO.IDPRODUTO AS CÓD, PRO.DESCRICAO AS DESCRIÇÃO, CAT.Categoria AS CATEGORIA, PRO.PRECOVENDA AS PREÇO, PRO.VALIDADE, PRO.QUANTIDADE AS QTD, PRO.ANOTACOES AS ANOTAÇÕES
                                                    FROM MBLanches.PRODUTO AS PRO JOIN MBLanches.CATEGORIA AS CAT ON PRO.IDCategoria = CAT.IDCategoria WHERE PRO.DESCRICAO LIKE @DESCRICAO", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@DESCRICAO", produto.Descricao + "%");
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        //método consultar por Código
//        public DataTable ConsultaPorCodigo(Classe.Produto produto)
//        {
//            //passando comando de consulta
//            //SqlDataAdapter da = new SqlDataAdapter("SELECT IDPRODUTO AS CÓD, DESCRICAO AS DESCRIÇÃO, IDCATEGORIA AS CATEGORIA, PRECOVENDA AS PREÇO, VALIDADE, QUANTIDADE AS QTD, ANOTACOES AS ANOTAÇÕES FROM MBLanches.PRODUTO WHERE DESCRICAO LIKE @DESCRICAO", con.Conectar());
//            SqlDataAdapter da = new SqlDataAdapter(@"SELECT PRO.IDPRODUTO AS CÓD, PRO.DESCRICAO AS DESCRIÇÃO, CAT.Categoria AS CATEGORIA, PRO.PRECOVENDA AS PREÇO, PRO.VALIDADE, PRO.QUANTIDADE AS QTD, PRO.ANOTACOES AS ANOTAÇÕES
//                                                    FROM MBLanches.PRODUTO AS PRO JOIN MBLanches.CATEGORIA AS CAT ON PRO.IDCategoria = CAT.IDCategoria WHERE PRO.IDPRODUTO LIKE @IDPRODUTO", con.Conectar());
//            da.SelectCommand.Parameters.AddWithValue("@IDPRODUTO", produto.Descricao + "%");
//            DataTable dt = new DataTable();//criando tabela de dados
//            da.Fill(dt); //preenchendo tabela de dados
//            con.Desconectar(); //desconectando
//            return dt; //retornando tabela de dados preenchida
//        }

        //método consultar por Categoria
        public DataTable ConsultaPorCategoria(Classe.Categoria categoria)
        {
            //passando comando de consulta
            //SqlDataAdapter da = new SqlDataAdapter("SELECT IDPRODUTO AS CÓD, DESCRICAO AS DESCRIÇÃO, IDCATEGORIA AS CATEGORIA, PRECOVENDA AS PREÇO, VALIDADE, QUANTIDADE AS QTD, ANOTACOES AS ANOTAÇÕES FROM MBLanches.PRODUTO WHERE DESCRICAO LIKE @DESCRICAO", con.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT PRO.IDPRODUTO AS CÓD, PRO.DESCRICAO AS DESCRIÇÃO, CAT.Categoria AS CATEGORIA, PRO.PRECOVENDA AS PREÇO, PRO.VALIDADE, PRO.QUANTIDADE AS QTD, PRO.ANOTACOES AS ANOTAÇÕES
                                                    FROM MBLanches.PRODUTO AS PRO JOIN MBLanches.CATEGORIA AS CAT ON PRO.IDCategoria = CAT.IDCategoria WHERE CAT.CATEGORIA LIKE @CATEGORIA", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@CATEGORIA", categoria.Categorias + "%");
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        //método consultar por Data de Validade
        public DataTable ConsultaPorValidade(Classe.Produto produto)
        {
            //passando comando de consulta
            //SqlDataAdapter da = new SqlDataAdapter("SELECT IDPRODUTO AS CÓD, DESCRICAO AS DESCRIÇÃO, IDCATEGORIA AS CATEGORIA, PRECOVENDA AS PREÇO, VALIDADE, QUANTIDADE AS QTD, ANOTACOES AS ANOTAÇÕES FROM MBLanches.PRODUTO WHERE DESCRICAO LIKE @DESCRICAO", con.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT PRO.IDPRODUTO AS CÓD, PRO.DESCRICAO AS DESCRIÇÃO, CAT.Categoria AS CATEGORIA, PRO.PRECOVENDA AS PREÇO, PRO.VALIDADE, PRO.QUANTIDADE AS QTD, PRO.ANOTACOES AS ANOTAÇÕES
                                                    FROM MBLanches.PRODUTO AS PRO JOIN MBLanches.CATEGORIA AS CAT ON PRO.IDCategoria = CAT.IDCategoria WHERE PRO.VALIDADE LIKE @VALIDADE", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@VALIDADE", produto.Descricao + "%");
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        //Método Excluir
        public void Excluir(Classe.Produto produto)
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM MBLanches.PRODUTO WHERE IDPRODUTO = @IDPRODUTO", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@IDPRODUTO", produto.IDProduto);
            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }


        public Classe.Produto RetornarDados(Classe.Produto produto)
        {
            //buscar os dados com base no código fornecido
            SqlCommand cmd = new SqlCommand("SELECT * FROM MBLanches.PRODUTO WHERE IDPRODUTO = @IDPRODUTO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDPRODUTO", produto.IDProduto);
            SqlDataReader dr = cmd.ExecuteReader();//executa uma leitura dos dados para retorno
            if (dr.Read()) //conseguiu ler?
            {
                //preencher os atributos da classe
                produto.IDProduto = Convert.ToInt16(dr["IDPRODUTO"]);
                produto.Descricao = dr["DESCRICAO"].ToString();
                produto.IDCategoria = Convert.ToInt16(dr["IDCATEGORIA"]);
                produto.PrecoBruto = Convert.ToDouble(dr["PRECOBRUTO"]);
                produto.PrecoVenda = Convert.ToDouble(dr["PRECOVENDA"]);
                produto.Validade = Convert.ToDateTime(dr["VALIDADE"]);
                produto.Imagem = dr["IMAGEM"].ToString(); //Verificar apos as mudanças 
                produto.Quantidade = Convert.ToInt32(dr["QUANTIDADE"]);
                produto.Anotacoes = dr["ANOTACOES"].ToString();

            }
            dr.Close();//fechar leitura 
            con.Desconectar();//desconectar do bd
            return produto;//retornar objeto preenchido
        }
    }
}
