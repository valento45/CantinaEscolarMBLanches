using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//precisa
using System.Data.SqlClient;//precisa

namespace CantinaEscolarMBLanches.Dados
{
    class UsuarioDAL
    {
        //instancia / referencia da classe de conexão
        Conexao con = new Conexao();

        //método cadastrar
        public void Cadastrar(Classe.Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO MBLanches.USUARIO (NOME, USUARIO, SENHA, EMAIL, PERFIL, SITUACAO)
                                            VALUES (@NOME, @USUARIO, @SENHA, @EMAIL, @PERFIL, @SITUACAO)", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@NOME", usuario.Nome);
            cmd.Parameters.AddWithValue("@USUARIO", usuario.Usuario1);
            cmd.Parameters.AddWithValue("@SENHA", usuario.Senha);
            cmd.Parameters.AddWithValue("@EMAIL", usuario.Email);
            cmd.Parameters.AddWithValue("@PERFIL", usuario.Perfil);
            cmd.Parameters.AddWithValue("@SITUACAO", usuario.Situacao);

            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }
        //método Atualizar
        public void Atualizar(Classe.Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE MBLanches.USUARIO SET NOME = @NOME, USUARIO = @USUARIO, EMAIL = @EMAIL, SENHA = @SENHA, PERFIL = @PERFIL, SITUACAO = @SITUACAO WHERE IDUSUARIO = @IDUSUARIO", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@IDUSUARIO", usuario.IDUsuario);
            cmd.Parameters.AddWithValue("@NOME", usuario.Nome);
            cmd.Parameters.AddWithValue("@USUARIO", usuario.Usuario1);
            cmd.Parameters.AddWithValue("@EMAIL", usuario.Email);
            cmd.Parameters.AddWithValue("@SENHA", usuario.Senha);
            cmd.Parameters.AddWithValue("@PERFIL", usuario.Perfil);
            cmd.Parameters.AddWithValue("@SITUACAO", usuario.Situacao);
            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }

        //método Atualizar senha
        public void AtualizarSenha(Classe.Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE MBLanches.USUARIO SET SENHA = @SENHA WHERE IDUSUARIO = @IDUSUARIO", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@IDUSUARIO", usuario.IDUsuario);
            cmd.Parameters.AddWithValue("@SENHA", usuario.Senha);
            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }


        //método consultar Todos
        public DataTable ConsultarTodos()
        {
            //passando comando de consulta
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDUSUARIO AS CÓD, NOME, USUARIO AS USUÁRIO, EMAIL AS [E-MAIL], SITUACAO AS SITUAÇÃO FROM MBLanches.USUARIO ORDER BY IDUSUARIO", con.Conectar());
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        //método consultar por nome
        public DataTable ConsultaPorNome(Classe.Usuario usuario)
        {
            //passando comando de consulta
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDUSUARIO AS CÓD, NOME, USUARIO AS USUÁRIO, EMAIL AS [E-MAIL], SITUACAO AS SITUAÇÃO FROM MBLanches.USUARIO WHERE NOME LIKE @NOME", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NOME", usuario.Nome + "%");
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        //método consultar por Situação
        public DataTable ConsultaPorUsuario(Classe.Usuario usuario)
        {
            //passando comando de consulta
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDUSUARIO AS CÓD, NOME, USUARIO AS USUÁRIO, EMAIL AS [E-MAIL], SITUACAO AS SITUAÇÃO FROM MBLanches.USUARIO WHERE USUARIO LIKE @USUARIO", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@USUARIO", usuario.Usuario1 + "%");
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        //Método Excluir
        public void Excluir(Classe.Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM MBLanches.USUARIO WHERE IDUSUARIO = @IDUSUARIO", con.Conectar());
            //referenciar os parâmnetros
            cmd.Parameters.AddWithValue("@IDUSUARIO", usuario.IDUsuario);
            //executar o comando
            cmd.ExecuteNonQuery();
            //fechar conexão
            con.Desconectar();
        }


        public Classe.Usuario RetornarDados(Classe.Usuario usuario)
        {
            //buscar os dados com base no código fornecido
            SqlCommand cmd = new SqlCommand("SELECT * FROM MBLanches.USUARIO WHERE IDUSUARIO = @IDUSUARIO", con.Conectar());
            cmd.Parameters.AddWithValue("@IDUSUARIO", usuario.IDUsuario);
            SqlDataReader dr = cmd.ExecuteReader();//executa uma leitura dos dados para retorno
            if (dr.Read()) //conseguiu ler?
            {
                //preencher os atributos da classe
                usuario.IDUsuario = Convert.ToInt16(dr["IDUSUARIO"]);
                usuario.Nome = dr["NOME"].ToString();
                usuario.Usuario1 = dr["USUARIO"].ToString();
                usuario.Senha = dr["SENHA"].ToString();
                usuario.Email = dr["EMAIL"].ToString();
                usuario.Situacao = Convert.ToBoolean(dr["SITUACAO"]);
                usuario.Perfil = Convert.ToBoolean(dr["PERFIL"]);
            }
            dr.Close();//fechar leitura 
            con.Desconectar();//desconectar do bd
            return usuario;//retornar objeto preenchido
        }
        //Buscar usuário e senha no banco de dados na tela login
        public Classe.Usuario Logar(Classe.Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MBLanches.USUARIO WHERE USUARIO = @USUARIO AND SENHA = @SENHA", con.Conectar());
            cmd.Parameters.AddWithValue("@USUARIO", usuario.Usuario1);
            cmd.Parameters.AddWithValue("@SENHA", usuario.Senha);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) //conseguiu ler?
            {
                //preencher os atributos da classe
                usuario.IDUsuario = Convert.ToInt16(dr["IDUSUARIO"]);
                usuario.Usuario1 = dr["USUARIO"].ToString();
                usuario.Senha = dr["SENHA"].ToString();
                usuario.Perfil = Convert.ToBoolean(dr["PERFIL"]);
            }
            else
            {
                usuario.IDUsuario = 0;
            }
            dr.Close();
            con.Desconectar();
            return usuario;
        }
        //Válida senha no banco de dados na troca de senha
        public Classe.Usuario Recuperar(Classe.Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MBLanches.USUARIO WHERE USUARIO = @USUARIO AND EMAIL = @EMAIL", con.Conectar());
            cmd.Parameters.AddWithValue("@USUARIO", usuario.Usuario1);
            cmd.Parameters.AddWithValue("@EMAIL", usuario.Email);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) //conseguiu ler?
            {
                //preencher os atributos da classe
                usuario.IDUsuario = Convert.ToInt16(dr["IDUSUARIO"]);
                usuario.Usuario1 = dr["USUARIO"].ToString();
                usuario.Senha = dr["SENHA"].ToString();
                usuario.Perfil = Convert.ToBoolean(dr["PERFIL"]);
            }
            else
            {
                usuario.IDUsuario = 0;
            }
            dr.Close();
            con.Desconectar();
            return usuario;
        }

    }
}
