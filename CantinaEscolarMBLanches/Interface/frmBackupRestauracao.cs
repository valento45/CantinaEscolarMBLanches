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
    public partial class frmBackupRestauracao : Form
    {
        public frmBackupRestauracao()
        {
            InitializeComponent();
        }
        //Ação do botão sair do formulario Backup e Restauração
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Método para realização do backup
        private void btnBackup_Click(object sender, EventArgs e)
        {
            var server = new Microsoft.SqlServer.Management.Smo.Server(txtServidor.Text);
            var backup = new Microsoft.SqlServer.Management.Smo.Backup();
            backup.Database = txtBaseDados.Text;
            backup.Incremental = false;
            string nomeArquivoBackup = string.Format("{0}_{1:yyyyMMdd_HHmmss}.bak", txtBaseDados.Text, DateTime.Now);
            backup.Devices.AddDevice(nomeArquivoBackup, Microsoft.SqlServer.Management.Smo.DeviceType.File);
            backup.SqlBackup(server);
            MessageBox.Show(string.Format("Backup '{0}' concluído com sucesso.", nomeArquivoBackup), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Método para mostrar os backups realizados
        private void cbBackups_DropDown(object sender, EventArgs e)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(string.Format("Server={0};Database={1};Trusted_Connection=True;", txtServidor.Text, txtBaseDados.Text)))
            {
                connection.Open();

                using (var command = new System.Data.SqlClient.SqlCommand(
                    "SELECT physical_device_name FROM msdb.dbo.backupmediafamily " +
                    "INNER JOIN msdb.dbo.backupset ON msdb.dbo.backupmediafamily.media_set_id = msdb.dbo.backupset.media_set_id " +
                    "WHERE (msdb.dbo.backupset.database_name LIKE @DatabaseName)", connection))
                {
                    command.Parameters.AddWithValue("DatabaseName", txtBaseDados.Text);

                    using (var reader = command.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(reader);
                        table.Columns.Add("FriendlyName");
                        foreach (DataRow row in table.Rows)
                        {
                            row["FriendlyName"] = System.IO.Path.GetFileName(row["physical_device_name"].ToString());
                        }
                        if (cbBackups.DataSource != null && cbBackups.DataSource is DataTable)
                        {
                            var oldTable = ((DataTable)cbBackups.DataSource);
                            cbBackups.DataSource = null;
                            oldTable.Dispose();
                        }
                        cbBackups.DataSource = table;
                        cbBackups.DisplayMember = "FriendlyName";
                        cbBackups.ValueMember = "physical_device_name";
                    }
                }
            }
        }
        //Método para realização da restauração do sistema
        private void btnRestauracao_Click(object sender, EventArgs e)
        {
            var server = new Microsoft.SqlServer.Management.Smo.Server(txtServidor.Text);
            var restore = new Microsoft.SqlServer.Management.Smo.Restore();
            restore.Database = txtBaseDados.Text;
            restore.Devices.AddDevice(cbBackups.SelectedValue.ToString(), Microsoft.SqlServer.Management.Smo.DeviceType.File);
            server.KillAllProcesses(txtBaseDados.Text);
            restore.SqlRestore(server);
            MessageBox.Show(string.Format("Backup '{0}' restaurado com sucesso.", cbBackups.Text), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}