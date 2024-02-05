using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantinaEscolarMBLanches.Properties;

namespace CantinaEscolarMBLanches.Interface
{
    public partial class frmVendaPDV : Form
    {
        Classe.Usuario UsuarioBLL = new Classe.Usuario();
        Dados.UsuarioDAL UsuarioDAL = new Dados.UsuarioDAL();

        Classe.Cliente ClienteBLL = new Classe.Cliente();
        Dados.ClienteDAL ClienteDAL = new Dados.ClienteDAL();

        Classe.Produto ProdutoBLL = new Classe.Produto();
        Dados.ProdutoDAL ProdutoDAL = new Dados.ProdutoDAL();

        Classe.Item_Pedido ItemPedidoBLL = new Classe.Item_Pedido();
        Dados.ItemPedidoDAL ItemDAL = new Dados.ItemPedidoDAL();

        Classe.Venda_Pedido VendaPedidoBLL = new Classe.Venda_Pedido();
        Dados.VendaPedidoDAL VendaDAL = new Dados.VendaPedidoDAL();

        double total = 0;


        public frmVendaPDV()
        {
            InitializeComponent();
        }
        //Ação para fechar o formulario PDV
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmVendaPDV_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Interface.frmLogin.usuariologado;
        }
        //Método para abrir o formulario busca de cliente
        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            Interface.frmBusCliente BuscaCliente = new Interface.frmBusCliente();
            BuscaCliente.ShowDialog();

