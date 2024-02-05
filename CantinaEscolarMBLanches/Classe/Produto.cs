using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaEscolarMBLanches.Classe
{
    class Produto
    {
        int iDProduto;

        public int IDProduto
        {
            get { return iDProduto; }
            set { iDProduto = value; }
        }
        string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        int Idcategoria;

        public int IDCategoria
        {
            get { return Idcategoria; }
            set { Idcategoria = value; }
        }
        double precoBruto;

        public double PrecoBruto
        {
            get { return precoBruto; }
            set { precoBruto = value; }
        }

        double precoVenda;

        public double PrecoVenda
        {
            get { return precoVenda; }
            set { precoVenda = value; }
        }
        DateTime validade;

        public DateTime Validade
        {
            get { return validade; }
            set { validade = value; }
        }
        string imagem;

        public string Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }
        int quantidade;

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        string anotacoes;

        public string Anotacoes
        {
            get { return anotacoes; }
            set { anotacoes = value; }
        }
    }
}
