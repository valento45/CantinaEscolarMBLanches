namespace CantinaEscolarMBLanches.Interface
{
    partial class frmBackupRestauracao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbBackups = new System.Windows.Forms.ComboBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.lblBackupEfetuados = new System.Windows.Forms.Label();
            this.btnRestauracao = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.txtBaseDados = new System.Windows.Forms.TextBox();
            this.lblBaseDados = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imgBackupRestauracao = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackupRestauracao)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBackups
            // 
            this.cbBackups.AutoCompleteCustomSource.AddRange(new string[] {
            "Supervisor",
            "Roberta",
            "JulianoDias",
            "Victoria"});
            this.cbBackups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBackups.FormattingEnabled = true;
            this.cbBackups.Location = new System.Drawing.Point(179, 124);
            this.cbBackups.Name = "cbBackups";
            this.cbBackups.Size = new System.Drawing.Size(296, 21);
            this.cbBackups.TabIndex = 16;
            this.cbBackups.DropDown += new System.EventHandler(this.cbBackups_DropDown);
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(179, 61);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(130, 20);
            this.txtServidor.TabIndex = 18;
            this.txtServidor.Text = ".\\MSSQLEXPRESS";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServidor.ForeColor = System.Drawing.Color.Maroon;
            this.lblServidor.Location = new System.Drawing.Point(177, 43);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(64, 15);
            this.lblServidor.TabIndex = 17;
            this.lblServidor.Text = "Servidor:";
            // 
            // lblBackupEfetuados
            // 
            this.lblBackupEfetuados.AutoSize = true;
            this.lblBackupEfetuados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupEfetuados.ForeColor = System.Drawing.Color.Maroon;
            this.lblBackupEfetuados.Location = new System.Drawing.Point(179, 106);
            this.lblBackupEfetuados.Name = "lblBackupEfetuados";
            this.lblBackupEfetuados.Size = new System.Drawing.Size(133, 15);
            this.lblBackupEfetuados.TabIndex = 15;
            this.lblBackupEfetuados.Text = "Backups Efetuados:";
            // 
            // btnRestauracao
            // 
            this.btnRestauracao.BackColor = System.Drawing.Color.Chocolate;
            this.btnRestauracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestauracao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRestauracao.ForeColor = System.Drawing.Color.White;
            this.btnRestauracao.Location = new System.Drawing.Point(334, 162);
            this.btnRestauracao.Name = "btnRestauracao";
            this.btnRestauracao.Size = new System.Drawing.Size(141, 43);
            this.btnRestauracao.TabIndex = 32;
            this.btnRestauracao.Text = "Restauração";
            this.btnRestauracao.UseVisualStyleBackColor = false;
            this.btnRestauracao.Click += new System.EventHandler(this.btnRestauracao_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Chocolate;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(179, 162);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(149, 43);
            this.btnBackup.TabIndex = 31;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtBaseDados
            // 
            this.txtBaseDados.Location = new System.Drawing.Point(332, 61);
            this.txtBaseDados.Name = "txtBaseDados";
            this.txtBaseDados.Size = new System.Drawing.Size(143, 20);
            this.txtBaseDados.TabIndex = 34;
            this.txtBaseDados.Text = "CantinaEscolar";
            // 
            // lblBaseDados
            // 
            this.lblBaseDados.AutoSize = true;
            this.lblBaseDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseDados.ForeColor = System.Drawing.Color.Maroon;
            this.lblBaseDados.Location = new System.Drawing.Point(331, 43);
            this.lblBaseDados.Name = "lblBaseDados";
            this.lblBaseDados.Size = new System.Drawing.Size(108, 15);
            this.lblBaseDados.TabIndex = 33;
            this.lblBaseDados.Text = "Base de Dados:";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Chocolate;
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.btnSair);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(487, 32);
            this.pnlTitulo.TabIndex = 35;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Chocolate;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = global::CantinaEscolarMBLanches.Properties.Resources.Fechar;
            this.btnSair.Location = new System.Drawing.Point(455, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 30);
            this.btnSair.TabIndex = 5;
            this.btnSair.TabStop = false;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(2, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Backup e Restauração";
            // 
            // imgBackupRestauracao
            // 
            this.imgBackupRestauracao.Image = global::CantinaEscolarMBLanches.Properties.Resources.BackupRestauracao;
            this.imgBackupRestauracao.Location = new System.Drawing.Point(11, 43);
            this.imgBackupRestauracao.Name = "imgBackupRestauracao";
            this.imgBackupRestauracao.Size = new System.Drawing.Size(158, 162);
            this.imgBackupRestauracao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBackupRestauracao.TabIndex = 19;
            this.imgBackupRestauracao.TabStop = false;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(487, 217);
            this.pnlPrincipal.TabIndex = 36;
            // 
            // frmBackupRestauracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 217);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.txtBaseDados);
            this.Controls.Add(this.lblBaseDados);
            this.Controls.Add(this.btnRestauracao);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.imgBackupRestauracao);
            this.Controls.Add(this.cbBackups);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblServidor);
            this.Controls.Add(this.lblBackupEfetuados);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBackupRestauracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup e Restauração";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackupRestauracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBackups;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Label lblBackupEfetuados;
        private System.Windows.Forms.PictureBox imgBackupRestauracao;
        private System.Windows.Forms.Button btnRestauracao;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtBaseDados;
        private System.Windows.Forms.Label lblBaseDados;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlPrincipal;
    }
}