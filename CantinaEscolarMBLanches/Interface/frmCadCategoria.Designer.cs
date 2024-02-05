namespace CantinaEscolarMBLanches.Interface
{
    partial class frmCadCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolMenuCategoria = new System.Windows.Forms.ToolStrip();
            this.tabCategoria = new System.Windows.Forms.TabControl();
            this.tabCategoriaPag1 = new System.Windows.Forms.TabPage();
            this.gpDados = new System.Windows.Forms.GroupBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tabUsuarioPag2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lblBuscaCategoria = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.imgLogoCurso = new System.Windows.Forms.PictureBox();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.toolMenuCategoria.SuspendLayout();
            this.tabCategoria.SuspendLayout();
            this.tabCategoriaPag1.SuspendLayout();
            this.gpDados.SuspendLayout();
            this.tabUsuarioPag2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // toolMenuCategoria
            // 
            this.toolMenuCategoria.BackColor = System.Drawing.Color.PeachPuff;
            this.toolMenuCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolMenuCategoria.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolMenuCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolMenuCategoria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnSalvar,
            this.btnExcluir});
            this.toolMenuCategoria.Location = new System.Drawing.Point(0, 270);
            this.toolMenuCategoria.Name = "toolMenuCategoria";
            this.toolMenuCategoria.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolMenuCategoria.Size = new System.Drawing.Size(444, 55);
            this.toolMenuCategoria.TabIndex = 15;
            // 
            // tabCategoria
            // 
            this.tabCategoria.Controls.Add(this.tabCategoriaPag1);
            this.tabCategoria.Controls.Add(this.tabUsuarioPag2);
            this.tabCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCategoria.Location = new System.Drawing.Point(0, 32);
            this.tabCategoria.Name = "tabCategoria";
            this.tabCategoria.SelectedIndex = 0;
            this.tabCategoria.Size = new System.Drawing.Size(444, 238);
            this.tabCategoria.TabIndex = 16;
            // 
            // tabCategoriaPag1
            // 
            this.tabCategoriaPag1.BackColor = System.Drawing.Color.SandyBrown;
            this.tabCategoriaPag1.Controls.Add(this.gpDados);
            this.tabCategoriaPag1.Location = new System.Drawing.Point(4, 25);
            this.tabCategoriaPag1.Name = "tabCategoriaPag1";
            this.tabCategoriaPag1.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategoriaPag1.Size = new System.Drawing.Size(436, 209);
            this.tabCategoriaPag1.TabIndex = 0;
            this.tabCategoriaPag1.Text = "Cadastro";
            // 
            // gpDados
            // 
            this.gpDados.Controls.Add(this.lblInfo);
            this.gpDados.Controls.Add(this.imgLogoCurso);
            this.gpDados.Controls.Add(this.txtCategoria);
            this.gpDados.Controls.Add(this.lblCategoria);
            this.gpDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDados.ForeColor = System.Drawing.Color.Snow;
            this.gpDados.Location = new System.Drawing.Point(7, 6);
            this.gpDados.Name = "gpDados";
            this.gpDados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gpDados.Size = new System.Drawing.Size(421, 197);
            this.gpDados.TabIndex = 10;
            this.gpDados.TabStop = false;
            this.gpDados.Text = "Dados";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.Moccasin;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCategoria.Location = new System.Drawing.Point(95, 102);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(320, 24);
            this.txtCategoria.TabIndex = 0;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCategoria.Location = new System.Drawing.Point(9, 107);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 16);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria:";
            // 
            // tabUsuarioPag2
            // 
            this.tabUsuarioPag2.BackColor = System.Drawing.Color.SandyBrown;
            this.tabUsuarioPag2.Controls.Add(this.panel2);
            this.tabUsuarioPag2.Location = new System.Drawing.Point(4, 25);
            this.tabUsuarioPag2.Name = "tabUsuarioPag2";
            this.tabUsuarioPag2.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarioPag2.Size = new System.Drawing.Size(436, 209);
            this.tabUsuarioPag2.TabIndex = 1;
            this.tabUsuarioPag2.Text = "Consulta";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dgvConsulta);
            this.panel2.Controls.Add(this.lblBuscaCategoria);
            this.panel2.Controls.Add(this.txtFiltro);
            this.panel2.Location = new System.Drawing.Point(8, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 197);
            this.panel2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "* Clique duas vezes na tabela para editar o cadastro";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(2, 26);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(415, 148);
            this.dgvConsulta.TabIndex = 2;
            this.dgvConsulta.DoubleClick += new System.EventHandler(this.dgvConsulta_DoubleClick);
            // 
            // lblBuscaCategoria
            // 
            this.lblBuscaCategoria.AutoSize = true;
            this.lblBuscaCategoria.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBuscaCategoria.Location = new System.Drawing.Point(4, 5);
            this.lblBuscaCategoria.Name = "lblBuscaCategoria";
            this.lblBuscaCategoria.Size = new System.Drawing.Size(139, 16);
            this.lblBuscaCategoria.TabIndex = 0;
            this.lblBuscaCategoria.Text = "Buscar Por Categoria:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.Moccasin;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(168, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(249, 22);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
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
            this.pnlTitulo.Size = new System.Drawing.Size(444, 32);
            this.pnlTitulo.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(2, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cadastro de Categoia";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo.Location = new System.Drawing.Point(6, 33);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(306, 31);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "Categoria de Produtos";
            // 
            // imgLogoCurso
            // 
            this.imgLogoCurso.Image = global::CantinaEscolarMBLanches.Properties.Resources.Categoria1;
            this.imgLogoCurso.Location = new System.Drawing.Point(326, 14);
            this.imgLogoCurso.Name = "imgLogoCurso";
            this.imgLogoCurso.Size = new System.Drawing.Size(89, 69);
            this.imgLogoCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoCurso.TabIndex = 13;
            this.imgLogoCurso.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = global::CantinaEscolarMBLanches.Properties.Resources.Novo_2;
            this.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(52, 52);
            this.btnNovo.Text = "Novo Registro";
            this.btnNovo.ToolTipText = "Nova Categoria";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = global::CantinaEscolarMBLanches.Properties.Resources.Salvar;
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(52, 52);
            this.btnSalvar.Text = "Salvar Registro";
            this.btnSalvar.ToolTipText = "Salvar Categoria";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::CantinaEscolarMBLanches.Properties.Resources.Excluir1;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(52, 52);
            this.btnExcluir.Text = "Excluir Registro";
            this.btnExcluir.ToolTipText = "Excluir Categoria";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnSair.Location = new System.Drawing.Point(412, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 30);
            this.btnSair.TabIndex = 5;
            this.btnSair.TabStop = false;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCadCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(444, 325);
            this.Controls.Add(this.tabCategoria);
            this.Controls.Add(this.toolMenuCategoria);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Categorias";
            this.Load += new System.EventHandler(this.frmCadCategoria_Load);
            this.toolMenuCategoria.ResumeLayout(false);
            this.toolMenuCategoria.PerformLayout();
            this.tabCategoria.ResumeLayout(false);
            this.tabCategoriaPag1.ResumeLayout(false);
            this.gpDados.ResumeLayout(false);
            this.gpDados.PerformLayout();
            this.tabUsuarioPag2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolMenuCategoria;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.TabControl tabCategoria;
        private System.Windows.Forms.TabPage tabCategoriaPag1;
        private System.Windows.Forms.GroupBox gpDados;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TabPage tabUsuarioPag2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblBuscaCategoria;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox imgLogoCurso;
    }
}