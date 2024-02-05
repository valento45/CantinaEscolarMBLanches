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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }
        //Ação do botão fechar do formulario de consulta geral
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Abrir formulario Consultar Produto
        private void btnConProduto_Click(object sender, EventArgs e)
        {
            Interface.frmConsultaProduto conProduto = new Interface.frmConsultaProduto();
            conProduto.ShowDialog();
        }
        //Abrir formulario Consultar Vendas
        private void btnConVenda_Click(object sender, EventArgs e)
        {
            Interface.frmConsultaVenda Vendas = new Interface.frmConsultaVenda();
            Vendas.ShowDialog();
        }
        //Abrir formulario Consultar Usuario
        private void btnConUsuario_Click(object sender, EventArgs e)
        {
            Interface.frmConsultaUsuario ConsultarUsuario = new Interface.frmConsultaUsuario();
            ConsultarUsuario.ShowDialog();
        }
        //Abrir formulario Consultar Cliente
        private void btnConCliente_Click(object sender, EventArgs e)
        {
            Interface.frmConsultaCliente ConsultaCliente = new Interface.frmConsultaCliente();
            ConsultaCliente.ShowDialog();
        }
        //Abrir formulario Consultar Curso
        private void btnConCurso_Click(object sender, EventArgs e)
        {
            Interface.frmConsultaCurso conCurso = new Interface.frmConsultaCurso();
            conCurso.ShowDialog();
        }
        //Abrir formulario Consultar Categoria
        private void btnConCategoria_Click(object sender, EventArgs e)
        {
            Interface.frmConsultaCategoria conCategoria = new Interface.frmConsultaCategoria();
            conCategoria.ShowDialog();
        }
    }
}
