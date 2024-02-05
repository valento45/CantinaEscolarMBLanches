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
    public partial class frmCaixaAbertoFechado : Form
    {
        public frmCaixaAbertoFechado()
        {
            InitializeComponent();
        }

        //Ação para cancelar o formulario abertura/fechamento de caixa
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Ação para fechar o formulario abertura/fechamento de caixa
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Coloca data e hora no formulario do caixa
        private void timeHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = "Data / Hora: " + DateTime.Now.ToString();
        }
    }
}
