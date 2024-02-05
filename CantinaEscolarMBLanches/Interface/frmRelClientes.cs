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
    public partial class frmRelClientes : Form
    {
        public frmRelClientes()
        {
            InitializeComponent();
        }

        private void frmRelClientes_Load(object sender, EventArgs e)
        {
            Dados.RelatorioDAL rDAL = new Dados.RelatorioDAL();
            //rDAL.RelatorioCliente().Fill(DSRelatorios.CLIENTE);
            this.reportVieClientes.RefreshReport();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
