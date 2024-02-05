namespace CantinaEscolarMBLanches.Interface
{
    partial class frmUsuario
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
            this.tabUsuarioPag1 = new System.Windows.Forms.TabPage();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.gpAdministrativo = new System.Windows.Forms.GroupBox();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.gpDados = new System.Windows.Forms.GroupBox();
            this.imgValidaSenha = new System.Windows.Forms.PictureBox();
            this.imgValidaEmail = new System.Windows.Forms.PictureBox();
            this.lblValidaEmail = new System.Windows.Forms.Label();
            this.txtConfiSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tabUsuario = new System.Windows.Forms.TabControl();
            this.tabUsuarioPag2 = new System.Windows.Forms.TabPage();
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
            this.tabUsuarioPag1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            this.gpAdministrativo.SuspendLayout();
            this.gpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidaSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidaEmail)).BeginInit();
            this.tabUsuario.SuspendLayout();
            this.tabUsuarioPag2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.toolMenuUsuario.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUsuarioPag1
            // 
            this.tabUsuarioPag1.BackColor = System.Drawing.Color.SandyBrown;
            this.tabUsuarioPag1.Controls.Add(this.imgUsuario);
            this.tabUsuarioPag1.Controls.Add(this.gpAdministrativo);
            this.tabUsuarioPag1.Controls.Add(this.gpDados);
            this.tabUsuarioPag1.Location = new System.Drawing.Point(4, 25);
            this.tabUsuarioPag1.Name = "tabUsuarioPag1";
            this.tabUsuarioPag1.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarioPag1.Size = new System.Drawing.Size(430, 330);
            this.tabUsuarioPag1.TabIndex = 0;
            this.tabUsuarioPag1.Text = "Cadastro";
            // 
            // imgUsuario
            // 
            this.imgUsuario.Image = global::CantinaEscolarMBLanches.Properties.Resources.frmUsuario1;
            this.imgUsuario.Location = new System.Drawing.Point(302, 184);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(120, 85);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUsuario.TabIndex = 15;
            this.imgUsuario.TabStop = false;
            // 
            // gpAdministrativo
            // 
            this.gpAdministrativo.Controls.Add(this.cbSituacao);
            this.gpAdministrativo.Controls.Add(this.cbPerfil);
            this.gpAdministrativo.Controls.Add(this.lblSituacao);
            this.gpAdministrativo.Controls.Add(this.lblTipo);
            this.gpAdministrativo.ForeColor = System.Drawing.Color.Snow;
            this.gpAdministrativo.Location = new System.Drawing.Point(7, 184);
            this.gpAdministrativo.Name = "gpAdministrativo";
            this.gpAdministrativo.Size = new System.Drawing.Size(289, 85);
            this.gpAdministrativo.TabIndex = 14;
            this.gpAdministrativo.TabStop = false;
            this.gpAdministrativo.Text = "Administrativo";
            // 
            // cbSituacao
            // 
            this.cbSituacao.BackColor = System.Drawing.Color.Moccasin;
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Habilitado",
            "Desabilitado"});
            this.cbSituacao.Location = new System.Drawing.Point(97, 53);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(152, 24);
            this.cbSituacao.TabIndex = 6;
            // 
            // cbPerfil
            // 
            this.cbPerfil.BackColor = System.Drawing.Color.Moccasin;
            this.cbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Usuário Padrão"});
            this.cbPerfil.Location = new System.Drawing.Point(97, 24);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(152, 24);
            this.cbPerfil.TabIndex = 5;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSituacao.Location = new System.Drawing.Point(6, 59);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(72, 16);
            this.lblSituacao.TabIndex = 5;
            this.lblSituacao.Text = "* Situação:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTipo.Location = new System.Drawing.Point(6, 27);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(49, 16);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "* Perfil:";
            // 
            // gpDados
            // 
            this.gpDados.Controls.Add(this.imgValidaSenha);
            this.gpDados.Controls.Add(this.imgValidaEmail);
            this.gpDados.Controls.Add(this.lblValidaEmail);
            this.gpDados.Controls.Add(this.txtConfiSenha);
            this.gpDados.Controls.Add(this.lblConfirmaSenha);
            this.gpDados.Controls.Add(this.txtEmail);
            this.gpDados.Controls.Add(this.txtSenha);
            this.gpDados.Controls.Add(this.txtUsuario);
            this.gpDados.Controls.Add(this.txtNome);
            this.gpDados.Controls.Add(this.lblNome);
            this.gpDados.Controls.Add(this.lblUsuario);
            this.gpDados.Controls.Add(this.lblEmail);
            this.gpDados.Controls.Add(this.lblSenha);
            this.gpDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDados.ForeColor = System.Drawing.Color.Snow;
            this.gpDados.Location = new System.Drawing.Point(8, 6);
            this.gpDados.Name = "gpDados";
            this.gpDados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gpDados.Size = new System.Drawing.Size(414, 172);
            this.gpDados.TabIndex = 10;
            this.gpDados.TabStop = false;
            this.gpDados.Text = "Dados";
            // 
            // imgValidaSenha
            // 
            this.imgValidaSenha.Location = new System.Drawing.Point(379, 105);
            this.imgValidaSenha.Name = "imgValidaSenha";
            this.imgValidaSenha.Size = new System.Drawing.Size(21, 21);
            this.imgValidaSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgValidaSenha.TabIndex = 8;
            this.imgValidaSenha.TabStop = false;
            // 
            // imgValidaEmail
            // 
            this.imgValidaEmail.Location = new System.Drawing.Point(379, 132);
            this.imgValidaEmail.Name = "imgValidaEmail";
            this.imgValidaEmail.Size = new System.Drawing.Size(21, 21);
            this.imgValidaEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgValidaEmail.TabIndex = 7;
            this.imgValidaEmail.TabStop = false;
            // 
            // lblValidaEmail
            // 
            this.lblValidaEmail.AutoSize = true;
            this.lblValidaEmail.ForeColor = System.Drawing.Color.Snow;
            this.lblValidaEmail.Location = new System.Drawing.Point(382, 28);
            this.lblValidaEmail.Name = "lblValidaEmail";
            this.lblValidaEmail.Size = new System.Drawing.Size(0, 16);
            this.lblValidaEmail.TabIndex = 6;
            // 
            // txtConfiSenha
            // 
            this.txtConfiSenha.BackColor = System.Drawing.Color.Moccasin;
            this.txtConfiSenha.Location = new System.Drawing.Point(123, 104);
            this.txtConfiSenha.Name = "txtConfiSenha";
            this.txtConfiSenha.PasswordChar = '#';
            this.txtConfiSenha.Size = new System.Drawing.Size(253, 22);
            this.txtConfiSenha.TabIndex = 3;
            this.txtConfiSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConfiSenha_KeyUp);
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.ForeColor = System.Drawing.Color.DarkRed;
            this.lblConfirmaSenha.Location = new System.Drawing.Point(6, 109);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(114, 16);
            this.lblConfirmaSenha.TabIndex = 5;
            this.lblConfirmaSenha.Text = "* Confirma Senha:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Moccasin;
            this.txtEmail.Location = new System.Drawing.Point(123, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 22);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyUp);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Moccasin;
            this.txtSenha.Location = new System.Drawing.Point(123, 78);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '#';
            this.txtSenha.Size = new System.Drawing.Size(253, 22);
            this.txtSenha.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Moccasin;
            this.txtUsuario.Location = new System.Drawing.Point(123, 51);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(253, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Moccasin;
            this.txtNome.Location = new System.Drawing.Point(123, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(253, 22);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNome.Location = new System.Drawing.Point(6, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(117, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "* Nome Completo:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUsuario.Location = new System.Drawing.Point(6, 56);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(102, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "* Login Usuário:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEmail.Location = new System.Drawing.Point(6, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(107, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "* E-mail Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSenha.Location = new System.Drawing.Point(6, 84);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(108, 16);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "* Senha Usuário:";
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.tabUsuarioPag1);
            this.tabUsuario.Controls.Add(this.tabUsuarioPag2);
            this.tabUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUsuario.Location = new System.Drawing.Point(0, 32);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.SelectedIndex = 0;
            this.tabUsuario.Size = new System.Drawing.Size(438, 359);
            this.tabUsuario.TabIndex = 7;
            // 
            // tabUsuarioPag2
            // 
            this.tabUsuarioPag2.BackColor = System.Drawing.Color.SandyBrown;
            this.tabUsuarioPag2.Controls.Add(this.panel2);
            this.tabUsuarioPag2.Location = new System.Drawing.Point(4, 25);
            this.tabUsuarioPag2.Name = "tabUsuarioPag2";
            this.tabUsuarioPag2.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarioPag2.Size = new System.Drawing.Size(430, 330);
            this.tabUsuarioPag2.TabIndex = 1;
            this.tabUsuarioPag2.Text = "Consulta";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dgvConsulta);
            this.panel2.Controls.Add(this.lblBuscaNome);
            this.panel2.Controls.Add(this.txtFiltro);
            this.panel2.Location = new System.Drawing.Point(7, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 271);
            this.panel2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "* Clique duas vezes na tabela para editar o cadastro";
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
            this.dgvConsulta.Size = new System.Drawing.Size(410, 222);
            this.dgvConsulta.TabIndex = 2;
            this.dgvConsulta.DoubleClick += new System.EventHandler(this.dgvConsulta_DoubleClick);
            // 
            // lblBuscaNome
            // 
            this.lblBuscaNome.AutoSize = true;
            this.lblBuscaNome.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBuscaNome.Location = new System.Drawing.Point(4, 5);
            this.lblBuscaNome.Name = "lblBuscaNome";
            this.lblBuscaNome.Size = new System.Drawing.Size(117, 16);
            this.lblBuscaNome.TabIndex = 0;
            this.lblBuscaNome.Text = "Buscar Por Nome:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.Moccasin;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(122, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(290, 22);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
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
            this.toolMenuUsuario.Location = new System.Drawing.Point(0, 336);
            this.toolMenuUsuario.Name = "toolMenuUsuario";
            this.toolMenuUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolMenuUsuario.Size = new System.Drawing.Size(438, 55);
            this.toolMenuUsuario.TabIndex = 13;
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
            this.pnlTitulo.Size = new System.Drawing.Size(438, 32);
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
            this.btnSair.Location = new System.Drawing.Point(406, 0);
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
            this.lblTitulo.Size = new System.Drawing.Size(147, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cadastro de Usuários";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 391);
            this.Controls.Add(this.toolMenuUsuario);
            this.Controls.Add(this.tabUsuario);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.tabUsuarioPag1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            this.gpAdministrativo.ResumeLayout(false);
            this.gpAdministrativo.PerformLayout();
            this.gpDados.ResumeLayout(false);
            this.gpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidaSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgValidaEmail)).EndInit();
            this.tabUsuario.ResumeLayout(false);
            this.tabUsuarioPag2.ResumeLayout(false);
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

        private System.Windows.Forms.TabPage tabUsuarioPag1;
        private System.Windows.Forms.GroupBox gpDados;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TabControl tabUsuario;
        private System.Windows.Forms.TabPage tabUsuarioPag2;
        private System.Windows.Forms.GroupBox gpAdministrativo;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.ComboBox cbPerfil;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.ToolStrip toolMenuUsuario;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblBuscaNome;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.TextBox txtConfiSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.Label lblValidaEmail;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgValidaEmail;
        private System.Windows.Forms.PictureBox imgValidaSenha;
    }
}