using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//precisa
using System.Data.SqlClient;//precisa

namespace CantinaEscolarMBLanches.Dados
{
    class ClienteDAL
    {
        //instancia / referencia da classe de conexão
        Conexao con = new Conexao();

        //método cadastrar
        public void Cadastrar(Classe.Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO MBLanches.CLIENTE (NOME, TELEFONE, IDCURSO, TIPOCLIENTE, PERIODO, OBSERVACOES)
                                            VALUES (@NOME, @TELEFONE, @IDCURSO, @TIPOCLIENTE, @PERIODO, @OBSERVACOES)", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@NOME", cliente.Nome);
            cmd.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            cmd.Parameters.AddWithValue("@IDCURSO", cliente.IDCurso);
            cmd.Parameters.AddWithValue("@TIPOCLIENTE", cliente.TipoCliente);
            cmd.Parameters.AddWithValue("@PERIODO", cliente.Periodo);
            cmd.Parameters.AddWithValue("@OBSERVACOES", cliente.Observacoes);

            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }
        //método Atualizar
        public void Atualizar(Classe.Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE MBLanches.CLIENTE SET NOME = @NOME, TELEFONE = @TELEFONE, @IDCURSO = @IDCURSO, TIPOCLIENTE = @TIPOCLIENTE, PERIODO = @PERIODO, OBSERVACOES = @OBSERVACOES WHERE IDCLIENTE = @IDCLIENTE", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@IDCLIENTE", cliente.IDCliente);
            cmd.Parameters.AddWithValue("@NOME", cliente.Nome);
            cmd.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            cmd.Parameters.AddWithValue("@IDCURSO", cliente.IDCurso);
            cmd.Parameters.AddWithValue("@TIPOCLIENTE", cliente.TipoCliente);
            cmd.Parameters.AddWithValue("@PERIODO", cliente.Periodo);
            cmd.Parameters.AddWithValue("@OBSERVACOES", cliente.Observacoes);
            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }


        //método consultar Todos
        public DataTable ConsultarTodos()
        {
            //passando comando de consulta
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CLI.IDCLIENTE AS CÓD, CLI.NOME, CLI.TELEFONE, CLI.TIPOCLIENTE AS TIPO, C.CURSO, CLI.PERIODO AS PERÍODO, CLI.OBSERVACOES AS OBSERVAÇÕES
                                                   FROM MBLanches.CLIENTE AS CLI JOIN MBLanches.CURSO AS C ON CLI.IDCurso = C.IDCurso", con.Conectar());
            //SqlDataAdapter da = new SqlDataAdapter("SELECT IDCLIENTE AS CÓDIGO, NOME, TELEFONE, TIPOCLIENTE AS TIPO, IDCURSO AS CURSO, PERIODO AS PERÍODO, OBSERVACOES AS OBSERVAÇÕES FROM MBLanches.CLIENTE ORDER BY IDCLIENTE", con.Conectar());
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        //método consultar por nome
        public DataTable ConsultaPorNome(Classe.Cliente cliente)
        {
            //passando comando de consulta
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CLI.IDCLIENTE AS CÓD, CLI.NOME, CLI.TELEFONE, CLI.TIPOCLIENTE AS TIPO, C.CURSO, CLI.PERIODO AS PERÍODO, CLI.OBSERVACOES AS OBSERVAÇÕES
                                                    FROM MBLanches.CLIENTE AS CLI JOIN MBLanches.CURSO AS C ON CLI.IDCurso = C.IDCurso WHERE CLI.NOME LIKE @NOME", con.Conectar());
            //SqlDataAdapter da = new SqlDataAdapter("SELECT IDCLIENTE AS CÓDIGO, NOME, TELEFONE, TIPOCLIENTE AS TIPO, IDCURSO AS CURSO, PERIODO AS PERÍODO, OBSERVACOES AS OBSERVAÇÕES FROM MBLanches.CLIENTE WHERE NOME LIKE @NOME", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NOME", cliente.Nome + "%");
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        //Método pesquisar por Tipo
        public DataTable ConsultaPorTipo(Classe.Cliente cliente)
        {
            //passando comando de consulta
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CLI.IDCLIENTE AS CÓD, CLI.NOME, CLI.TELEFONE, CLI.TIPOCLIENTE AS TIPO, C.CURSO, CLI.PERIODO AS PERÍODO, CLI.OBSERVACOES AS OBSERVAÇÕES
                                                    FROM MBLanches.CLIENTE AS CLI JOIN MBLanches.CURSO AS C ON CLI.IDCurso = C.IDCurso WHERE CLI.TIPOCLIENTE LIKE @TIPOCLIENTE", con.Conectar());
            //SqlDataAdapter da = new SqlDataAdapter("SELECT IDCLIENTE AS CÓDIGO, NOME, TELEFONE, TIPOCLIENTE AS TIPO, IDCURSO AS CURSO, PERIODO AS PERÍODO, OBSERVACOES AS OBSERVAÇÕES FROM MBLanches.CLIENTE WHERE NOME LIKE @NOME", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@TIPOCLIENTE", cliente.TipoCliente + "%");
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        //Método Excluir
        public void Excluir(Classe.Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM MBLanches.CLIENTE WHERE IDCLIENTE = @IDCLIENTE", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@IDCLIENTE", cliente.IDCliente);
            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }


        public Classe.Cliente RetornarDados(Classe.Cliente cliente)
        {
            //buscar os dados com base no código fornecido
            SqlCommand cmd = new SqlCommand("SELECT * FROM MBLanches.CLIENTE WHERE IDCLIENTE = @IDCLIENTE", con.Conectar());
            cmd.Parameters.AddWithValue("@IDCLIENTE", cliente.IDCliente);
            SqlDataReader dr = cmd.ExecuteReader();//executa uma leitura dos dados para retorno
            if (dr.Read()) //conseguiu ler?
            {
                //preencher os atributos da classe
                cliente.IDCliente = Convert.ToInt16(dr["IDCLIENTE"]);
                cliente.Nome = dr["NOME"].ToString();
                cliente.TipoCliente = dr["TIPOCLIENTE"].ToString();
                cliente.Telefone = dr["TELEFONE"].ToString();
                cliente.IDCurso = Convert.ToInt16(dr["IDCURSO"]);
                cliente.Periodo = dr["PERIODO"].ToString();
                cliente.Observacoes = dr["OBSERVACOES"].ToString();

            }
            dr.Close();//fechar leitura 
            con.Desconectar();//desconectar do bd
            return cliente;//retornar objeto preenchido
        }
    }
}