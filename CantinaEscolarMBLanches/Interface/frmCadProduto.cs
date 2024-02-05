using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CantinaEscolarMBLanches.Properties;//referencia para imagens

namespace CantinaEscolarMBLanches.Interface
{
    public partial class frmCadProduto : Form
    {
        Classe.Produto produto = new Classe.Produto();
        Dados.ProdutoDAL produtoDAL = new Dados.ProdutoDAL();
        Dados.CategoriaDAL categoriaDAL = new Dados.CategoriaDAL();
        Classe.Categoria categoria = new Classe.Categoria();

        //variavel controladora de alteração
        bool alterar = false;


        public frmCadProduto()
        {
            InitializeComponent();
        }

        public frmCadProduto(int idproduto)
        {
            InitializeComponent();


            produto.IDProduto = idproduto;//pegando o código da sala
            produto = produtoDAL.RetornarDados(produto);//chamando o método para preencher
            //preenchendo os campos do formulário
            txtDescricao.Text = produto.Descricao;
            cbCategoria.Text = categoria.Categorias;
            txtQuantidade.Text = (produto.Quantidade).ToString();
            txtPrecoBruto.Text = (produto.PrecoBruto).ToString();
            txtPrecoVenda.Text = (produto.PrecoVenda).ToString();
            txtValidade.Text = (produto.Validade).ToString();
            txtAnotacoes.Text = produto.Anotacoes;
            

            //mudando variável para saber que será uma alteração
            alterar = true;
        }

        //Método para atualizar a Combox preencher com os dados da tabela categoria
        private void frmCadProduto_Load(object sender, EventArgs e)
        {

            //exemplo carregar imagem do banco
            //imgProduto.ImageLocation = @"E:\ETEC - Francisco Morato\CANTINA ESCOLAR\IMG Projeto - EXEMPLO\Yakamura\imagem.png";

            //exibir consulta de categoria na combobox
            cbCategoria.DataSource = categoriaDAL.ConsultarTodos();
            cbCategoria.DisplayMember = "CATEGORIAS";//o que será exibido
            cbCategoria.ValueMember = "CÓDIGO";//valor a ser pego do item selecionado

            //Carregar a tabela de cliente da consulta no from produto
            dgvConsulta.DataSource = produtoDAL.ConsultarTodos();
            txtDescricao.Focus();

            //Limpa a caixa de Categoria
            cbCategoria.Text = "";
        }


        //Método do botão novo do From Produto
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            cbCategoria.Text = null;
            txtQuantidade.Clear();
            txtPrecoVenda.Clear();
            txtPrecoBruto.Clear();
            txtAnotacoes.Clear();
            imgProduto.Image = Resources.Produto_2;
            alterar = false; //passa ser falso para o cadastro

            //direcionar para primeira aba
            tabProduto.SelectedTab = tabProdutoPag1;
            txtDescricao.Focus();
        }
        //Método do botão salvar do from Produto
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
            produto.Descricao = txtDescricao.Text;
            produto.IDCategoria = Convert.ToInt16(cbCategoria.SelectedValue);//pegando a chave estrangeira
            produto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            produto.PrecoVenda = Convert.ToDouble(txtPrecoVenda.Text);
            produto.PrecoBruto = Convert.ToDouble(txtPrecoBruto.Text);
            produto.Validade = txtValidade.Value;
            produto.Imagem = lblCaminho.Text;
            produto.Anotacoes = txtAnotacoes.Text;

            if (alterar == true)
            {
                produtoDAL.Atualizar(produto);
                //enviando mensagem de confirmação
                MessageBox.Show("Dados atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.PerformClick();//chamando o clique do botão limpar
                dgvConsulta.DataSource = produtoDAL.ConsultaPorProduto(produto);
                Close();

                return;
            }
            else
            {
                produtoDAL.Cadastrar(produto);
                //enviando mensagem de confirmação
                MessageBox.Show("Dados cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.PerformClick();//chamando o clique do botão limpar
                dgvConsulta.DataSource = produtoDAL.ConsultaPorProduto(produto);

                imgProduto.Image.Save(Application.StartupPath+"\\pasta_imagens\\");
            }
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos do produto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Método do botão excluir do from Produto
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA REALMENTE EXCLUIR ESTE PRODUTO?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    produto.IDProduto = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value); //pegando o código que é exibido na tabela (datagridview)
                    //executando o método excluir
                    produtoDAL.Excluir(produto);
                    MessageBox.Show("Dados excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //atualizar a consulta
                    dgvConsulta.DataSource = produtoDAL.ConsultarTodos();
                }
                catch
                {
                    MessageBox.Show("Este produto não pode ser excluido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Método para filtrar na guia busca do from Produto
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //consultar com filtro (clicar duas vezes na textbox)
            produto.Descricao = txtFiltro.Text;
            dgvConsulta.DataSource = produtoDAL.ConsultaPorProduto(produto);
        }
        //método para abrir o formulario categoria
        private void button1_Click(object sender, EventArgs e)
        {
            Interface.frmCadCategoria categoria = new frmCadCategoria();
            categoria.ShowDialog();

            //exibir consulta de categoria na combobox
            cbCategoria.DataSource = categoriaDAL.ConsultarTodos();
            cbCategoria.DisplayMember = "CATEGORIAS";//o que será exibido
            cbCategoria.ValueMember = "CÓDIGO";//valor a ser pego do item selecionado
        }
        //Método PROVISORIO DE TESTE para buscar imagem e salvar 
        private void btnPegarImg_Click(object sender, EventArgs e)
        {
            try
            {

                //Cria um objeto OpenFileDialog
                OpenFileDialog openFile1 = new OpenFileDialog();
                //Ir ao diretorio
                openFile1.InitialDirectory = "C:\\Users\\";
                openFile1.FilterIndex = 1;
                openFile1.RestoreDirectory = true;
                // Inicializa o OpenFileDialog para procurar arquivos de imagem
                openFile1.Filter = "JPEG IMAGEM|*.jpg|BITMAP IMAGEM|*.bmp|GIF IMAGEM|*.gif|PNG IMAGEM|*.png";

                // Verifica se o usuário selecionou um arquivo a partir do OpenFileDialog

                if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    // Carrega o conteúdo do arquivo em um controle PictureBox.
                    imgProduto.Image = System.Drawing.Image.FromFile(openFile1.FileName);

                    Bitmap bmp = new Bitmap(openFile1.FileName);
                    Bitmap bmp2 = new Bitmap(bmp, imgProduto.Size);
                    imgProduto.Image = bmp2;
                    //Caminho do arquivo selecionado
                    lblCaminho.Text = openFile1.FileName;

                    /*
                   //salva imagem
                   SaveFileDialog salvaimagem = new SaveFileDialog();
                   //criar um direitorio
                   Directory.CreateDirectory(@"C:\\Users\\Yakamura\\Desktop\\CantinaEscolarMBLanches-Yakamura-4-2\\ImgProduto");

                   
                     
                    salvaimagem.Filter = "JPEG IMAGEM|*.jpg|BITMAP IMAGEM|*.bmp|GIF IMAGEM|*.gif|PNG Image|*.png";

                   if (salvaimagem.ShowDialog() == System.Windows.Forms.DialogResult.OK && salvaimagem.FileName.Length > 0)
                   {
                       //aqui mandamos salvar a figura que está selecionada no picturebox!

                       imgFoto.Image.Save(salvaimagem.FileName);
                       lblPictureName.Text = salvaimagem.FileName;
                   }
                     
                    */

                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Inserir imagem : " + erro);
            }
        }
        //Ação do botão sair do formulario Produto
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}