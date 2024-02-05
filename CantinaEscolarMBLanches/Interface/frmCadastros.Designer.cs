namespace CantinaEscolarMBLanches.Interface
{
    partial class frmCadastros
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCadCurso = new System.Windows.Forms.Button();
            this.btnCadCategoria = new System.Windows.Forms.Button();
            this.btnCadUsuario = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlTitulo.Size = new System.Drawing.Size(638, 32);
            this.pnlTitulo.TabIndex = 20;
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
            this.btnSair.Location = new System.Drawing.Point(606, 0);
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
            this.lblTitulo.Size = new System.Drawing.Size(174, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Formulários de Cadastros";
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCliente.ForeColor = System.Drawing.Color.Maroon;
            this.btnCadCliente.Image = global::CantinaEscolarMBLanches.Properties.Resources.imgCadCliente;
            this.btnCadCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadCliente.Location = new System.Drawing.Point(163, 131);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(310, 58);
            this.btnCadCliente.TabIndex = 21;
            this.btnCadCliente.Text = "Cadastro de Clientes";
            this.btnCadCliente.UseVisualStyleBackColor = false;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Controls.Add(this.lblInfo);
            this.pnlPrincipal.Controls.Add(this.btnCadCurso);
            this.pnlPrincipal.Controls.Add(this.btnCadCategoria);
            this.pnlPrincipal.Controls.Add(this.btnCadUsuario);
            this.pnlPrincipal.Controls.Add(this.btnCadCliente);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(638, 436);
            this.pnlPrincipal.TabIndex = 22;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo.Location = new System.Drawing.Point(57, 56);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(509, 25);
            this.lblInfo.TabIndex = 26;
            this.lblInfo.Text = "Selecione Abaixo o Tipo de Cadastro Desejado";
            // 
            // btnCadCurso
            // 
            this.btnCadCurso.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCadCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCurso.ForeColor = System.Drawing.Color.Maroon;
            this.btnCadCurso.Image = global::CantinaEscolarMBLanches.Properties.Resources.imgCadCliente;
            this.btnCadCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadCurso.Location = new System.Drawing.Point(163, 323);
            this.btnCadCurso.Name = "btnCadCurso";
            this.btnCadCurso.Size = new System.Drawing.Size(310, 58);
            this.btnCadCurso.TabIndex = 25;
            this.btnCadCurso.Text = "Cadastro de Cursos";
            this.btnCadCurso.UseVisualStyleBackColor = false;
            this.btnCadCurso.Click += new System.EventHandler(this.btnCadCurso_Click);
            // 
            // btnCadCategoria
            // 
            this.btnCadCategoria.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCadCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCategoria.ForeColor = System.Drawing.Color.Maroon;
            this.btnCadCategoria.Image = global::CantinaEscolarMBLanches.Properties.Resources.imgCadCliente;
            this.btnCadCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadCategoria.Location = new System.Drawing.Point(163, 259);
            this.btnCadCategoria.Name = "btnCadCategoria";
            this.btnCadCategoria.Size = new System.Drawing.Size(310, 58);
            this.btnCadCategoria.TabIndex = 24;
            this.btnCadCategoria.Text = "Cadastro de Categoria";
            this.btnCadCategoria.UseVisualStyleBackColor = false;
            this.btnCadCategoria.Click += new System.EventHandler(this.btnCadCategoria_Click);
            // 
            // btnCadUsuario
            // 
            this.btnCadUsuario.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCadUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadUsuario.ForeColor = System.Drawing.Color.Maroon;
            this.btnCadUsuario.Image = global::CantinaEscolarMBLanches.Properties.Resources.imgCadCliente;
            this.btnCadUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadUsuario.Location = new System.Drawing.Point(163, 195);
            this.btnCadUsuario.Name = "btnCadUsuario";
            this.btnCadUsuario.Size = new System.Drawing.Size(310, 58);
            this.btnCadUsuario.TabIndex = 22;
            this.btnCadUsuario.Text = "Cadastro de Usuários";
            this.btnCadUsuario.UseVisualStyleBackColor = false;
            this.btnCadUsuario.Click += new System.EventHandler(this.btnCadUsuario_Click);
            // 
            // frmCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 436);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastros";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnCadUsuario;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCadCurso;
        private System.Windows.Forms.Button btnCadCategoria;
    }
}