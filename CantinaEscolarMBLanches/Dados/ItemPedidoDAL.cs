using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CantinaEscolarMBLanches.Dados
{
    class ItemPedidoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(Classe.Item_Pedido ItemPedidoBLL)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO MBLanches.ITEM_PEDIDO (IDVENDA,IDPRODUTO,PRECOUNITARIO,QUANTPEDIDO) VALUES (@IDVENDA,@IDPRODUTO,@PRECOUNITARIO,@QUANTPEDIDO)", con.Conectar());
            cmd.Parameters.AddWithValue("@IDVENDA", ItemPedidoBLL.IDVenda);
            cmd.Parameters.AddWithValue("@IDPRODUTO", ItemPedidoBLL.IDProduto);
            cmd.Parameters.AddWithValue("@PRECOUNITARIO", ItemPedidoBLL.PrecoUnitario);
            cmd.Parameters.AddWithValue("@QUANTPEDIDO", ItemPedidoBLL.QuantPedido);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}
