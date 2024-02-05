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
    public partial class frmCadastros : Form
    {
        public frmCadastros()
        {
            InitializeComponent();
        }
        //Ação do botão fechar do formulario de cadastros geral
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Método para cadastro de cliente através do formulario Cadastro Geral
        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            Interface.frmCadCliente cliente = new Interface.frmCadCliente();
            cliente.ShowDialog();
        }
        //Método para cadastro de usuário através do formulario Cadastro Geral
        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            Interface.frmUsuario usuario = new Interface.frmUsuario();
            usuario.ShowDialog();
        }
        //Método para cadastro de categoria através do formulario Cadastro Geral
        private void btnCadCategoria_Click(object sender, EventArgs e)
        {
            Interface.frmCadCategoria categoria = new Interface.frmCadCategoria();
            categoria.ShowDialog();
        }
        //Método para cadastro de cursos através do formulario Cadastro Geral
        private void btnCadCurso_Click(object sender, EventArgs e)
        {
            Interface.frmCadCurso curso = new Interface.frmCadCurso();
            curso.ShowDialog();
        }
    }
}
