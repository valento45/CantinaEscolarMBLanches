namespace CantinaEscolarMBLanches.Interface
{
    partial class frmConsultas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnConCurso = new System.Windows.Forms.Button();
            this.btnConCategoria = new System.Windows.Forms.Button();
            this.btnConUsuario = new System.Windows.Forms.Button();
            this.btnConCliente = new System.Windows.Forms.Button();
            this.btnConVenda = new System.Windows.Forms.Button();
            this.btnConProduto = new System.Windows.Forms.Button();
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
            this.pnlTitulo.Size = new System.Drawing.Size(646, 32);
            this.pnlTitulo.TabIndex = 21;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(2, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(171, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Formulários de Consultas";
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
            this.btnSair.Location = new System.Drawing.Point(614, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 30);
            this.btnSair.TabIndex = 5;
            this.btnSair.TabStop = false;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Controls.Add(this.btnConProduto);
            this.pnlPrincipal.Controls.Add(this.btnConVenda);
            this.pnlPrincipal.Controls.Add(this.lblInfo);
            this.pnlPrincipal.Controls.Add(this.btnConCurso);
            this.pnlPrincipal.Controls.Add(this.btnConCategoria);
            this.pnlPrincipal.Controls.Add(this.btnConUsuario);
            this.pnlPrincipal.Controls.Add(this.btnConCliente);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 32);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(646, 456);
            this.pnlPrincipal.TabIndex = 23;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo.Location = new System.Drawing.Point(57, 23);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(507, 25);
            this.lblInfo.TabIndex = 26;
            this.lblInfo.Text = "Selecione Abaixo o Tipo de Consulta Desejada";
            // 
            // btnConCurso
            // 
            this.btnConCurso.BackColor = System.Drawing.Color.LightSalmon;
            this.btnConCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConCurso.ForeColor = System.Drawing.Color.Maroon;
            this.btnConCurso.Image = global::CantinaEscolarMBLanches.Properties.Resources.search;
            this.btnConCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConCurso.Location = new System.Drawing.Point(160, 386);
            this.btnConCurso.Name = "btnConCurso";
            this.btnConCurso.Size = new System.Drawing.Size(310, 58);
            this.btnConCurso.TabIndex = 25;
            this.btnConCurso.Text = "Consulta de Cursos";
            this.btnConCurso.UseVisualStyleBackColor = false;
            this.btnConCurso.Click += new System.EventHandler(this.btnConCurso_Click);
            // 
            // btnConCategoria
            // 
            this.btnConCategoria.BackColor = System.Drawing.Color.LightSalmon;
            this.btnConCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConCategoria.ForeColor = System.Drawing.Color.Maroon;
            this.btnConCategoria.Image = global::CantinaEscolarMBLanches.Properties.Resources.search;
            this.btnConCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConCategoria.Location = new System.Drawing.Point(160, 322);
            this.btnConCategoria.Name = "btnConCategoria";
            this.btnConCategoria.Size = new System.Drawing.Size(310, 58);
            this.btnConCategoria.TabIndex = 24;
            this.btnConCategoria.Text = "Consulta de Categoria";
            this.btnConCategoria.UseVisualStyleBackColor = false;
            this.btnConCategoria.Click += new System.EventHandler(this.btnConCategoria_Click);
            // 
            // btnConUsuario
            // 
            this.btnConUsuario.BackColor = System.Drawing.Color.LightSalmon;
            this.btnConUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConUsuario.ForeColor = System.Drawing.Color.Maroon;
            this.btnConUsuario.Image = global::CantinaEscolarMBLanches.Properties.Resources.search;
            this.btnConUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConUsuario.Location = new System.Drawing.Point(160, 258);
            this.btnConUsuario.Name = "btnConUsuario";
            this.btnConUsuario.Size = new System.Drawing.Size(310, 58);
            this.btnConUsuario.TabIndex = 22;
            this.btnConUsuario.Text = "Consulta de Usuários";
            this.btnConUsuario.UseVisualStyleBackColor = false;
            this.btnConUsuario.Click += new System.EventHandler(this.btnConUsuario_Click);
            // 
            // btnConCliente
            // 
            this.btnConCliente.BackColor = System.Drawing.Color.LightSalmon;
            this.btnConCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConCliente.ForeColor = System.Drawing.Color.Maroon;
            this.btnConCliente.Image = global::CantinaEscolarMBLanches.Properties.Resources.search;
            this.btnConCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConCliente.Location = new System.Drawing.Point(160, 194);
            this.btnConCliente.Name = "btnConCliente";
            this.btnConCliente.Size = new System.Drawing.Size(310, 58);
            this.btnConCliente.TabIndex = 21;
            this.btnConCliente.Text = "Consulta de Clientes";
            this.btnConCliente.UseVisualStyleBackColor = false;
            this.btnConCliente.Click += new System.EventHandler(this.btnConCliente_Click);
            // 
            // btnConVenda
            // 
            this.btnConVenda.BackColor = System.Drawing.Color.LightSalmon;
            this.btnConVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConVenda.ForeColor = System.Drawing.Color.Maroon;
            this.btnConVenda.Image = global::CantinaEscolarMBLanches.Properties.Resources.search;
            this.btnConVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConVenda.Location = new System.Drawing.Point(160, 130);
            this.btnConVenda.Name = "btnConVenda";
            this.btnConVenda.Size = new System.Drawing.Size(310, 58);
            this.btnConVenda.TabIndex = 27;
            this.btnConVenda.Text = "Consulta de Vendas";
            this.btnConVenda.UseVisualStyleBackColor = false;
            this.btnConVenda.Click += new System.EventHandler(this.btnConVenda_Click);
            // 
            // btnConProduto
            // 
            this.btnConProduto.BackColor = System.Drawing.Color.LightSalmon;
            this.btnConProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConProduto.ForeColor = System.Drawing.Color.Maroon;
            this.btnConProduto.Image = global::CantinaEscolarMBLanches.Properties.Resources.search;
            this.btnConProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConProduto.Location = new System.Drawing.Point(160, 66);
            this.btnConProduto.Name = "btnConProduto";
            this.btnConProduto.Size = new System.Drawing.Size(310, 58);
            this.btnConProduto.TabIndex = 28;
            this.btnConProduto.Text = "Consulta de Produtos";
            this.btnConProduto.UseVisualStyleBackColor = false;
            this.btnConProduto.Click += new System.EventHandler(this.btnConProduto_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 488);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultas";
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
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnConCurso;
        private System.Windows.Forms.Button btnConCategoria;
        private System.Windows.Forms.Button btnConUsuario;
        private System.Windows.Forms.Button btnConCliente;
        private System.Windows.Forms.Button btnConVenda;
        private System.Windows.Forms.Button btnConProduto;
    }
}