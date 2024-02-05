namespace CantinaEscolarMBLanches.Interface
{
    partial class frmCadCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolMenuCursos = new System.Windows.Forms.ToolStrip();
            this.tabCurso = new System.Windows.Forms.TabControl();
            this.tabCursoPag1 = new System.Windows.Forms.TabPage();
            this.gpDados = new System.Windows.Forms.GroupBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.tabCursoPag2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lblBuscaCurso = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblnfo = new System.Windows.Forms.Label();
            this.imgLogoCurso = new System.Windows.Forms.PictureBox();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.toolMenuCursos.SuspendLayout();
            this.tabCurso.SuspendLayout();
            this.tabCursoPag1.SuspendLayout();
            this.gpDados.SuspendLayout();
            this.tabCursoPag2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // toolMenuCursos
            // 
            this.toolMenuCursos.BackColor = System.Drawing.Color.PeachPuff;
            this.toolMenuCursos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolMenuCursos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolMenuCursos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolMenuCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnSalvar,
            this.btnExcluir});
            this.toolMenuCursos.Location = new System.Drawing.Point(0, 270);
            this.toolMenuCursos.Name = "toolMenuCursos";
            this.toolMenuCursos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolMenuCursos.Size = new System.Drawing.Size(397, 55);
            this.toolMenuCursos.TabIndex = 14;
            // 
            // tabCurso
            // 
            this.tabCurso.Controls.Add(this.tabCursoPag1);
            this.tabCurso.Controls.Add(this.tabCursoPag2);
            this.tabCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCurso.Location = new System.Drawing.Point(0, 32);
            this.tabCurso.Name = "tabCurso";
            this.tabCurso.SelectedIndex = 0;
            this.tabCurso.Size = new System.Drawing.Size(397, 238);
            this.tabCurso.TabIndex = 17;
            // 
            // tabCursoPag1
            // 
            this.tabCursoPag1.BackColor = System.Drawing.Color.SandyBrown;
            this.tabCursoPag1.Controls.Add(this.gpDados);
            this.tabCursoPag1.Location = new System.Drawing.Point(4, 25);
            this.tabCursoPag1.Name = "tabCursoPag1";
            this.tabCursoPag1.Padding = new System.Windows.Forms.Padding(3);
            this.tabCursoPag1.Size = new System.Drawing.Size(389, 209);
            this.tabCursoPag1.TabIndex = 0;
            this.tabCursoPag1.Text = "Cadastro";
            // 
            // gpDados
            // 
            this.gpDados.Controls.Add(this.lblnfo);
            this.gpDados.Controls.Add(this.txtCurso);
            this.gpDados.Controls.Add(this.imgLogoCurso);
            this.gpDados.Controls.Add(this.lblCurso);
            this.gpDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDados.ForeColor = System.Drawing.Color.Snow;
            this.gpDados.Location = new System.Drawing.Point(8, 6);
            this.gpDados.Name = "gpDados";
            this.gpDados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gpDados.Size = new System.Drawing.Size(373, 197);
            this.gpDados.TabIndex = 10;
            this.gpDados.TabStop = false;
            this.gpDados.Text = "Dados";
            // 
            // txtCurso
            // 
            this.txtCurso.BackColor = System.Drawing.Color.Moccasin;
            this.txtCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.Location = new System.Drawing.Point(73, 97);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(294, 24);
            this.txtCurso.TabIndex = 0;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.Maroon;
            this.lblCurso.Location = new System.Drawing.Point(15, 102);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(52, 16);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso:";
            // 
            // tabCursoPag2
            // 
            this.tabCursoPag2.BackColor = System.Drawing.Color.SandyBrown;
            this.tabCursoPag2.Controls.Add(this.panel2);
            this.tabCursoPag2.Location = new System.Drawing.Point(4, 25);
            this.tabCursoPag2.Name = "tabCursoPag2";
            this.tabCursoPag2.Padding = new System.Windows.Forms.Padding(3);
            this.tabCursoPag2.Size = new System.Drawing.Size(389, 209);
            this.tabCursoPag2.TabIndex = 1;
            this.tabCursoPag2.Text = "Consulta";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Controls.Add(this.dgvConsulta);
            this.panel2.Controls.Add(this.lblBuscaCurso);
            this.panel2.Controls.Add(this.txtFiltro);
            this.panel2.Location = new System.Drawing.Point(7, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 200);
            this.panel2.TabIndex = 10;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(3, 177);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(320, 16);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "* Clique duas vezes na tabela para editar o cadastro";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(2, 26);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(371, 148);
            this.dgvConsulta.TabIndex = 2;
            this.dgvConsulta.DoubleClick += new System.EventHandler(this.dgvConsulta_DoubleClick);
            // 
            // lblBuscaCurso
            // 
            this.lblBuscaCurso.AutoSize = true;
            this.lblBuscaCurso.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBuscaCurso.Location = new System.Drawing.Point(4, 5);
            this.lblBuscaCurso.Name = "lblBuscaCurso";
            this.lblBuscaCurso.Size = new System.Drawing.Size(115, 16);
            this.lblBuscaCurso.TabIndex = 0;
            this.lblBuscaCurso.Text = "Buscar Por Curso:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.Moccasin;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(125, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(248, 22);
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
            this.pnlTitulo.Size = new System.Drawing.Size(397, 32);
            this.pnlTitulo.TabIndex = 18;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(2, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(130, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cadastro de Curso";
            // 
            // lblnfo
            // 
            this.lblnfo.AutoSize = true;
            this.lblnfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnfo.ForeColor = System.Drawing.Color.Maroon;
            this.lblnfo.Location = new System.Drawing.Point(12, 27);
            this.lblnfo.Name = "lblnfo";
            this.lblnfo.Size = new System.Drawing.Size(260, 33);
            this.lblnfo.TabIndex = 12;
            this.lblnfo.Text = "Cursos da Escola";
            // 
            // imgLogoCurso
            // 
            this.imgLogoCurso.Image = global::CantinaEscolarMBLanches.Properties.Resources.Cursos;
            this.imgLogoCurso.Location = new System.Drawing.Point(278, 13);
            this.imgLogoCurso.Name = "imgLogoCurso";
            this.imgLogoCurso.Size = new System.Drawing.Size(89, 69);
            this.imgLogoCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoCurso.TabIndex = 11;
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
            this.btnNovo.ToolTipText = "Novo Curso";
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
            this.btnSalvar.ToolTipText = "Salvar Curso";
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
            this.btnExcluir.ToolTipText = "Excluir Curso";
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
            this.btnSair.Location = new System.Drawing.Point(365, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 30);
            this.btnSair.TabIndex = 5;
            this.btnSair.TabStop = false;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCadCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(397, 325);
            this.Controls.Add(this.tabCurso);
            this.Controls.Add(this.toolMenuCursos);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cursos";
            this.Load += new System.EventHandler(this.frmCadCurso_Load);
            this.toolMenuCursos.ResumeLayout(false);
            this.toolMenuCursos.PerformLayout();
            this.tabCurso.ResumeLayout(false);
            this.tabCursoPag1.ResumeLayout(false);
            this.gpDados.ResumeLayout(false);
            this.gpDados.PerformLayout();
            this.tabCursoPag2.ResumeLayout(false);
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

        private System.Windows.Forms.ToolStrip toolMenuCursos;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.TabControl tabCurso;
        private System.Windows.Forms.TabPage tabCursoPag1;
        private System.Windows.Forms.GroupBox gpDados;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TabPage tabCursoPag2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblBuscaCurso;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgLogoCurso;
        private System.Windows.Forms.Label lblnfo;
    }
}