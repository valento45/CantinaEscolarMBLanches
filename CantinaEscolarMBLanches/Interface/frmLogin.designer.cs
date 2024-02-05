namespace CantinaEscolarMBLanches.Interface
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.imgLogoSenha = new System.Windows.Forms.PictureBox();
            this.imgLogoUsuario = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.lblRecuSenha = new System.Windows.Forms.LinkLabel();
            this.imgLogin = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.toolDica = new System.Windows.Forms.ToolTip(this.components);
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(86, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(217, 26);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Acesso ao Sistema";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Maroon;
            this.lblUsuario.Location = new System.Drawing.Point(143, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Maroon;
            this.lblSenha.Location = new System.Drawing.Point(143, 51);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Moccasin;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Maroon;
            this.txtSenha.Location = new System.Drawing.Point(143, 66);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(174, 23);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.imgLogoSenha);
            this.pnlLogin.Controls.Add(this.imgLogoUsuario);
            this.pnlLogin.Controls.Add(this.btnCancelar);
            this.pnlLogin.Controls.Add(this.btnAcessar);
            this.pnlLogin.Controls.Add(this.cbUsuario);
            this.pnlLogin.Controls.Add(this.lblRecuSenha);
            this.pnlLogin.Controls.Add(this.lblUsuario);
            this.pnlLogin.Controls.Add(this.imgLogin);
            this.pnlLogin.Controls.Add(this.txtSenha);
            this.pnlLogin.Controls.Add(this.lblSenha);
            this.pnlLogin.ForeColor = System.Drawing.Color.Maroon;
            this.pnlLogin.Location = new System.Drawing.Point(12, 40);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(354, 153);
            this.pnlLogin.TabIndex = 8;
            // 
            // imgLogoSenha
            // 
            this.imgLogoSenha.Image = global::CantinaEscolarMBLanches.Properties.Resources.Cadeado1;
            this.imgLogoSenha.Location = new System.Drawing.Point(317, 65);
            this.imgLogoSenha.Name = "imgLogoSenha";
            this.imgLogoSenha.Size = new System.Drawing.Size(28, 24);
            this.imgLogoSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoSenha.TabIndex = 75;
            this.imgLogoSenha.TabStop = false;
            this.toolDica.SetToolTip(this.imgLogoSenha, "Digite sua Senha");
            // 
            // imgLogoUsuario
            // 
            this.imgLogoUsuario.Image = global::CantinaEscolarMBLanches.Properties.Resources.Usuario1;
            this.imgLogoUsuario.Location = new System.Drawing.Point(317, 24);
            this.imgLogoUsuario.Name = "imgLogoUsuario";
            this.imgLogoUsuario.Size = new System.Drawing.Size(28, 24);
            this.imgLogoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoUsuario.TabIndex = 74;
            this.imgLogoUsuario.TabStop = false;
            this.imgLogoUsuario.Tag = "";
            this.toolDica.SetToolTip(this.imgLogoUsuario, "Selecione seu Usuário");
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Image = global::CantinaEscolarMBLanches.Properties.Resources.Cancelar1;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(247, 110);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Tag = "";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAcessar.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.ForeColor = System.Drawing.Color.Maroon;
            this.btnAcessar.Image = global::CantinaEscolarMBLanches.Properties.Resources.Confirmar;
            this.btnAcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcessar.Location = new System.Drawing.Point(143, 110);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(92, 35);
            this.btnAcessar.TabIndex = 2;
            this.btnAcessar.Tag = "";
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cbUsuario
            // 
            this.cbUsuario.BackColor = System.Drawing.Color.Moccasin;
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Items.AddRange(new object[] {
            "Padrão",
            "Supervisor"});
            this.cbUsuario.Location = new System.Drawing.Point(143, 25);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(174, 21);
            this.cbUsuario.TabIndex = 0;
            this.cbUsuario.Enter += new System.EventHandler(this.cbUsuario_Enter);
            this.cbUsuario.Leave += new System.EventHandler(this.cbUsuario_Leave);
            // 
            // lblRecuSenha
            // 
            this.lblRecuSenha.AutoSize = true;
            this.lblRecuSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblRecuSenha.Location = new System.Drawing.Point(232, 91);
            this.lblRecuSenha.Name = "lblRecuSenha";
            this.lblRecuSenha.Size = new System.Drawing.Size(113, 13);
            this.lblRecuSenha.TabIndex = 4;
            this.lblRecuSenha.TabStop = true;
            this.lblRecuSenha.Text = "Esqueceu sua senha?";
            this.lblRecuSenha.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // imgLogin
            // 
            this.imgLogin.Image = global::CantinaEscolarMBLanches.Properties.Resources.Login;
            this.imgLogin.Location = new System.Drawing.Point(3, 9);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(134, 141);
            this.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogin.TabIndex = 7;
            this.imgLogin.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Maroon;
            this.lblLogin.Location = new System.Drawing.Point(11, 194);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(67, 15);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Deslogado";
            // 
            // toolDica
            // 
            this.toolDica.IsBalloon = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(378, 213);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login de Acesso - TecSoft";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox imgLogin;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.LinkLabel lblRecuSenha;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.PictureBox imgLogoSenha;
        private System.Windows.Forms.PictureBox imgLogoUsuario;
        private System.Windows.Forms.ToolTip toolDica;
    }
}