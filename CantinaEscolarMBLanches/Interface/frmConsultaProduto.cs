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
    public partial class frmConsultaProduto : Form
    {
        Classe.Produto produto = new Classe.Produto();
        Dados.ProdutoDAL produtoDAL = new Dados.ProdutoDAL();
        Classe.Categoria categoria = new Classe.Categoria();
        public frmConsultaProduto()
        {
            InitializeComponent();
        }
        //Carregar dados da tabela Produto
        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            lblMsgFiltro.Visible = false;
            //Carregar a tabela de cliente da consulta no from usuario
            dgvConsultaProduto.DataSource = produtoDAL.ConsultarTodos();
            txtFiltro.Focus();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            
            if (rdbNome.Checked)
            {
                produto.Descricao = txtFiltro.Text;
                dgvConsultaProduto.DataSource = produtoDAL.ConsultaPorProduto(produto);
            }
            else if (rdbCategoria.Checked)
            {
                categoria.Categorias = txtFiltro.Text;
                dgvConsultaProduto.DataSource = produtoDAL.ConsultaPorCategoria(categoria);
            }
            else 
            {
                lblMsgFiltro.Visible = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Interface.frmCadProduto cadProduto = new Interface.frmCadProduto();
            cadProduto.ShowDialog();

            //exibir consulta de categoria na combobox
            dgvConsultaProduto.DataSource = produtoDAL.ConsultarTodos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA REALMENTE EXCLUIR ESTE PRODUTO?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                produto.IDProduto = Convert.ToInt16(dgvConsultaProduto.SelectedCells[0].Value); //pegando o código que é exibido na tabela (datagridview)
                //executando o método excluir
                produtoDAL.Excluir(produto);
                //atualizar a consulta
                dgvConsultaProduto.DataSource = produtoDAL.ConsultarTodos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //abrir formulário passando código como argumento
            //o código virá do datagridview (primeira coluna)
            frmCadProduto cadProduto = new frmCadProduto(Convert.ToInt16(dgvConsultaProduto.SelectedCells[0].Value));
            cadProduto.ShowDialog();
            //atualizar a consulta
            dgvConsultaProduto.DataSource = produtoDAL.ConsultarTodos();
        }
    }
}
