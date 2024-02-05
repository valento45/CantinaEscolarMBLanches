using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CantinaEscolarMBLanches.Dados
{
    class VendaPedidoDAL
    {
        Conexao con = new Conexao();

        public int Cadastrar(Classe.Venda_Pedido VendaPedidoBLL)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO MBLanches.VENDA_PEDIDO (DATAVENDA, IDCLIENTE, PRECOTOTAL, PAGAMENTO,IDUSUARIO) VALUES (GETDATE(),@IDCLIENTE,@PRECOTOTAL,@PAGAMENTO,@IDUSUARIO);SELECT SCOPE_IDENTITY();", con.Conectar());
            cmd.Parameters.AddWithValue("@IDCLIENTE", VendaPedidoBLL.IDCliente);
            cmd.Parameters.AddWithValue("@PRECOTOTAL", VendaPedidoBLL.PrecoTotal);
            cmd.Parameters.AddWithValue("@PAGAMENTO", VendaPedidoBLL.Pagamento);
            cmd.Parameters.AddWithValue("@IDUSUARIO", VendaPedidoBLL.IDUsuario);
            int chave_gerada = 0;
            chave_gerada = Convert.ToInt16(cmd.ExecuteScalar());
            con.Desconectar();
            return chave_gerada;
        }

        public void Atualizar(Classe.Venda_Pedido VendaPedidoBLL)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE MBLanches.VENDA_PEDIDO SET DATAVENDA = @DATAVENDA, IDCLIENTE = @IDCLIENTE, IDUSUARIO = @IDUSUARIO, IDPRODUTO = @IDPRODUTO, PRECOTOTAL = @PRECOTOTAL, PAGAMENTO = @PAGAMENTO WHERE IDVENDA = @IDVENDA", con.Conectar());
            cmd.Parameters.AddWithValue("@IDVENDA", VendaPedidoBLL.IDVenda);
            cmd.Parameters.AddWithValue("@DATAVENDA", VendaPedidoBLL.DataVenda);
            cmd.Parameters.AddWithValue("@IDCLIENTE", VendaPedidoBLL.IDCliente);
            cmd.Parameters.AddWithValue("@IDUSUARIO", VendaPedidoBLL.IDUsuario);
            cmd.Parameters.AddWithValue("@PRECOTOTAL", VendaPedidoBLL.PrecoTotal);
            cmd.Parameters.AddWithValue("@PAGAMENTO", VendaPedidoBLL.Pagamento);
            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        //método consultar Todos
        public DataTable ConsultarTodos()
        {
            //passando comando de consulta
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT VEN.IDVENDA AS CÓD, VEN.DATAVENDA AS [DATA VENDA], CLI.Nome, VEN.PRECOTOTAL AS [PREÇO TOTAL], VEN.PAGAMENTO, USU.USUARIO
                                                    FROM MBLanches.VENDA_PEDIDO AS VEN JOIN MBLanches.USUARIO AS USU ON VEN.IDUsuario = USU.IDUsuario
                                                    JOIN MBLanches.CLIENTE AS CLI ON CLI.IDCliente = VEN.IDCliente", con.Conectar());
            DataTable dt = new DataTable();//criando tabela de dados
            da.Fill(dt); //preenchendo tabela de dados
            con.Desconectar(); //desconectando
            return dt; //retornando tabela de dados preenchida
        }

        public void Excluir(Classe.Venda_Pedido VendaPedidoBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM MBLanches.VENDA_PEDIDO WHERE IDVENDA = @IDVENDA", con.Conectar());
            cmd.Parameters.AddWithValue("@IDVENDA", VendaPedidoBLL.IDVenda);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable ConsultarPorCodigo(Classe.Venda_Pedido VendaPedidoBLL)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDVENDA AS CÓDIGO, DATAVENDA, IDCLIENTE, IDUSUARIO, IDPRODUTO,PRECOTOTAL, PAGAMENTO ORDER BY CÓDIGO", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;

        }
        public decimal ConsultarProdutoPorPreco(int idproduto)
        {
            SqlCommand cmd = new SqlCommand("SELECT PRECOVENDA FROM MBLanches.PRODUTO WHERE IDPRODUTO = @ID", con.Conectar());
            cmd.Parameters.AddWithValue("@ID", idproduto);
            decimal preco = (decimal)cmd.ExecuteScalar();
            con.Desconectar();
            return preco;


        }
        

        public Classe.Venda_Pedido RetornarDados(Classe.Venda_Pedido VendaPedidoBLL)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MBLanches.VENDA_PEDIDO WHERE IDVENDA = @IDVENDA", con.Conectar());
            cmd.Parameters.AddWithValue("@IDVENDA", VendaPedidoBLL.IDVenda);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                VendaPedidoBLL.IDVenda = Convert.ToInt16(dr["IDVENDA"]);
                VendaPedidoBLL.IDCliente = Convert.ToInt16(dr["IDCLIENTE"]);
                VendaPedidoBLL.IDUsuario = Convert.ToInt16(dr["IDUSUARIO"]);
                VendaPedidoBLL.PrecoTotal = Convert.ToDouble(dr["PRECOTOTAL"]);
                VendaPedidoBLL.Pagamento = dr["PAGAMENTO"].ToString();
                VendaPedidoBLL.DataVenda = Convert.ToDateTime(dr["DATAVENDA"]);
            }
            dr.Close();
            con.Desconectar();
            return VendaPedidoBLL;
        }
    }
}
