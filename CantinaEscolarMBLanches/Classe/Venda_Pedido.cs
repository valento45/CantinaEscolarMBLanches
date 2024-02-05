using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaEscolarMBLanches.Classe
{
    class Venda_Pedido
    {
        int iDVenda;

        public int IDVenda
        {
            get { return iDVenda; }
            set { iDVenda = value; }
        }
        DateTime dataVenda;

        public DateTime DataVenda
        {
            get { return dataVenda; }
            set { dataVenda = value; }
        }
        int Idcliente;

        public int IDCliente
        {
            get { return Idcliente; }
            set { Idcliente = value; }
        }
        double precoTotal;

        public double PrecoTotal
        {
            get { return precoTotal; }
            set { precoTotal = value; }
        }
        string pagamento;

        public string Pagamento
        {
            get { return pagamento; }
            set { pagamento = value; }
        }
        int Idusuario;

        public int IDUsuario
        {
            get { return Idusuario; }
            set { Idusuario = value; }
        }
        int desconto;

        public int Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }

    }
}
