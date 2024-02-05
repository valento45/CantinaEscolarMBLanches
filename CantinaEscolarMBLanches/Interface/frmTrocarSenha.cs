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
    public partial class frmTrocarSenha : Form
    {
        Classe.Usuario usuario = new Classe.Usuario();
        Dados.UsuarioDAL usuarioDAL = new Dados.UsuarioDAL();


        public frmTrocarSenha()
        {
            InitializeComponent();
        }

        //Ação do botão sair do formulário
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Ação do botão cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Ação do botão Fechar
        private void imgFechar_Click(object sender, EventArgs e)
        {
            Close();

        }

        //Método do formulario Trocar Senha
        private void frmTrocarSenha_Load(object sender, EventArgs e)
        {
            txtSenhaAtual.Focus();
            usuario.IDUsuario = frmLogin.idusuario;
            usuario = usuarioDAL.RetornarDados(usuario);//chamando o método para preencher

           
        }

        //Método do botão move e drow para mover os formmularios (MOVE = "Mover(e, true);" DOWN = "Mover(e, false);"
        public void Mover(MouseEventArgs e, bool move)
        {
            int X = 0;
            int Y = 0;

            if (move)
            {
                if (e.Button != MouseButtons.Left) return;
                this.Left = X + MousePosition.X;
                this.Top = Y + MousePosition.Y;
            }
            else
            {
                if (e.Button != MouseButtons.Left) return;
                X = this.Left - MousePosition.X;
                Y = this.Top - MousePosition.Y;
            }
        }


        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Mover(e, false);
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            Mover(e, true);
        }

        //Método do botão Trocar Senha do Formulario
        private void btnTrocar_Click(object sender, EventArgs e)
        {
            if (txtSenhaAtual.Text.Trim() == "" || txtSenhaNova.Text.Trim() == "" || txtConfiSenha.Text.Trim() == "")
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(txtSenhaAtual.Text.Trim() != usuario.Senha)
            {
                MessageBox.Show("Senha atual inválida!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            //Método para válidar a confirmação da senha se está correto com a nova senha digitada
            if (txtSenhaNova.Text.Trim() != txtConfiSenha.Text.Trim())
            {
                MessageBox.Show("As senhas não conferem", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            usuario.Senha = txtSenhaNova.Text;
            usuarioDAL.AtualizarSenha(usuario);
            MessageBox.Show("Senha Atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        //-------- Mudança de cores na TextBox Senha----------
        private void txtSenhaAtual_Enter(object sender, EventArgs e)
        {
            txtSenhaAtual.BackColor = Color.PeachPuff;
        }
        private void txtSenhaAtual_Leave(object sender, EventArgs e)
        {
            txtSenhaAtual.BackColor = Color.Moccasin;
        }

        private void txtSenhaNova_Enter(object sender, EventArgs e)
        {
            txtSenhaNova.BackColor = Color.PeachPuff;
        }

        private void txtSenhaNova_Leave(object sender, EventArgs e)
        {
            txtSenhaNova.BackColor = Color.Moccasin;
        }

        private void txtConfiSenha_Enter(object sender, EventArgs e)
        {
            txtConfiSenha.BackColor = Color.PeachPuff;
        }

        private void txtConfiSenha_Leave(object sender, EventArgs e)
        {
            txtConfiSenha.BackColor = Color.Moccasin;
        }
    }
}