            if (BuscaCliente.IDCliente != 0)
            {
                ClienteBLL.IDCliente = BuscaCliente.IDCliente;
                ClienteBLL = ClienteDAL.RetornarDados(ClienteBLL);
                txtCliente.Text = ClienteBLL.Nome;
            }

        }

        //-----------------------------Criação dos métodos de utilização do sistema------------------------------


        //Método para calcular o total
        public void CalcularTotal()
        {
            total = 0;
            for (int i = 0; i < dgvItens.RowCount; i++)
            {
                total += Convert.ToDouble(dgvItens[4, i].Value);
            }
            txtTotal.Text = total.ToString("c");
        }

        //Método para verficar a quantidade disponivel no sistema do produto
        public bool VerificarQuantidadeDisponivel()
        {
            int qtd = 0;
            for (int i = 0; i < dgvItens.RowCount; i++)
            {
                if (ProdutoBLL.IDProduto.ToString() == dgvItens[0, i].Value.ToString())
                {
                    qtd += Convert.ToInt16(dgvItens[2, i].Value);
                }
            }
            qtd += Convert.ToInt16(txtQuantidade.Value);
            if (qtd > ProdutoBLL.Quantidade)
                return false;
            else
                return true;
        }

        //Método do botão remover pedido da lista de vendas
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvItens.RowCount > 0)
            {
                dgvItens.Rows.Remove(dgvItens.CurrentRow);
                CalcularTotal();
            }
        }

        //Método para adicionar o pedido na tabela
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ProdutoBLL.IDProduto != 0)
            {

                if (VerificarQuantidadeDisponivel() == false)
                {
                    MessageBox.Show("QUANTIDADE INSUFICIENTE NO ESTOQUE!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double total = Convert.ToInt16(txtQuantidade.Value) * ProdutoBLL.PrecoVenda;

                dgvItens.Rows.Add(ProdutoBLL.IDProduto, ProdutoBLL.Descricao, txtQuantidade.Value, ProdutoBLL.PrecoVenda.ToString("n"), total.ToString("n"));

                //calcular total
                CalcularTotal();

                //limpar
                ProdutoBLL.IDProduto = 0;
                txtProduto.Text = "";
                txtQuantidade.Value = 1;
                txtPreco.Text = "";

            }
            else
            {
                MessageBox.Show("SELECIONE UM PRODUTO", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Método para abrir o formulario busca de produto
        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            Interface.frmBusProduto Produto = new frmBusProduto();
            Produto.ShowDialog();


            if (Produto.IDProduto != 0)
            {
                ProdutoBLL.IDProduto = Produto.IDProduto;
                ProdutoBLL = ProdutoDAL.RetornarDados(ProdutoBLL);

                txtProduto.Text = ProdutoBLL.Descricao;
                txtPreco.ForeColor = System.Drawing.Color.Red;
                txtPreco.Text = ProdutoBLL.PrecoVenda.ToString("n");
                if (System.IO.File.Exists(ProdutoBLL.Imagem))
                    imgProduto.ImageLocation = ProdutoBLL.Imagem;
                else
                    imgProduto.ImageLocation = ProdutoBLL.Imagem;

                txtQuantidade.Select(0, txtQuantidade.Text.Length);//selecionando o texto para alteração
                txtQuantidade.Focus();//focando a caixa de quantidade
            }
        }

        //Método para finalizar venda
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvItens.RowCount > 0 && ClienteBLL.IDCliente != 0 && cmbForma.Text.Trim() != "")
            {
                //cadastrar venda
                VendaPedidoBLL.IDUsuario = Interface.frmLogin.idusuario;
                VendaPedidoBLL.IDCliente = ClienteBLL.IDCliente;
                VendaPedidoBLL.PrecoTotal = total;
                VendaPedidoBLL.Pagamento = cmbForma.Text;

                ItemPedidoBLL.IDVenda = VendaDAL.Cadastrar(VendaPedidoBLL);//cadastrando a venda e retornando os dados


                //cadastrar itens
                for (int i = 0; i < dgvItens.RowCount; i++)
                {
                    ItemPedidoBLL.IDProduto = Convert.ToInt16(dgvItens[0, i].Value);
                    ItemPedidoBLL.QuantPedido = Convert.ToInt16(dgvItens[2, i].Value);
                    ItemPedidoBLL.PrecoUnitario = Convert.ToDouble(dgvItens[3, i].Value);
                    ItemDAL.Cadastrar(ItemPedidoBLL);

                    //baixar estoque
                    ProdutoBLL.Quantidade = ItemPedidoBLL.QuantPedido;
                    ProdutoBLL.IDProduto = ItemPedidoBLL.IDProduto;
                    ProdutoDAL.BaixarEstoque(ProdutoBLL);
                }

                MessageBox.Show("VENDA REALIZADA COM SUCESSO!", "VENDA FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //LIMPANDO OS CAMPOS
                ProdutoBLL.IDProduto = 0;
                ClienteBLL.IDCliente = 0;
                txtProduto.Text = "";
                txtQuantidade.Value = 1;
                txtPreco.Text = "";
                txtTotal.Text = "";
                txtCliente.Text = "";
                cmbForma.Text = null;
                dgvItens.Rows.Clear();

            }
            else
            {
                MessageBox.Show("VERIFIQUE O PREENCHIMENTO DOS CAMPOS!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Método para sair do formulario de vendas
        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do modo PDV?", "Frente de Caixa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
        //Método para adicionar o atalho das telas de comando
        private void btnSair_KeyDown(object sender, KeyEventArgs e)
        {
            //caso pressionar o Enter irá adicionar
            if (e.KeyCode == Keys.Enter)
                btnAdicionar.PerformClick();//ativa clique do botão adicionar
            else if (e.KeyCode == Keys.F5)
                btnSelecionarCliente.PerformClick();
            else if (e.KeyCode == Keys.F6)
                btnSelecionarProduto.PerformClick();
            else if (e.KeyCode == Keys.F7)
                btnFinalizar.PerformClick();
            else if (e.KeyCode == Keys.F10)
                btnSair.PerformClick();
        }
        //Método para bloquear fechamento pelo atalho do teclado
        private void frmVendaPDV_KeyDown(object sender, KeyEventArgs e)
        {
            //bloqueando opção de fechar com ALT + F4
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}