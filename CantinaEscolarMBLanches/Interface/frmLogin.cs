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
    public partial class frmLogin : Form
    {
        Classe.Usuario usuario = new Classe.Usuario();
        Dados.UsuarioDAL usuarioDAL = new Dados.UsuarioDAL();

        //variavel validacao de login
        bool validacao = false;

        public static Boolean perfilusuario;
        public static string usuariologado;
        public static int idusuario;

        public frmLogin()
        {
            InitializeComponent();
        }
        //Método do botão sair do formulario Login
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do programa?", "MBLanches", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Método do botão Acessar do formulario Login
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (validacao == true)
            {
                //--------------Utilizado para logar sem login no banco de dados --------------------

                if (cbUsuario.Text.Trim() == "" || txtSenha.Text.Trim() == "")
                {
                    MessageBox.Show("Preencha todos os campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cbUsuario.Text == "Supervisor" && txtSenha.Text == "123456")
                {
                    lblLogin.Text = "logado!";
                    lblLogin.ForeColor = Color.Green;

                    frmMenu principal = new frmMenu();
                    principal.Show();
                    this.Visible = false;
                }
                else
                {
                    lblLogin.Text = "Login ou Senha Invalidos!!";
                    cbUsuario.Text = "";
                    txtSenha.Clear();

                }
            }
            else
            {
                //--------------Utilizar para logar com usuarios cadastrado no banco --------------------

                usuario.Usuario1 = cbUsuario.Text;
                usuario.Senha = txtSenha.Text;
                usuario = usuarioDAL.Logar(usuario);//executar método de verificação

                if (cbUsuario.Text.Trim() == "" || txtSenha.Text.Trim() == "")
                {
                    MessageBox.Show("Preencha todos os campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (usuario.IDUsuario == 0)
                {
                    lblLogin.Text = "Login ou Senha Invalidos!!";
                    cbUsuario.Text = "";
                    txtSenha.Clear();
                    cbUsuario.Focus();
                }
                else
                {
                    //conseguiu logar
                    perfilusuario = usuario.Perfil; //variavel poderá ser acesada a todos os outros forms
                    usuariologado = usuario.Usuario1;
                    idusuario = usuario.IDUsuario;

                    //Carrega tela Principal
                    frmMenu principal = new frmMenu();
                    principal.Show();
                    this.Visible = false;

                    lblLogin.Text = "logado!";
                    lblLogin.ForeColor = Color.Green;
                }
            }
        }
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Interface.frmRecuSenha achasenha = new Interface.frmRecuSenha();
            achasenha.Show();
        }
        //Método para atualizar a Combox preencher com os dados da tabela usuario
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                //exibir consulta de usuarios na combobox
                cbUsuario.DataSource = usuarioDAL.ConsultarTodos();
                cbUsuario.DisplayMember = "USUÁRIO";//o que será exibido
                cbUsuario.ValueMember = "CÓD";//valor a ser pego do item selecionado
            }
            catch
            {
                MessageBox.Show("Erro ao se conectar ao banco de dados!", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //variavel validacao de login
                validacao = true;
            }
        }


        //-------- Mudança de cores na Combox Usuario----------
        private void cbUsuario_Enter(object sender, EventArgs e)
        {
            cbUsuario.BackColor = Color.PeachPuff;
        }

        private void cbUsuario_Leave(object sender, EventArgs e)
        {
            cbUsuario.BackColor = Color.Moccasin;
        }

        //-------- Mudança de cores na TextBox Senha----------
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.PeachPuff;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.Moccasin;
        }

    }
}