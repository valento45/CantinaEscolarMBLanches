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
    public partial class frmConfigurarBanco : Form
    {
        public frmConfigurarBanco()
        {
            InitializeComponent();
        }
        //Ação do botão sair do formulario Configurar Banco
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
