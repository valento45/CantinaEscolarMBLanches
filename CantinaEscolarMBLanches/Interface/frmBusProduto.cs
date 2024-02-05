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
    public partial class frmBusProduto : Form
    {
        Classe.Produto ProdutoBLL = new Classe.Produto();
        Dados.ProdutoDAL ProdutoDAL = new Dados.ProdutoDAL();

        public int IDProduto { get; set; }

        public frmBusProduto()
        {
            InitializeComponent();
        }
        //Método para carregar os dados do produto na tabela
        private void frmBusProduto_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = ProdutoDAL.ConsultarTodos();   
        }

        //Método para efetuar a pesquisa pelo Produto
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            ProdutoBLL.Descricao = txtFiltro.Text;
            dgvConsulta.DataSource = ProdutoDAL.ConsultaPorProduto(ProdutoBLL);
        }
        //Método para selecionar o produto
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0)
            {
                IDProduto = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value.ToString());
                this.Close();
            }
        }
        //Método para ativar o atalho ao clicar no txt
        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            //caso clicar no botão Enter
            if (e.KeyCode == Keys.Enter)
            {
                btnSelecionar.PerformClick();//ativa o clique do botão selecionar
            }
        }
        //Ação do botão sair do formulario produto
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Método para selecionar o produto
        private void dgvConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0)
            {
                IDProduto = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value.ToString());
                this.Close();
            }
        }
        //Método para abrir o formulario de cadastro de produtos
        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            Interface.frmCadProduto produto = new Interface.frmCadProduto();
            produto.ShowDialog();

            //exibir atualização do cadastro diretamente na consulta de clientes
            dgvConsulta.DataSource = ProdutoDAL.ConsultarTodos();
        }
    }
}
