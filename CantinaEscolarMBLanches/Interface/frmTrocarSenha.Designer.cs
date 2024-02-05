namespace CantinaEscolarMBLanches.Interface
{
    partial class frmTrocarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrocarSenha));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.txtConfiSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.imgLogin = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Controls.Add(this.txtSenhaAtual);
            this.pnlPrincipal.Controls.Add(this.lblSenhaAtual);
            this.pnlPrincipal.Controls.Add(this.txtConfiSenha);
            this.pnlPrincipal.Controls.Add(this.txtSenhaNova);
            this.pnlPrincipal.Controls.Add(this.imgLogin);
            this.pnlPrincipal.Controls.Add(this.btnCancelar);
            this.pnlPrincipal.Controls.Add(this.lblConfSenha);
            this.pnlPrincipal.Controls.Add(this.btnTrocar);
            this.pnlPrincipal.Controls.Add(this.lblNovaSenha);
            this.pnlPrincipal.Controls.Add(this.pnlTitulo);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(394, 175);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.BackColor = System.Drawing.Color.Moccasin;
            this.txtSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtSenhaAtual.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtSenhaAtual.Location = new System.Drawing.Point(231, 42);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '#';
            this.txtSenhaAtual.Size = new System.Drawing.Size(151, 23);
            this.txtSenhaAtual.TabIndex = 37;
            this.txtSenhaAtual.Enter += new System.EventHandler(this.txtSenhaAtual_Enter);
            this.txtSenhaAtual.Leave += new System.EventHandler(this.txtSenhaAtual_Leave);
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblSenhaAtual.Location = new System.Drawing.Point(136, 48);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(89, 17);
            this.lblSenhaAtual.TabIndex = 36;
            this.lblSenhaAtual.Text = "Senha Atual:";
            // 
            // txtConfiSenha
            // 
            this.txtConfiSenha.BackColor = System.Drawing.Color.Moccasin;
            this.txtConfiSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtConfiSenha.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtConfiSenha.Location = new System.Drawing.Point(231, 105);
            this.txtConfiSenha.Name = "txtConfiSenha";
            this.txtConfiSenha.PasswordChar = '#';
            this.txtConfiSenha.Size = new System.Drawing.Size(151, 23);
            this.txtConfiSenha.TabIndex = 35;
            this.txtConfiSenha.Enter += new System.EventHandler(this.txtConfiSenha_Enter);
            this.txtConfiSenha.Leave += new System.EventHandler(this.txtConfiSenha_Leave);
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.BackColor = System.Drawing.Color.Moccasin;
            this.txtSenhaNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtSenhaNova.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtSenhaNova.Location = new System.Drawing.Point(231, 74);
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.PasswordChar = '#';
            this.txtSenhaNova.Size = new System.Drawing.Size(151, 23);
            this.txtSenhaNova.TabIndex = 34;
            this.txtSenhaNova.Enter += new System.EventHandler(this.txtSenhaNova_Enter);
            this.txtSenhaNova.Leave += new System.EventHandler(this.txtSenhaNova_Leave);
            // 
            // imgLogin
            // 
            this.imgLogin.Image = ((System.Drawing.Image)(resources.GetObject("imgLogin.Image")));
            this.imgLogin.Location = new System.Drawing.Point(10, 44);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(120, 124);
            this.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogin.TabIndex = 33;
            this.imgLogin.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Chocolate;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(276, 143);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 25);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblConfSenha.Location = new System.Drawing.Point(135, 111);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(99, 17);
            this.lblConfSenha.TabIndex = 32;
            this.lblConfSenha.Text = "Confirmação:";
            // 
            // btnTrocar
            // 
            this.btnTrocar.BackColor = System.Drawing.Color.Chocolate;
            this.btnTrocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTrocar.ForeColor = System.Drawing.Color.White;
            this.btnTrocar.Location = new System.Drawing.Point(147, 143);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(123, 25);
            this.btnTrocar.TabIndex = 29;
            this.btnTrocar.Text = "Trocar";
            this.btnTrocar.UseVisualStyleBackColor = false;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblNovaSenha.Location = new System.Drawing.Point(136, 80);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(91, 17);
            this.lblNovaSenha.TabIndex = 31;
            this.lblNovaSenha.Text = "Nova Senha:";
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
            this.pnlTitulo.Size = new System.Drawing.Size(392, 32);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            this.pnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseMove);
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
            this.btnSair.Location = new System.Drawing.Point(360, 0);
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
            this.lblTitulo.Size = new System.Drawing.Size(109, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Troca de Senha";
            // 
            // frmTrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 175);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTrocarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troca de Senha";
            this.Load += new System.EventHandler(this.frmTrocarSenha_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.Button btnTrocar;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.PictureBox imgLogin;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.TextBox txtConfiSenha;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label lblSenhaAtual;

    }
}