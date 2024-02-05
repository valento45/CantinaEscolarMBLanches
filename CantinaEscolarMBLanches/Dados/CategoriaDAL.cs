using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//precisa
using System.Data.SqlClient;//precisa


namespace CantinaEscolarMBLanches.Dados
{
    class CategoriaDAL
    {
        //instancia / referencia da classe de conexão
        Conexao con = new Conexao();

        //método cadastrar
        public void Cadastrar(Classe.Categoria categoria)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO MBLanches.CATEGORIA (CATEGORIA)
                                            VALUES (@CATEGORIA)", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@CATEGORIA", categoria.Categorias);
            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }

        //método Atualizar
        public void Atualizar(Classe.Categoria categoria)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE MBLanches.CATEGORIA SET CATEGORIA = @CATEGORIA WHERE IDCATEGORIA = @IDCATEGORIA ", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@IDCATEGORIA", categoria.IDCategoria);
            cmd.Parameters.AddWithValue("@CATEGORIA", categoria.Categorias);
            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }


        //método consultar Todos
        public DataTable ConsultarTodos()
        {
            //passando comando de consulta
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDCATEGORIA AS CÓDIGO, CATEGORIA AS CATEGORIAS FROM MBLanches.CATEGORIA ORDER BY IDCATEGORIA", con.Conectar());
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        //método consultar por curso
        public DataTable ConsultarPorCategoria(Classe.Categoria categoria)
        {
            //passando comando de consulta
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDCATEGORIA AS CÓDIGO, CATEGORIA AS CATEGORIAS FROM MBLanches.CATEGORIA WHERE CATEGORIA LIKE @CATEGORIA ORDER BY IDCATEGORIA", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@CATEGORIA", categoria.Categorias + "%");
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        //método Excluir
        public void Excluir(Classe.Categoria categoria)
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM MBLanches.CATEGORIA WHERE IDCATEGORIA = @IDCATEGORIA", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@IDCATEGORIA", categoria.IDCategoria);
            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }


        public Classe.Categoria RetornarDados(Classe.Categoria categoria)
        {
            //buscar os dados com base no código fornecido
            SqlCommand cmd = new SqlCommand("SELECT * FROM MBLanches.CATEGORIA WHERE IDCATEGORIA = @IDCATEGORIA", con.Conectar());
            cmd.Parameters.AddWithValue("@IDCATEGORIA", categoria.IDCategoria);
            SqlDataReader dr = cmd.ExecuteReader();//executa uma leitura dos dados para retorno
            if (dr.Read()) //conseguiu ler?
            {
                //preencher os atributos da classe
                categoria.IDCategoria= Convert.ToInt16(dr["IDCATEGORIA"]);
                categoria.Categorias = dr["CATEGORIA"].ToString();
            }
            dr.Close();//fechar leitura 
            con.Desconectar();//desconectar do bd
            return categoria;//retornar objeto preenchido
        }
    }
}
