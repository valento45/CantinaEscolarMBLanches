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
    public partial class frmConsultaCategoria : Form
    {
        Classe.Categoria categoria = new Classe.Categoria();
        Dados.CategoriaDAL categoriaDAL = new Dados.CategoriaDAL();
        public frmConsultaCategoria()
        {
            InitializeComponent();
        }
        //Carregar dados da tabela Categoria
        private void frmConsultaCategoria_Load(object sender, EventArgs e)
        {
            //Carregar a tabela de categoria da consulta no from categoria
            dgvConsultaCategoria.DataSource = categoriaDAL.ConsultarTodos();
            txtFiltro.Focus();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            categoria.Categorias = txtFiltro.Text;
            dgvConsultaCategoria.DataSource = categoriaDAL.ConsultarPorCategoria(categoria);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Interface.frmCadCategoria ConCategoria = new Interface.frmCadCategoria();
            ConCategoria.ShowDialog();

            //exibir consulta de categoria na combobox
            dgvConsultaCategoria.DataSource = categoriaDAL.ConsultarTodos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA REALMENTE EXCLUIR ESTA CATEGORIA?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                categoria.IDCategoria = Convert.ToInt16(dgvConsultaCategoria.SelectedCells[0].Value); //pegando o código que é exibido na tabela (datagridview)
                //executando o método excluir
                categoriaDAL.Excluir(categoria);
                //atualizar a consulta
                dgvConsultaCategoria.DataSource = categoriaDAL.ConsultarTodos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //abrir formulário passando código como argumento
            //o código virá do datagridview (primeira coluna)
            frmCadCategoria cadCat = new frmCadCategoria(Convert.ToInt16(dgvConsultaCategoria.SelectedCells[0].Value));
            cadCat.ShowDialog();
            //atualizar a consulta
            dgvConsultaCategoria.DataSource = categoriaDAL.ConsultarTodos();
        }
    }
}
