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
    public partial class frmCadCliente : Form
    {
        Classe.Cliente cliente = new Classe.Cliente();
        Dados.ClienteDAL clienteDAL = new Dados.ClienteDAL();
        Dados.CursoDAL cursoDAL = new Dados.CursoDAL();
        Classe.Curso curso = new Classe.Curso();

        //variavel controladora de alteração
        bool alterar = false;


        public frmCadCliente()
        {
            InitializeComponent();
        }

        public frmCadCliente(int idcliente)
        {
            InitializeComponent();

            cliente.IDCliente = idcliente;//pegando o código da sala
            cliente = clienteDAL.RetornarDados(cliente);//chamando o método para preencher
            //preenchendo os campos do formulário
            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone;
            cbTipo.Text = cliente.TipoCliente;
            cbCurso.Text = curso.Cursos;
            cbPeriodo.Text = cliente.Periodo;
            txtObservacoes.Text = cliente.Observacoes;

            //mudando variável para saber que será uma alteração
            alterar = true;

            
        }
        
        //Método do botão salvar do from Cliente
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "" || txtTelefone.Text.Trim() == "")
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (cbTipo.Text == "Aluno")
                {
                    cliente.Nome = txtNome.Text;
                    cliente.Telefone = txtTelefone.Text;
                    cliente.Observacoes = txtObservacoes.Text;
                    cliente.IDCurso = Convert.ToInt16(cbCurso.SelectedValue);//pegando a chave estrangeira
                    cliente.Periodo = cbPeriodo.Text;
                    cliente.TipoCliente = cbTipo.Text;

                    if (alterar == true)
                    {
                        clienteDAL.Atualizar(cliente);
                        //enviando mensagem de confirmação
                        MessageBox.Show("Dados atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNovo.PerformClick();//chamando o clique do botão limpar
                        dgvConsulta.DataSource = clienteDAL.ConsultaPorNome(cliente);
                        Close();

                        return;
                    }
                    else
                    {
                        clienteDAL.Cadastrar(cliente);
                        //enviando mensagem de confirmação
                        MessageBox.Show("Dados cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNovo.PerformClick();//chamando o clique do botão limpar
                        dgvConsulta.DataSource = clienteDAL.ConsultaPorNome(cliente);
                    }
                }
                else
                {
                    cliente.Nome = txtNome.Text;
                    cliente.Telefone = txtTelefone.Text;
                    cliente.Observacoes = txtObservacoes.Text;
                    cliente.TipoCliente = cbTipo.Text;

                    if (alterar == true)
                    {
                        clienteDAL.Atualizar(cliente);
                        //enviando mensagem de confirmação
                        MessageBox.Show("Dados atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNovo.PerformClick();//chamando o clique do botão limpar
                        dgvConsulta.DataSource = clienteDAL.ConsultaPorNome(cliente);
                    }
                    else
                    {
                        clienteDAL.Cadastrar(cliente);
                        //enviando mensagem de confirmação
                        MessageBox.Show("Dados cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNovo.PerformClick();//chamando o clique do botão limpar
                        dgvConsulta.DataSource = clienteDAL.ConsultaPorNome(cliente);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Preencha os campos corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Método para atualizar a Combox preencher com os dados da tabela curso
        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            //exibir consulta de cursos na combobox
            cbCurso.DataSource = cursoDAL.ConsultarTodos();
            cbCurso.DisplayMember = "NOME DO CURSO";//o que será exibido
            cbCurso.ValueMember = "CÓDIGO";//valor a ser pego do item selecionado

            

            //Carregar a tabela de cliente da consulta no from usuario
            dgvConsulta.DataSource = clienteDAL.ConsultarTodos();
            txtNome.Focus();

            //Desativa os combox (curso e periodo) na inicialização do from Cliente
            cbCurso.Enabled = false;
            cbPeriodo.Enabled = false;
            btnCadCurso.Enabled = false;

            //Limpa a caixa de Cursos
            cbCurso.Text = "";
            cbPeriodo.Text = "";
        }
        //Método do botão novo do From Cliente
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtObservacoes.Clear();
            txtTelefone.Clear();
            cbPeriodo.Text = null;
            cbCurso.Text = null;
            cbTipo.Text = null;
            alterar = false; //passa ser falso para o cadastro
            //direcionar para primeira aba
            tabCliente.SelectedTab = tabClientePag1;
            txtNome.Focus();
        }

        //Método para filtrar na guia busca do from cliente
        private void txtFiltro_TextChanged_1(object sender, EventArgs e)
        {
            //consultar com filtro (clicar duas vezes na textbox)
            cliente.Nome = txtFiltro.Text;
            dgvConsulta.DataSource = clienteDAL.ConsultaPorNome(cliente);
        }

        //Método do botão excluir do from Cliente
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA REALMENTE EXCLUIR ESTE CLIENTE?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                cliente.IDCliente = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value); //pegando o código que é exibido na tabela (datagridview)
                //executando o método excluir
                clienteDAL.Excluir(cliente);
                MessageBox.Show("Dados excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //atualizar a consulta
                dgvConsulta.DataSource = clienteDAL.ConsultarTodos();
                }
                catch
                {
                 MessageBox.Show("Não é possivel excluir este cliente", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Método para ao clicar no nome da busca, ativar a opção de editar os dados
        private void dgvConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0)//tem linhas?
            {
                //direcionar para primeira aba
                tabCliente.SelectedTab = tabClientePag1;

                //preenchendo os campos do formulário
                cliente.IDCliente = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);//pegando o código da usuario
                cliente = clienteDAL.RetornarDados(cliente);//chamando o método para preencher
                //preenchendo os campos do formulário
                txtNome.Text = cliente.Nome;
                txtTelefone.Text = cliente.Telefone;
                txtObservacoes.Text = cliente.Observacoes;
                cbCurso.Text = (cliente.IDCurso).ToString();
                cbPeriodo.Text = (cliente.Periodo).ToString();
                
                //mudando variável para saber que será uma alteração
                alterar = true;
            }
        }
        //Método para ativar os combobox (curso e periodo) se for selecionado a opção "Aluno"
        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.Text == "Aluno")
            {
                cbCurso.Enabled = true;
                cbPeriodo.Enabled = true;
                btnCadCurso.Enabled = true;
            }
            else
            {
                cbCurso.Enabled = false;
                cbPeriodo.Enabled = false;
                btnCadCurso.Enabled = false;
            }
        }
        //Método para abrir o formulario Cursos
        private void btnCadCurso_Click(object sender, EventArgs e)
        {
            Interface.frmCadCurso curso = new frmCadCurso();
            curso.ShowDialog();

            //exibir consulta de cursos na combobox
            cbCurso.DataSource = cursoDAL.ConsultarTodos();
            cbCurso.DisplayMember = "NOME DO CURSO";//o que será exibido
            cbCurso.ValueMember = "CÓDIGO";//valor a ser pego do item selecionado
        }
        //Ação do botão sair do formulario Cliente
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
