using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //precisa
using System.Data.SqlClient; //precisa

namespace CantinaEscolarMBLanches.Dados
{
    class Conexao
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAB33-04\SQLSERVER;Initial Catalog=CantinaEscolar;Integrated Security=True");

        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();//abrindo conexão
            }
                
            return con;//retorna a conexão aberta
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
