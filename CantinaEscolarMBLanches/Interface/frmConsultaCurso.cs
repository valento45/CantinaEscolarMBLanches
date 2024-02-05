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
    public partial class frmConsultaCurso : Form
    {
        Classe.Curso curso = new Classe.Curso();
        Dados.CursoDAL cursoDAL = new Dados.CursoDAL();
        public frmConsultaCurso()
        {
            InitializeComponent();
        }
        //Carregar dados da tabela curso
        private void frmConsultaCurso_Load(object sender, EventArgs e)
        {
            dgvConsultaCurso.DataSource = cursoDAL.ConsultarTodos();
            txtFiltro.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            curso.Cursos = txtFiltro.Text;
            dgvConsultaCurso.DataSource = cursoDAL.ConsultarPorCurso(curso);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Interface.frmCadCurso cadCurso = new Interface.frmCadCurso();
            cadCurso.ShowDialog();

            //exibir consulta de categoria na combobox
            dgvConsultaCurso.DataSource = cursoDAL.ConsultarTodos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA REALMENTE EXCLUIR ESTE CURSO?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                curso.IDCurso = Convert.ToInt16(dgvConsultaCurso.SelectedCells[0].Value); //pegando o código que é exibido na tabela (datagridview)
                //executando o método excluir
                cursoDAL.Excluir(curso);
                //atualizar a consulta
                dgvConsultaCurso.DataSource = cursoDAL.ConsultarTodos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //abrir formulário passando código como argumento
            //o código virá do datagridview (primeira coluna)
            frmCadCurso cadCurso = new frmCadCurso(Convert.ToInt16(dgvConsultaCurso.SelectedCells[0].Value));
            cadCurso.ShowDialog();
            //atualizar a consulta
            dgvConsultaCurso.DataSource = cursoDAL.ConsultarTodos();
        }
    }
}
