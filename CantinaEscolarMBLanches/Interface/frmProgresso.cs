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
    public partial class frmProgresso : Form
    {
        public frmProgresso()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (barProgresso.Value < 100)
            {
                barProgresso.Value = barProgresso.Value + 4;
            }
            else
            {
                contador.Enabled = false; //Desativar o nosso timer
                Hide();
                Interface.frmLogin login = new Interface.frmLogin();
                login.Show();
            }
             */
            barProgresso.Value = barProgresso.Value + 4;
            if (this.barProgresso.Value == 10)
            {
                lblInfoDados.Text = "Lendo Módulos...";
            }
            else if (this.barProgresso.Value == 20)
            {
                lblInfoDados.Text = "Ativando Módulos...";
            }
            else if (this.barProgresso.Value == 40)
            {
                lblInfoDados.Text = "Iniciando Módulos...";
            }
            else if (this.barProgresso.Value == 60)
            {
                lblInfoDados.Text = "Carregando Módulos...";
            }
            else if (this.barProgresso.Value == 80)
            {
                lblInfoDados.Text = "Carregando Dados...";
            }
            else if (this.barProgresso.Value == 98)
            {
                lblInfoDados.Text = "Módulos Concluído.";
            }
            else if (this.barProgresso.Value == 100)
            {
                contador.Enabled = false;
                this.Visible = false;
                Interface.frmLogin login = new Interface.frmLogin();
                login.ShowDialog();
            }
        }
    }
}
