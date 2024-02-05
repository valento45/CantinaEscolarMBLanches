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
    public partial class frmCadCurso : Form
    {
        //referencia das classes de Curso
        Classe.Curso curso = new Classe.Curso();
        Dados.CursoDAL cursoDAL = new Dados.CursoDAL();

        //variavel controladora de alteração
        bool alterar = false;

        public frmCadCurso()
        {
            InitializeComponent();
        }

        public frmCadCurso(int idcurso)
        {
            InitializeComponent();

            curso.IDCurso = idcurso;//pegando o código da sala
            curso = cursoDAL.RetornarDados(curso);//chamando o método para preencher
            //preenchendo os campos do formulário
            txtCurso.Text = curso.Cursos;
            

            //mudando variável para saber que será uma alteração
            alterar = true;
        }

        //Método do botão salvar do from Curso
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCurso.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome da categoria!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                //enviando valores dos campos para a classe Curso
                curso.Cursos = txtCurso.Text;
                //executando o método da classe cursoDAL
                if (alterar == true)
                {
                    cursoDAL.Atualizar(curso);
                    //enviando mensagem de confirmação
                    MessageBox.Show("Dados Atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNovo.PerformClick();//chamando o clique do botão limpar
                    dgvConsulta.DataSource = cursoDAL.ConsultarPorCurso(curso);
                    Close();

                    return;
                }
                else
                {
                    cursoDAL.Cadastrar(curso);
                    //enviando mensagem de confirmação
                    MessageBox.Show("Dados Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNovo.PerformClick();//chamando o clique do botão limpar
                    dgvConsulta.DataSource = cursoDAL.ConsultarPorCurso(curso);
                }
            }
            catch
            {
                MessageBox.Show("Preencha corretamente o noem do curso!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //Método do botão novo do formulario curso
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCurso.Clear();
            txtCurso.Focus();
            alterar = false; //passa ser falso para o cadastro
            //direcionar para primeira aba
            tabCurso.SelectedTab = tabCursoPag1;
        }
        //Método para filtrar na guia busca do from curso
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //consultar com filtro (clicar duas vezes na textbox)
            curso.Cursos = txtFiltro.Text;
            dgvConsulta.DataSource = cursoDAL.ConsultarPorCurso(curso);
        }
        //Comando para carregar a tabela de usuarios no from Cursos
        private void frmCadCurso_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = cursoDAL.ConsultarTodos();
            txtCurso.Focus();
        }
        //Método do botão excluir do from Curso
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA REALMENTE EXCLUIR ESTE CURSO?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                curso.IDCurso = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value); //pegando o código que é exibido na tabela (datagridview)
                //executando o método excluir
                cursoDAL.Excluir(curso);
                MessageBox.Show("Dados excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //atualizar a consulta
                dgvConsulta.DataSource = cursoDAL.ConsultarTodos();
                }
                catch
                {
                   MessageBox.Show("Não é possivel excluir este curso, pois ele está cadatrado em um cliente", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Método para ao clicar no nome da busca, ativar a opção de editar os dados
        private void dgvConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgvConsulta.RowCount > 0)//tem linhas?
            {
                //direcionar para primeira aba
                tabCurso.SelectedTab = tabCursoPag1;

                //preenchendo os campos do formulário
                curso.IDCurso = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);//pegando o código da usuario
                curso = cursoDAL.RetornarDados(curso);//chamando o método para preencher
                //preenchendo os campos do formulário
                txtCurso.Text = curso.Cursos;
                //mudando variável para saber que será uma alteração
                alterar = true;
            }
        }
        //Ação do botão sair do formulario Curso
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
