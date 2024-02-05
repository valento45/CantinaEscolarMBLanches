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
    public partial class frmEstoque : Form
    {
        Classe.Produto produto = new Classe.Produto();
        Dados.ProdutoDAL produtoDAL = new Dados.ProdutoDAL();

        public frmEstoque()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            Interface.frmEntradaEstoque EntradaEstoque = new Interface.frmEntradaEstoque();
            EntradaEstoque.ShowDialog();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            Interface.frmSaidaEstoque SaidaEstoque = new Interface.frmSaidaEstoque();
            SaidaEstoque.ShowDialog();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            dgvListaProduto.DataSource = produtoDAL.ConsultarTodos();
            txtFiltro.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Interface.frmCadProduto AddProduto = new Interface.frmCadProduto();
            AddProduto.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA REALMENTE EXCLUIR ESTE PRODUTO?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                produto.IDProduto = Convert.ToInt16(dgvListaProduto.SelectedCells[0].Value); //pegando o código que é exibido na tabela (datagridview)
                //executando o método excluir
                produtoDAL.Excluir(produto);
                //atualizar a consulta
                dgvListaProduto.DataSource = produtoDAL.ConsultarTodos();
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            produto.Descricao = txtFiltro.Text;
            dgvListaProduto.DataSource = produtoDAL.ConsultaPorProduto(produto);
        }
    }
}
