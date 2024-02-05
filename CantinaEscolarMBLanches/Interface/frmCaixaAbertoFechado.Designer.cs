namespace CantinaEscolarMBLanches.Interface
{
    partial class frmCaixaAbertoFechado
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
            this.imgCaixa = new System.Windows.Forms.PictureBox();
            this.txtValorCaixa = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.rdmAbertura = new System.Windows.Forms.RadioButton();
            this.rdmFechamento = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCaixa)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.pnlTitulo.Size = new System.Drawing.Size(414, 32);
            this.pnlTitulo.TabIndex = 21;
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
            this.btnSair.Location = new System.Drawing.Point(382, 0);
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
            this.lblTitulo.Size = new System.Drawing.Size(225, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Abertura e Fechamento de Caixa";
            // 
            // imgCaixa
            // 
            this.imgCaixa.Image = global::CantinaEscolarMBLanches.Properties.Resources.Caixa;
            this.imgCaixa.Location = new System.Drawing.Point(12, 38);
            this.imgCaixa.Name = "imgCaixa";
            this.imgCaixa.Size = new System.Drawing.Size(128, 178);
            this.imgCaixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCaixa.TabIndex = 24;
            this.imgCaixa.TabStop = false;
            // 
            // txtValorCaixa
            // 
            this.txtValorCaixa.BackColor = System.Drawing.Color.Moccasin;
            this.txtValorCaixa.Location = new System.Drawing.Point(149, 107);
            this.txtValorCaixa.Name = "txtValorCaixa";
            this.txtValorCaixa.Size = new System.Drawing.Size(235, 20);
            this.txtValorCaixa.TabIndex = 23;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Maroon;
            this.lblValor.Location = new System.Drawing.Point(148, 82);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(120, 15);
            this.lblValor.TabIndex = 22;
            this.lblValor.Text = "Digite o Valor R$:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Chocolate;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(151, 191);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 25);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.Chocolate;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.Location = new System.Drawing.Point(261, 191);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(123, 25);
            this.btnInserir.TabIndex = 31;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            // 
            // rdmAbertura
            // 
            this.rdmAbertura.AutoSize = true;
            this.rdmAbertura.Location = new System.Drawing.Point(14, 19);
            this.rdmAbertura.Name = "rdmAbertura";
            this.rdmAbertura.Size = new System.Drawing.Size(65, 17);
            this.rdmAbertura.TabIndex = 33;
            this.rdmAbertura.TabStop = true;
            this.rdmAbertura.Text = "Abertura";
            this.rdmAbertura.UseVisualStyleBackColor = true;
            // 
            // rdmFechamento
            // 
            this.rdmFechamento.AutoSize = true;
            this.rdmFechamento.Location = new System.Drawing.Point(132, 19);
            this.rdmFechamento.Name = "rdmFechamento";
            this.rdmFechamento.Size = new System.Drawing.Size(84, 17);
            this.rdmFechamento.TabIndex = 34;
            this.rdmFechamento.TabStop = true;
            this.rdmFechamento.Text = "Fechamento";
            this.rdmFechamento.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdmFechamento);
            this.groupBox1.Controls.Add(this.rdmAbertura);
            this.groupBox1.Location = new System.Drawing.Point(151, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 42);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.ForeColor = System.Drawing.Color.Maroon;
            this.lblDataHora.Location = new System.Drawing.Point(146, 47);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(84, 15);
            this.lblDataHora.TabIndex = 36;
            this.lblDataHora.Text = "Data / Hora:";
            // 
            // frmCaixaAbertoFechado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 231);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.imgCaixa);
            this.Controls.Add(this.txtValorCaixa);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaixaAbertoFechado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura e Fechamento de Caixa";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCaixa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgCaixa;
        private System.Windows.Forms.TextBox txtValorCaixa;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.RadioButton rdmAbertura;
        private System.Windows.Forms.RadioButton rdmFechamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDataHora;
    }
}