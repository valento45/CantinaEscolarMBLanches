using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CantinaEscolarMBLanches.Interface
{
    partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

  
        //Método do botão OK do formulario Sobre
        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
