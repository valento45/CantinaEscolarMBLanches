using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantinaEscolarMBLanches.Properties;//precisa para referenciar imagem

namespace CantinaEscolarMBLanches
{
    public partial class frmMenu : Form
    {
        bool aberto = false;

        public frmMenu()
        {
            InitializeComponent();
        }

        
        //Menu principal: desativar a barra na inicialização, ativar somente ao passar o mouse pelo mesmo
        private void frmMenu_MouseEnter(object sender, EventArgs e)
        {

        }
        //Fazer logoff do sistema
        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Fazer Logoff e trocar usuário?", "Logoff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
                Interface.frmLogin login = new Interface.frmLogin();
                login.ShowDialog();
            }

        }

        //Abrir formulario Cadastrar Usuario
        private void menuCadUsuario_Click(object sender, EventArgs e)
        {
            Interface.frmUsuario usuario = new Interface.frmUsuario();
            usuario.ShowDialog();
        }
        //Abrir formulario Cadastrar Cliente
        private void menuCadCliente_Click(object sender, EventArgs e)
        {
            Interface.frmCadCliente cliente = new Interface.frmCadCliente();
            cliente.ShowDialog();
        }
        //Abrir formulario Cadastrar Categoria
        private void menuCadCategorias_Click(object sender, EventArgs e)
        {
            Interface.frmCadCategoria categoria = new Interface.frmCadCategoria();
            categoria.ShowDialog();
        }
        //Abrir formulario Cadastrar Curso
        private void menuCadCursos_Click(object sender, EventArgs e)
        {
            Interface.frmCadCurso curso = new Interface.frmCadCurso();
            curso.ShowDialog();
        }

        //Método para abrir a caixa do formulario produto
        private void menuCadProdutos_Click(object sender, EventArgs e)
        {
            Interface.frmCadProduto produto = new Interface.frmCadProduto();
            produto.ShowDialog();
        }

        //Abrir formulario Consultar Usuario
        private void MenuConUsuario_Click(object sender, EventArgs e)
        {
            Interface.frmConsultaUsuario ConsultarUsuario = new Interface.frmConsultaUsuario();
            ConsultarUsuario.ShowDialog();
        }
        //Abrir formulario Consultar Cliente
        private void MenuConClientes_Click(object sender, EventArgs e)
        {
            Interface.frmConsultaCliente ConsultaCliente = new Interface.frmConsultaCliente();
            ConsultaCliente.ShowDialog();
        }
        //Abrir formulario Consultar Produto
        private void MenuConProdutos_Click(object sender, EventArgs e)
        {
            Interface.frmConsultaProduto conProduto = new Interface.frmConsultaProduto();
            conProduto.ShowDialog();
        }
        //Abrir formulario Consultar Curso
        private void MenuConCursos_Click(object sender, EventArgs e)
        {
            Interface.frmConsultaCurso conCurso = new Interface.frmConsultaCurso();
            conCurso.ShowDialog();
        }
        //Abrir formulario Consultar Categoria
        private void MenuConCategoria_Click(object sender, EventArgs e)
        {
            Interface.frmConsultaCategoria conCategoria = new Interface.frmConsultaCategoria();
            conCategoria.ShowDialog();
        }

        //Coloca data e hora
        private void timeHora_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString();
            lblDatahora.Text = "Data / Hora: " + DateTime.Now.ToString();
        }

        //Sair do sistema
        private void menuFileSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Abrir formulario sobre 
        private void menuAjudaSobre_Click(object sender, EventArgs e)
        {
            Interface.frmSobre sobre = new Interface.frmSobre();
            sobre.ShowDialog();
        }
        //Fazer logoff pela interface da barra principal
        private void btnLogoff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Fazer Logoff e trocar usuário?", "Logoff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
                Interface.frmLogin login = new Interface.frmLogin();
                login.ShowDialog();
            }
        }
        //Sair do sistema pela interface da barra principal
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Método para abrir a tela de troca de senha
        private void menuToolTrocaSenha_Click(object sender, EventArgs e)
        {
            Interface.frmTrocarSenha TrocaSenha = new Interface.frmTrocarSenha();
            TrocaSenha.ShowDialog();
        }
        //Método para abrir a calculadora do sistema
        private void menuToolCalculadora_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("calc");
            }
            catch
            {
                MessageBox.Show("Não foi encontrado nenhuma calculadora", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Método para abrir o bloco de notas do sistema
        private void menuToolBlocoNotas_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad");
            }
            catch
            {
                MessageBox.Show("Não foi encontrado nenhum editor do Windows", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Método para abrir o MS Word do sistema
        private void menuToolOfficeWord_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("winword");
            }
            catch
            {
                MessageBox.Show("Não foi encontrado nenhum editor de texto do Office", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Método para abrir o MS Excel do sistema
        private void menuToolOfficeExcel_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("excel");
            }
            catch
            {
                MessageBox.Show("Não foi encontrado nenhum editor de planilhas do Office", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        //Método para abrir o navegador Google Chrome do sistema
        private void menuToolBrowserChrome_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("chrome", "www.google.com.br");
            }
            catch
            {
                MessageBox.Show("Não foi encontrado nenhum navegador Google Chrome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Método para abrir o navegador Internet Explore do sistema
        private void menuToolBrowserInternet_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("iexplore", "www.google.com.br");
            }
            catch
            {
                MessageBox.Show("Não foi encontrado nenhum navegador Internet Explore", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        //Método para abrir o navegador Mozilla Firefox do sistema
        private void menuToolBrowserFirefox_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("firefox", "www.google.com.br");
            }
            catch
            {
                MessageBox.Show("Não foi encontrado nenhum navegador Mozilla Firefox", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        //Método para abrir a caixa de mensagem do site
        private void menuAjudaVisitarSite_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("http://www.tecsoft.com.br");
            //MessageBox.Show("Site em Manutenção!", "TesSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Método para abrir o formulario Movimentação
        private void menuFinanMovimento_Click_1(object sender, EventArgs e)
        {
            Interface.frmEstoqueDinheiro Movimentacao = new Interface.frmEstoqueDinheiro();
            Movimentacao.ShowDialog();
        }

        //Método para abrir o formulario Backup
        private void menuToolBackupRestauracao_Click(object sender, EventArgs e)
        {
            Interface.frmBackupRestauracao BackupRestauracao = new Interface.frmBackupRestauracao();
            BackupRestauracao.ShowDialog();
        }

        //Método para abrir o formulario Movimentação do Saldo
        private void menuFinanMovimento_Click(object sender, EventArgs e)
        {
            Interface.frmEstoqueDinheiro EstoqueDinheiro = new Interface.frmEstoqueDinheiro();
            EstoqueDinheiro.ShowDialog();
        }
        //Método para abrir o formulario Configurar Banco
        private void menuToolConfBanco_Click(object sender, EventArgs e)
        {
            Interface.frmConfigurarBanco ConfigurarBanco = new Interface.frmConfigurarBanco();
            ConfigurarBanco.ShowDialog();
        }     

        //Método para abrir a tela PDV
        private void menuVendasPDV_Click(object sender, EventArgs e)
        {
            Interface.frmVendaPDV VendaPDV = new Interface.frmVendaPDV();
            VendaPDV.ShowDialog();
        }

        //Método do Formulario Principal
        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuário Logado: " + Interface.frmLogin.usuariologado;
        }
        //Ação do botão Minimizar do Menu Principal
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Ação para abrir o manual de ajuda do sistema
        private void menuAjudaComUsar_Click(object sender, EventArgs e)
        {
            //string caminho = AppDomain.CurrentDomain.BaseDirectory + "Ajuda\\KCSHelp.chm";
            //Help.ShowHelp(this, caminho);

            Help.ShowHelp(this, "help.pdf");
        }

        private void menuVendasAberturaFechamento_Click(object sender, EventArgs e)
        {
            Interface.frmCaixaAbertoFechado AbrirFecharCaixa = new Interface.frmCaixaAbertoFechado();
            AbrirFecharCaixa.ShowDialog();
        }

        //Método para bloquear fechamento pelo atalho do teclado
        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            //bloqueando opção de fechar com ALT + F4
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void menuRelClientes_Click(object sender, EventArgs e)
        {
            Interface.frmRelClientes RelClientes = new Interface.frmRelClientes();
            RelClientes.ShowDialog();
        }

        //Método para abrir e fechar a barra lateral
        private void timeBarra_Tick(object sender, EventArgs e)
        {
            if (aberto == true)
            {
                if (pnlBarra.Width >= 120)
                {
                    //pnlBarra.BackColor = Color.PeachPuff;
                    timeBarra.Stop();
                }
                else
                {
                    pnlBarra.Width = pnlBarra.Width + 10;
                }
            }
            else
            {
                if (pnlBarra.Width <= 15)
                {
                    //pnlBarra.BackColor = Color.Chocolate;
                    timeBarra.Stop();
                }
                else
                {
                    pnlBarra.Width = pnlBarra.Width - 10;
                }
            }
        }
        //Ação para desativar o movimento da barra lateral sem o mouse
        private void frmMenu_MouseEnter_1(object sender, EventArgs e)
        {
            aberto = false;
            timeBarra.Start();
        }
        //Ação para ativar o movimento da barra lateral com o mouse
        private void menuAtalhoBarra_MouseEnter(object sender, EventArgs e)
        {
            aberto = true;
            timeBarra.Start();
        }
        //Método para abrir a consulta de estoque
        private void menuEstoConsultar_Click(object sender, EventArgs e)
        {
            Interface.frmEstoque Estoque = new Interface.frmEstoque();
            Estoque.ShowDialog();
        }
        //Abrir formulario Consultar Vendas
        private void MenuConVendas_Click(object sender, EventArgs e)
        {
            Interface.frmConsultaVenda Vendas = new Interface.frmConsultaVenda();
            Vendas.ShowDialog();
        }
        //Método para abrir a calculadora do sistema
        private void toolCalculadora_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("calc");
            }
            catch
            {
                MessageBox.Show("Não foi encontrado nenhuma calculadora", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Sair do sistema
        private void toolSairSistema_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Método para abrir a tela de troca de senha
        private void toolTrocarSenha_Click(object sender, EventArgs e)
        {
            Interface.frmTrocarSenha TrocaSenha = new Interface.frmTrocarSenha();
            TrocaSenha.ShowDialog();
        }
        //Método para abrir o formulario Backup
        private void toolBackup_Click(object sender, EventArgs e)
        {
            Interface.frmBackupRestauracao BackupRestauracao = new Interface.frmBackupRestauracao();
            BackupRestauracao.ShowDialog();
        }
        //Fazer logoff do sistema
        private void toolLogoff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Fazer Logoff e trocar usuário?", "Logoff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
                Interface.frmLogin login = new Interface.frmLogin();
                login.ShowDialog();
            }
        }
        //Método para abrir o bloco de notas do sistema
        private void toolBlocoNotas_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad");
            }
            catch
            {
                MessageBox.Show("Não foi encontrado nenhum editor do Windows", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Ação para abrir o manual de ajuda do sistema
        private void toolAjuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm");
        }
        //Método para abrir a tela PDV
        private void tooVendaPDV_Click(object sender, EventArgs e)
        {
            Interface.frmVendaPDV VendaPDV = new Interface.frmVendaPDV();
            VendaPDV.ShowDialog();
        }
        //Método para abrir a consulta de estoque
        private void toolEstoque_Click(object sender, EventArgs e)
        {
            Interface.frmEstoque Estoque = new Interface.frmEstoque();
            Estoque.ShowDialog();
        }
        //Método para abrir a caixa do formulario produto
        private void toolProdutos_Click(object sender, EventArgs e)
        {
            Interface.frmCadProduto produto = new Interface.frmCadProduto();
            produto.ShowDialog();
        }
        //Abrir formulario Cadastro Geral
        private void toolCadastros_Click(object sender, EventArgs e)
        {
            Interface.frmCadastros CadastroGeral = new Interface.frmCadastros();
            CadastroGeral.ShowDialog();
        }
        //Abrir formulario Consulta Geral
        private void toolConsulta_Click(object sender, EventArgs e)
        {
            Interface.frmConsultas ConsultaGeral = new Interface.frmConsultas();
            ConsultaGeral.ShowDialog();
        }
    }
}