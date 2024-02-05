using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//precisa
using System.Data.SqlClient;//precisa

namespace CantinaEscolarMBLanches.Dados
{
    class CursoDAL
    {
        //instancia / referencia da classe de conexão
        Conexao con = new Conexao();

        //método cadastrar
        public void Cadastrar(Classe.Curso curso)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO MBLanches.CURSO (CURSO)
                                            VALUES (@CURSO)", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@CURSO", curso.Cursos);
            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }

        //método Atualizar
        public void Atualizar(Classe.Curso curso)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE MBLanches.CURSO SET CURSO = @CURSO WHERE IDCURSO = @IDCURSO ", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@IDCURSO", curso.IDCurso);
            cmd.Parameters.AddWithValue("@CURSO", curso.Cursos);
            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }


        //método consultar Todos
        public DataTable ConsultarTodos()
        {
            //passando comando de consulta
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDCURSO AS CÓDIGO, CURSO [NOME DO CURSO] FROM MBLanches.CURSO ORDER BY IDCURSO", con.Conectar());
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        //método consultar por curso
        public DataTable ConsultarPorCurso(Classe.Curso curso)
        {
            //passando comando de consulta
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDCURSO AS CÓDIGO, CURSO [NOME DO CURSO] FROM MBLanches.CURSO WHERE CURSO LIKE @CURSO ORDER BY IDCURSO", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@CURSO", curso.Cursos + "%");
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        //método Excluir
        public void Excluir(Classe.Curso curso)
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM MBLanches.CURSO WHERE IDCURSO = @IDCURSO", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@IDCURSO", curso.IDCurso);
            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }


        public Classe.Curso RetornarDados(Classe.Curso curso)
        {
            //buscar os dados com base no código fornecido
            SqlCommand cmd = new SqlCommand("SELECT * FROM MBLanches.CURSO WHERE IDCURSO = @IDCURSO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDCURSO", curso.IDCurso);
            SqlDataReader dr = cmd.ExecuteReader();//executa uma leitura dos dados para retorno
            if (dr.Read()) //conseguiu ler?
            {
                //preencher os atributos da classe
                curso.IDCurso = Convert.ToInt16(dr["IDCURSO"]);
                curso.Cursos = dr["CURSO"].ToString();
            }
            dr.Close();//fechar leitura 
            con.Desconectar();//desconectar do bd
            return curso;//retornar objeto preenchido
        }
    }
}
