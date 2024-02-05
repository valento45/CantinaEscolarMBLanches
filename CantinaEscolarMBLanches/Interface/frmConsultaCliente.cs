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
    public partial class frmConsultaCliente : Form
    {
        Classe.Cliente cliente = new Classe.Cliente();
        Dados.ClienteDAL clienteDAL = new Dados.ClienteDAL();

        public frmConsultaCliente()
        {
            InitializeComponent();
        }
        //Carregar dados da tabela Cliente
        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            lblMsgFiltro.Visible = false;
            //Carregar a tabela de cliente da consulta no from usuario
            dgvConsultaCliente.DataSource = clienteDAL.ConsultarTodos();
            txtFiltro.Focus();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (rdbNome.Checked)
            {
                //consultar com filtro (clicar duas vezes na textbox)
                cliente.Nome = txtFiltro.Text;
                dgvConsultaCliente.DataSource = clienteDAL.ConsultaPorNome(cliente);
            }
            else if(rdbTipo.Checked) 
            {
                cliente.TipoCliente = txtFiltro.Text;
                dgvConsultaCliente.DataSource = clienteDAL.ConsultaPorTipo(cliente);
            }
            else
            {
                lblMsgFiltro.Visible = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //abrir formulário passando código como argumento
            //o código virá do datagridview (primeira coluna)
            frmCadCliente cadCliente = new frmCadCliente(Convert.ToInt16(dgvConsultaCliente.SelectedCells[0].Value));
            cadCliente.ShowDialog();
            //atualizar a consulta
            dgvConsultaCliente.DataSource = clienteDAL.ConsultarTodos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Interface.frmCadCliente cadCliente = new Interface.frmCadCliente();
            cadCliente.ShowDialog();

            //exibir consulta de categoria na combobox
            dgvConsultaCliente.DataSource = clienteDAL.ConsultarTodos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA REALMENTE EXCLUIR ESTE CLIENTE?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cliente.IDCliente = Convert.ToInt16(dgvConsultaCliente.SelectedCells[0].Value); //pegando o código que é exibido na tabela (datagridview)
                //executando o método excluir
                clienteDAL.Excluir(cliente);
                //atualizar a consulta
                dgvConsultaCliente.DataSource = clienteDAL.ConsultarTodos();
            }
        }
                     
    }
}
