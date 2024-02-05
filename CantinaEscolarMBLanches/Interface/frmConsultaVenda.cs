using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CantinaEscolarMBLanches.Interface
{
    public partial class frmConsultaVenda : Form
    {
        Classe.Venda_Pedido VendaBLL = new Classe.Venda_Pedido();
        Dados.VendaPedidoDAL VendaDAL = new Dados.VendaPedidoDAL();

        public frmConsultaVenda()
        {
            InitializeComponent();
        }
        //Carregar dados da tabela Vendas
        private void frmConsultaVenda_Load(object sender, EventArgs e)
        {
            //Carregar a tabela de cliente da consulta no from usuario
            dgvConsultaProduto.DataSource = VendaDAL.ConsultarTodos();
            txtFiltro.Focus();
        }
        //Ação para fechar o formulario consulta de vendas
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
