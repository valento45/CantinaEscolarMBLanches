namespace CantinaEscolarMBLanches.Interface
{
    partial class frmProgresso
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgresso));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.barProgresso = new System.Windows.Forms.ProgressBar();
            this.contador = new System.Windows.Forms.Timer(this.components);
            this.lblInfoDados = new System.Windows.Forms.Label();
            this.lblDireitosReservados = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTecSoft = new System.Windows.Forms.Label();
            this.lblDadosSistema = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            resources.ApplyResources(this.imgLogo, "imgLogo");
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.TabStop = false;
            // 
            // barProgresso
            // 
            resources.ApplyResources(this.barProgresso, "barProgresso");
            this.barProgresso.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.barProgresso.Name = "barProgresso";
            // 
            // contador
            // 
            this.contador.Enabled = true;
            this.contador.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblInfoDados
            // 
            resources.ApplyResources(this.lblInfoDados, "lblInfoDados");
            this.lblInfoDados.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoDados.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfoDados.Name = "lblInfoDados";
            // 
            // lblDireitosReservados
            // 
            resources.ApplyResources(this.lblDireitosReservados, "lblDireitosReservados");
            this.lblDireitosReservados.BackColor = System.Drawing.Color.Transparent;
            this.lblDireitosReservados.ForeColor = System.Drawing.Color.Brown;
            this.lblDireitosReservados.Name = "lblDireitosReservados";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.barProgresso);
            this.panel1.Controls.Add(this.lblTecSoft);
            this.panel1.Controls.Add(this.lblDadosSistema);
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Controls.Add(this.lblDireitosReservados);
            this.panel1.Controls.Add(this.lblInfoDados);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblTecSoft
            // 
            resources.ApplyResources(this.lblTecSoft, "lblTecSoft");
            this.lblTecSoft.BackColor = System.Drawing.Color.Transparent;
            this.lblTecSoft.ForeColor = System.Drawing.Color.Brown;
            this.lblTecSoft.Name = "lblTecSoft";
            // 
            // lblDadosSistema
            // 
            resources.ApplyResources(this.lblDadosSistema, "lblDadosSistema");
            this.lblDadosSistema.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosSistema.ForeColor = System.Drawing.Color.Brown;
            this.lblDadosSistema.Name = "lblDadosSistema";
            // 
            // frmProgresso
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProgresso";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.ProgressBar barProgresso;
        private System.Windows.Forms.Timer contador;
        private System.Windows.Forms.Label lblInfoDados;
        private System.Windows.Forms.Label lblDireitosReservados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDadosSistema;
        private System.Windows.Forms.Label lblTecSoft;

    }
}