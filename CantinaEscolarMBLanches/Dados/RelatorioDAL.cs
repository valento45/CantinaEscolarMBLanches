using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//Vai usar
using System.Data.SqlClient;//Precisa usar

namespace CantinaEscolarMBLanches.Dados
{
    class RelatorioDAL
    {
        Conexao con = new Conexao();

        //Método para o relatório CLiente
        public SqlDataAdapter RelatorioCliente()
        {
            SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM MBLanches.CLIENTE", con.Conectar());

            con.Desconectar();
            return da;

        }
        //Método para o relatório Usuário
        public SqlDataAdapter RelatorioUsuario()
        {
            SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM MBLanches.USUARIO", con.Conectar());

            con.Desconectar();
            return da;
        }
    }
}
