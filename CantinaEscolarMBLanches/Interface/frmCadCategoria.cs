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
    public partial class frmCadCategoria : Form
    {
        //referencia das classes de Categoria
        Classe.Categoria categoria = new Classe.Categoria();
        Dados.ProdutoDAL produtoDAL = new Dados.ProdutoDAL();
        Dados.CategoriaDAL categoriaDAL = new Dados.CategoriaDAL();

        //variavel controladora de alteração
        bool alterar = false;

        public frmCadCategoria()
        {
            InitializeComponent();
        }


        public frmCadCategoria(int idCategoria)
        {
            InitializeComponent();

            categoria.IDCategoria = idCategoria;//pegando o código da sala
            categoria = categoriaDAL.RetornarDados(categoria);//chamando o método para preencher
            //preenchendo os campos do formulário
            txtCategoria.Text = categoria.Categorias;

            //mudando variável para saber que será uma alteração
            alterar = true;
        }

        //Método para filtrar na guia busca do from categoria
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //consultar com filtro (clicar duas vezes na textbox)
            categoria.Categorias = txtFiltro.Text;
            dgvConsulta.DataSource = categoriaDAL.ConsultarPorCategoria(categoria);
        }
        //Comando para carregar a tabela de usuarios no from Categoria
        private void frmCadCategoria_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = categoriaDAL.ConsultarTodos();
            txtCategoria.Focus();
        }
        //Método do botão novo do formulario Categoria
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCategoria.Clear();
            txtCategoria.Focus();
            alterar = false; //passa ser falso para o cadastro
            //direcionar para primeira aba
            tabCategoria.SelectedTab = tabCategoriaPag1;
        }
        //Método do botão excluir do from Catagoria
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA REALMENTE EXCLUIR ESTA CATEGORIA?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    categoria.IDCategoria = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value); //pegando o código que é exibido na tabela (datagridview)
                    //executando o método excluir
                    categoriaDAL.Excluir(categoria);
                    MessageBox.Show("Dados excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //atualizar a consulta
                    dgvConsulta.DataSource = categoriaDAL.ConsultarTodos();
                   
                }
                catch
                {
                    MessageBox.Show("Não é possivel excluir esta categoria, pois ele está cadatrado em um produto", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Método do botão salvar do from Categoria
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                MessageBox.Show("Preencha o nome da Categoria!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

                //enviando valores dos campos para a classe Curso
                categoria.Categorias = txtCategoria.Text;
                //executando o método da classe CategoriaDAL
                if (alterar == true)
                {
                    categoriaDAL.Atualizar(categoria);
                    //enviando mensagem de confirmação
                    MessageBox.Show("Dados Atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNovo.PerformClick();//chamando o clique do botão limpar
                    dgvConsulta.DataSource = categoriaDAL.ConsultarPorCategoria(categoria);
                    Close();

                    return;
                }
                else
                {
                    categoriaDAL.Cadastrar(categoria);
                }
                //enviando mensagem de confirmação
                MessageBox.Show("Dados Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.PerformClick();//chamando o clique do botão limpar
                dgvConsulta.DataSource = categoriaDAL.ConsultarPorCategoria(categoria);
            }
            catch
            {
                MessageBox.Show("Preencha corretamente o nome da categoria", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Método para ao clicar no nome da busca, ativar a opção de editar os dados
        private void dgvConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0)//tem linhas?
            {
                //direcionar para primeira aba
                tabCategoria.SelectedTab = tabCategoriaPag1;

                //preenchendo os campos do formulário
                categoria.IDCategoria = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);//pegando o código da usuario
                categoria = categoriaDAL.RetornarDados(categoria);//chamando o método para preencher
                //preenchendo os campos do formulário
                txtCategoria.Text = categoria.Categorias;
                //mudando variável para saber que será uma alteração
                alterar = true;
            }
        }

        //Ação do botão do formulario Categoria
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
