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
    public partial class frmConsultaUsuario : Form
    {
        Classe.Usuario usuario = new Classe.Usuario();
        Dados.UsuarioDAL usuarioDAL = new Dados.UsuarioDAL();

        public frmConsultaUsuario()
        {
            InitializeComponent();
        }
        //Carregar dados da tabela Usuario
        private void frmConsultaUsuario_Load(object sender, EventArgs e)
        {
            dgvConsultaUsuario.DataSource = usuarioDAL.ConsultarTodos();
            txtFiltro.Focus();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (rdbNome.Checked)
            {
                usuario.Nome = txtFiltro.Text;
                dgvConsultaUsuario.DataSource = usuarioDAL.ConsultaPorNome(usuario);
            }
            else
            {
                usuario.Usuario1 = txtFiltro.Text;
                dgvConsultaUsuario.DataSource = usuarioDAL.ConsultaPorUsuario(usuario);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Interface cadCliente = new Interface.frmCadCliente();
            //cadCliente.ShowDialog();

            //exibir consulta de categoria na combobox
            //dgvConsultaCliente.DataSource = clienteDAL.ConsultarTodos();
        }
    }
}
