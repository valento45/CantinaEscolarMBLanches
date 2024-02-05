using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaEscolarMBLanches.Classe
{
    class Item_Pedido
    {
        int idItempedido;

        public int IdItemPedido
        {
            get { return idItempedido; }
            set { idItempedido = value; }
        }
        int IDvenda;

        public int IDVenda
        {
            get { return IDvenda; }
            set { IDvenda = value; }
        }
        int IDproduto;

        public int IDProduto
        {
            get { return IDproduto; }
            set { IDproduto = value; }
        }
        double precoUnitario;

        public double PrecoUnitario
        {
            get { return precoUnitario; }
            set { precoUnitario = value; }
        }
        int quantPedido;

        public int QuantPedido
        {
            get { return quantPedido; }
            set { quantPedido = value; }
        }
    }
}
