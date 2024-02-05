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
    public partial class frmRecuSenha : Form
    {
        Dados.UsuarioDAL usuarioDAL = new Dados.UsuarioDAL();
        Classe.Usuario usuarioBLL = new Classe.Usuario();

        //variavel validacao de login
        bool validacao = false;

        public frmRecuSenha()
        {
            InitializeComponent();
        }

        //Método para atualizar a Combox preencher com os dados da tabela usuario
        private void frmRecuSenha_Load(object sender, EventArgs e)
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

        private void btnRecuperar_Click_1(object sender, EventArgs e)
        {
            usuarioBLL.Usuario1 = cbUsuario.Text;
            usuarioBLL.Email = txtEmail.Text;
            usuarioBLL = usuarioDAL.Recuperar(usuarioBLL);

            List<string> anexo = new List<string>();
            Utilidades.SPERA.EnviarEmail("smtp.gmail.com", "tccsistematecsoft@gmail.com", "Sistematecsoft2016", usuarioBLL.Email, "", "", "Recuperação de Senha | TecSoft", "Olá, " + usuarioBLL.Usuario1 + "<br><br>" + "Você solicitou a recuperação da sua senha do sistema MBLanches<br><br>Senha: " + usuarioBLL.Senha, anexo, true, true);
            MessageBox.Show("Senha Enviada no e-mail com sucesso!", "E-mail Enviado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Ação do botão sair do formulario Recuperar senha
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
