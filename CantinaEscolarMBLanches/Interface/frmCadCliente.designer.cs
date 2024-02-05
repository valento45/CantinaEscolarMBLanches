namespace CantinaEscolarMBLanches.Interface
{
    partial class frmCadCliente
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
            this.tabCliente = new System.Windows.Forms.TabControl();
            this.tabClientePag1 = new System.Windows.Forms.TabPage();
            this.gpDados = new System.Windows.Forms.GroupBox();
            this.btnCadCurso = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.imgCliente = new System.Windows.Forms.PictureBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.tabClientePag2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lblBuscaNome = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.toolMenuUsuario = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabCliente.SuspendLayout();
            this.tabClientePag1.SuspendLayout();
            this.gpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliente)).BeginInit();
            this.tabClientePag2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.toolMenuUsuario.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.tabClientePag1);
            this.tabCliente.Controls.Add(this.tabClientePag2);
            this.tabCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCliente.Location = new System.Drawing.Point(0, 32);
            this.tabCliente.Margin = new System.Windows.Forms.Padding(4);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.SelectedIndex = 0;
            this.tabCliente.Size = new System.Drawing.Size(748, 388);
            this.tabCliente.TabIndex = 7;
            // 
            // tabClientePag1
            // 
            this.tabClientePag1.BackColor = System.Drawing.Color.SandyBrown;
            this.tabClientePag1.Controls.Add(this.gpDados);
            this.tabClientePag1.Location = new System.Drawing.Point(4, 25);
            this.tabClientePag1.Margin = new System.Windows.Forms.Padding(4);
            this.tabClientePag1.Name = "tabClientePag1";
            this.tabClientePag1.Padding = new System.Windows.Forms.Padding(4);
            this.tabClientePag1.Size = new System.Drawing.Size(740, 359);
            this.tabClientePag1.TabIndex = 0;
            this.tabClientePag1.Text = "Cadastro";
            // 
            // gpDados
            // 
            this.gpDados.Controls.Add(this.btnCadCurso);
            this.gpDados.Controls.Add(this.cbTipo);
            this.gpDados.Controls.Add(this.lblTipo);
            this.gpDados.Controls.Add(this.imgCliente);
            this.gpDados.Controls.Add(this.lblObservacoes);
            this.gpDados.Controls.Add(this.txtObservacoes);
            this.gpDados.Controls.Add(this.lblPeriodo);
            this.gpDados.Controls.Add(this.cbPeriodo);
            this.gpDados.Controls.Add(this.cbCurso);
            this.gpDados.Controls.Add(this.txtTelefone);
            this.gpDados.Controls.Add(this.txtNome);
            this.gpDados.Controls.Add(this.lblNome);
            this.gpDados.Controls.Add(this.lblTelefone);
            this.gpDados.Controls.Add(this.lblCurso);
            this.gpDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDados.ForeColor = System.Drawing.Color.Snow;
            this.gpDados.Location = new System.Drawing.Point(8, 10);
            this.gpDados.Margin = new System.Windows.Forms.Padding(4);
            this.gpDados.Name = "gpDados";
            this.gpDados.Padding = new System.Windows.Forms.Padding(4);
            this.gpDados.Size = new System.Drawing.Size(722, 272);
            this.gpDados.TabIndex = 10;
            this.gpDados.TabStop = false;
            this.gpDados.Text = "Dados";
            // 
            // btnCadCurso
            // 
            this.btnCadCurso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCadCurso.Location = new System.Drawing.Point(360, 77);
            this.btnCadCurso.Name = "btnCadCurso";
            this.btnCadCurso.Size = new System.Drawing.Size(24, 26);
            this.btnCadCurso.TabIndex = 19;
            this.btnCadCurso.Text = "+";
            this.btnCadCurso.UseVisualStyleBackColor = true;
            this.btnCadCurso.Click += new System.EventHandler(this.btnCadCurso_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.Color.Moccasin;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Aluno",
            "Professor",
            "Funcionário"});
            this.cbTipo.Location = new System.Drawing.Point(56, 78);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(109, 24);
            this.cbTipo.TabIndex = 17;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTipo.Location = new System.Drawing.Point(8, 86);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 16);
            this.lblTipo.TabIndex = 18;
            this.lblTipo.Text = "Tipo:";
            // 
            // imgCliente
            // 
            this.imgCliente.Image = global::CantinaEscolarMBLanches.Properties.Resources.Clientes;
            this.imgCliente.Location = new System.Drawing.Point(579, 12);
            this.imgCliente.Name = "imgCliente";
            this.imgCliente.Size = new System.Drawing.Size(130, 120);
            this.imgCliente.TabIndex = 16;
            this.imgCliente.TabStop = false;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.ForeColor = System.Drawing.Color.DarkRed;
            this.lblObservacoes.Location = new System.Drawing.Point(8, 118);
            this.lblObservacoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(93, 16);
            this.lblObservacoes.TabIndex = 9;
            this.lblObservacoes.Text = "Observações:";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.BackColor = System.Drawing.Color.Moccasin;
            this.txtObservacoes.Location = new System.Drawing.Point(8, 138);
            this.txtObservacoes.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(701, 124);
            this.txtObservacoes.TabIndex = 5;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPeriodo.Location = new System.Drawing.Point(388, 84);
            this.lblPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(59, 16);
            this.lblPeriodo.TabIndex = 8;
            this.lblPeriodo.Text = "Período:";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.BackColor = System.Drawing.Color.Moccasin;
            this.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Noite"});
            this.cbPeriodo.Location = new System.Drawing.Point(447, 78);
            this.cbPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(109, 24);
            this.cbPeriodo.TabIndex = 4;
            // 
            // cbCurso
            // 
            this.cbCurso.BackColor = System.Drawing.Color.Moccasin;
            this.cbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Items.AddRange(new object[] {
            "Informática",
            "Administração",
            "Contabilidade",
            "Ensino Médio",
            "Comercio"});
            this.cbCurso.Location = new System.Drawing.Point(218, 78);
            this.cbCurso.Margin = new System.Windows.Forms.Padding(4);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(141, 24);
            this.cbCurso.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.Moccasin;
            this.txtTelefone.Location = new System.Drawing.Point(447, 30);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Mask = "(##) ####-####";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(109, 22);
            this.txtTelefone.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Moccasin;
            this.txtNome.Location = new System.Drawing.Point(56, 30);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(328, 22);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNome.Location = new System.Drawing.Point(8, 34);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTelefone.Location = new System.Drawing.Point(382, 33);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(65, 16);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCurso.Location = new System.Drawing.Point(172, 84);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(46, 16);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso:";
            // 
            // tabClientePag2
            // 
            this.tabClientePag2.BackColor = System.Drawing.Color.SandyBrown;
            this.tabClientePag2.Controls.Add(this.panel2);
            this.tabClientePag2.Location = new System.Drawing.Point(4, 25);
            this.tabClientePag2.Margin = new System.Windows.Forms.Padding(4);
            this.tabClientePag2.Name = "tabClientePag2";
            this.tabClientePag2.Padding = new System.Windows.Forms.Padding(4);
            this.tabClientePag2.Size = new System.Drawing.Size(740, 359);
            this.tabClientePag2.TabIndex = 1;
            this.tabClientePag2.Text = "Consulta";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dgvConsulta);
            this.panel2.Controls.Add(this.lblBuscaNome);
            this.panel2.Controls.Add(this.txtFiltro);
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 279);
            this.panel2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 261);
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
            this.dgvConsulta.Location = new System.Drawing.Point(3, 27);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(718, 231);
            this.dgvConsulta.TabIndex = 2;
            this.dgvConsulta.DoubleClick += new System.EventHandler(this.dgvConsulta_DoubleClick);
            // 
            // lblBuscaNome
            // 
            this.lblBuscaNome.AutoSize = true;
            this.lblBuscaNome.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBuscaNome.Location = new System.Drawing.Point(3, 5);
            this.lblBuscaNome.Name = "lblBuscaNome";
            this.lblBuscaNome.Size = new System.Drawing.Size(117, 16);
            this.lblBuscaNome.TabIndex = 0;
            this.lblBuscaNome.Text = "Buscar Por Nome:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.Moccasin;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(126, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(595, 22);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged_1);
            // 
            // toolMenuUsuario
            // 
            this.toolMenuUsuario.BackColor = System.Drawing.Color.SeaShell;
            this.toolMenuUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolMenuUsuario.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolMenuUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolMenuUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnSalvar,
            this.btnExcluir});
            this.toolMenuUsuario.Location = new System.Drawing.Point(0, 365);
            this.toolMenuUsuario.Name = "toolMenuUsuario";
            this.toolMenuUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolMenuUsuario.Size = new System.Drawing.Size(748, 55);
            this.toolMenuUsuario.TabIndex = 14;
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
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.pnlTitulo.Size = new System.Drawing.Size(748, 32);
            this.pnlTitulo.TabIndex = 19;
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
            this.btnSair.Location = new System.Drawing.Point(716, 0);
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
            this.lblTitulo.Size = new System.Drawing.Size(145, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cadastro de Clientes";
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 420);
            this.Controls.Add(this.toolMenuUsuario);
            this.Controls.Add(this.tabCliente);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            this.tabCliente.ResumeLayout(false);
            this.tabClientePag1.ResumeLayout(false);
            this.gpDados.ResumeLayout(false);
            this.gpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliente)).EndInit();
            this.tabClientePag2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.toolMenuUsuario.ResumeLayout(false);
            this.toolMenuUsuario.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCliente;
        private System.Windows.Forms.TabPage tabClientePag1;
        private System.Windows.Forms.GroupBox gpDados;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TabPage tabClientePag2;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.ToolStrip toolMenuUsuario;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblBuscaNome;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.PictureBox imgCliente;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnCadCurso;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
    }
}