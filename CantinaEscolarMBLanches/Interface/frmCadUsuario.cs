using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantinaEscolarMBLanches.Properties;//referencia para imagens

namespace CantinaEscolarMBLanches.Interface
{
    public partial class frmUsuario : Form
    {
        Classe.Usuario usuario = new Classe.Usuario();
        Dados.UsuarioDAL usuarioDAL = new Dados.UsuarioDAL();

        //variavel controladora de alteração
        bool alterar = false;

        public frmUsuario()
        {
            InitializeComponent();
        }
        //Comando para carregar a tabela de usuarios no from usuario
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = usuarioDAL.ConsultarTodos();
            txtNome.Focus();
        }
        //Botão Salvar do Formulario Usuario
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "" || txtNome.Text.Trim() == "" || txtSenha.Text.Trim() == "" || txtConfiSenha.Text.Trim() == "" || txtUsuario.Text.Trim() == "" || cbPerfil.Text.Trim() == "" || cbSituacao.Text.Trim() == "")
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSenha.Text.Trim() != txtConfiSenha.Text.Trim())
            {
                MessageBox.Show("As senhas não conferem", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            usuario.Nome = txtNome.Text;
            usuario.Usuario1 = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Email = txtEmail.Text;

            //--------------INICIO Dados para validação o IF de Administrador e usuario padrão------------

            if (cbSituacao.Text == "Habilitado") //If para boolean caso seja selecionado Habilitado, será true, ou seja, será ativo;
            {
                usuario.Situacao = true;
            }
            else
            {
                usuario.Situacao = false;
            }
            if (cbPerfil.Text == "Administrador") //If para boolean caso seja selecionado Supervisor, será true, ou seja, terá todos os privilegios;
            {
                usuario.Perfil = true;
            }
            else
            {
                usuario.Perfil = false;
            }
            //--------------FIM Dados para validação o IF de Administrador e usuario padrão------------

            if (alterar == true)
            {
                usuarioDAL.Atualizar(usuario);
                //enviando mensagem de confirmação
                MessageBox.Show("Dados Atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.PerformClick();//chamando o clique do botão limpar
                dgvConsulta.DataSource = usuarioDAL.ConsultaPorNome(usuario);
            }
            else
            {
                usuarioDAL.Cadastrar(usuario);
                //enviando mensagem de confirmação
                MessageBox.Show("Dados Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.PerformClick();//chamando o clique do botão limpar
                dgvConsulta.DataSource = usuarioDAL.ConsultaPorNome(usuario);
            }
        }
        //Botão novo do Formulario Usuario
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfiSenha.Clear();
            txtUsuario.Clear();
            cbPerfil.Text = null;
            cbSituacao.Text = null;
            imgValidaEmail.Image = null;
            imgValidaSenha.Image = null;
            alterar = false; //passa ser falso para o cadastro
            //direcionar para primeira aba
            tabUsuario.SelectedTab = tabUsuarioPag1;
            txtNome.Focus();

        }

        //Método do botão excluir do from usuario
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA REALMENTE EXCLUIR ESTE USUÁRIO?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    usuario.IDUsuario = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value); //pegando o código que é exibido na tabela (datagridview)
                    //executando o método excluir
                    usuarioDAL.Excluir(usuario);
                    MessageBox.Show("Dados Excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //atualizar a consulta
                    dgvConsulta.DataSource = usuarioDAL.ConsultarTodos();
                }
                catch
                {
                    MessageBox.Show("Não é possivel excluir este usuário", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        //Método para filtrar na guia busca do from usuario
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //consultar com filtro (clicar duas vezes na textbox)
            usuario.Nome = txtFiltro.Text;
            dgvConsulta.DataSource = usuarioDAL.ConsultaPorNome(usuario);
        }

        //Método para ao clicar no nome da busca, ativar a opção de editar os dados
        private void dgvConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0)//tem linhas?
            {
                //direcionar para primeira aba
                tabUsuario.SelectedTab = tabUsuarioPag1;

                //preenchendo os campos do formulário
                usuario.IDUsuario = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);//pegando o código da usuario
                usuario = usuarioDAL.RetornarDados(usuario);//chamando o método para preencher
                //preenchendo os campos do formulário
                txtNome.Text = usuario.Nome;
                txtUsuario.Text = usuario.Usuario1;
                txtSenha.Text = usuario.Senha;
                txtEmail.Text = usuario.Email;

                //Mudar o comando true/false para texto
                if (usuario.Perfil == true)
                {
                    cbPerfil.Text = "Administrador";
                }
                else
                {
                    cbPerfil.Text = "Usuário Padrão";
                }

                if (usuario.Situacao == true)
                {
                    cbSituacao.Text = "Habilitado";
                }
                else
                {
                    cbSituacao.Text = "Desabilitado";
                }

                //mudando variável para saber que será uma alteração
                alterar = true;
            }
        }
        //Método para assim que digitar o email validar se válido ou inválido
        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (Utilidades.SPERA.ValidarEmail(txtEmail.Text))
            {
                imgValidaEmail.Image = Resources.OK;
            }
            else
            {
                imgValidaEmail.Image = Resources.NOK;
            }
        }

        private void txtConfiSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSenha.Text.Trim() != txtConfiSenha.Text.Trim())
            {
                imgValidaSenha.Image = Resources.NOK;
            }
            else
            {
                imgValidaSenha.Image = Resources.OK;
            }
        }
        //Ação do botão sair do formulario Cadasatro de Usuario
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}