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
    public partial class frmBusCliente : Form
    {
        Classe.Cliente ClienteBLL = new Classe.Cliente();
        Dados.ClienteDAL ClienteDAL = new Dados.ClienteDAL();

        public int IDCliente { get; set; }

        public frmBusCliente()
        {
            InitializeComponent();
        }

        //Método para carregar os dados do cliente na tabela
        private void frmBusCliente_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = ClienteDAL.ConsultarTodos();   
        }

        //Método para efetuar a pesquisa pelo Cliente
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            ClienteBLL.Nome = txtFiltro.Text;
            dgvConsulta.DataSource = ClienteDAL.ConsultaPorNome(ClienteBLL);
        }
        //Método para selecionar o cliente
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0)//tem linhas?
            {
                IDCliente = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value.ToString());//código da primeira coluna do datagridview
                this.Close();
            }
        }
        //Método para ativar o atalho ao clicar no txt
        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            //caso clicar no botão Enter
            if (e.KeyCode == Keys.Enter)
            {
                btnSelecionar.PerformClick();//ativa o clique do botão selecionar
            }
        }
        //Ação do botão sair do formulario cliente
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Método para selecionar o cliente com o cliente na tabela
        private void dgvConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0)//tem linhas?
            {
                IDCliente = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value.ToString());//código da primeira coluna do datagridview
                this.Close();
            }
        }
        //Método para abrir o formulario de cadastro de cliente
        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            Interface.frmCadCliente cliente = new Interface.frmCadCliente();
            cliente.ShowDialog();

            //exibir atualização do cadastro diretamente na consulta de clientes
            dgvConsulta.DataSource = ClienteDAL.ConsultarTodos();
        }
    }
}
