namespace CantinaEscolarMBLanches.Interface
{
    partial class frmCadProduto
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
            this.tabProduto = new System.Windows.Forms.TabControl();
            this.tabProdutoPag1 = new System.Windows.Forms.TabPage();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.gpDados = new System.Windows.Forms.GroupBox();
            this.txtValidade = new System.Windows.Forms.DateTimePicker();
            this.txtPrecoBruto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnCadCategoria = new System.Windows.Forms.Button();
            this.btnPegarImg = new System.Windows.Forms.Button();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.imgProduto = new System.Windows.Forms.PictureBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txtAnotacoes = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tabProdutoPag2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lblBuscaProduto = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.toolMenuProduto = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabProduto.SuspendLayout();
            this.tabProdutoPag1.SuspendLayout();
            this.gpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).BeginInit();
            this.tabProdutoPag2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.toolMenuProduto.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProduto
            // 
            this.tabProduto.Controls.Add(this.tabProdutoPag1);
            this.tabProduto.Controls.Add(this.tabProdutoPag2);
            this.tabProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tabProduto.Location = new System.Drawing.Point(0, 32);
            this.tabProduto.Margin = new System.Windows.Forms.Padding(4);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.SelectedIndex = 0;
            this.tabProduto.Size = new System.Drawing.Size(686, 387);
            this.tabProduto.TabIndex = 8;
            // 
            // tabProdutoPag1
            // 
            this.tabProdutoPag1.BackColor = System.Drawing.Color.SandyBrown;
            this.tabProdutoPag1.Controls.Add(this.lblCaminho);
            this.tabProdutoPag1.Controls.Add(this.gpDados);
            this.tabProdutoPag1.Location = new System.Drawing.Point(4, 25);
            this.tabProdutoPag1.Margin = new System.Windows.Forms.Padding(4);
            this.tabProdutoPag1.Name = "tabProdutoPag1";
            this.tabProdutoPag1.Padding = new System.Windows.Forms.Padding(4);
            this.tabProdutoPag1.Size = new System.Drawing.Size(678, 358);
            this.tabProdutoPag1.TabIndex = 0;
            this.tabProdutoPag1.Text = "Cadastro";
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(13, 285);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(0, 16);
            this.lblCaminho.TabIndex = 11;
            // 
            // gpDados
            // 
            this.gpDados.Controls.Add(this.txtValidade);
            this.gpDados.Controls.Add(this.txtPrecoBruto);
            this.gpDados.Controls.Add(this.label1);
            this.gpDados.Controls.Add(this.txtCodigo);
            this.gpDados.Controls.Add(this.lblCodigo);
            this.gpDados.Controls.Add(this.btnCadCategoria);
            this.gpDados.Controls.Add(this.btnPegarImg);
            this.gpDados.Controls.Add(this.txtPrecoVenda);
            this.gpDados.Controls.Add(this.lblPrecoVenda);
            this.gpDados.Controls.Add(this.txtQuantidade);
            this.gpDados.Controls.Add(this.lblQtd);
            this.gpDados.Controls.Add(this.imgProduto);
            this.gpDados.Controls.Add(this.lblObservacoes);
            this.gpDados.Controls.Add(this.txtAnotacoes);
            this.gpDados.Controls.Add(this.cbCategoria);
            this.gpDados.Controls.Add(this.txtDescricao);
            this.gpDados.Controls.Add(this.lblDescricao);
            this.gpDados.Controls.Add(this.lblValidade);
            this.gpDados.Controls.Add(this.lblCategoria);
            this.gpDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDados.ForeColor = System.Drawing.Color.Snow;
            this.gpDados.Location = new System.Drawing.Point(8, 9);
            this.gpDados.Margin = new System.Windows.Forms.Padding(4);
            this.gpDados.Name = "gpDados";
            this.gpDados.Padding = new System.Windows.Forms.Padding(4);
            this.gpDados.Size = new System.Drawing.Size(666, 272);
            this.gpDados.TabIndex = 10;
            this.gpDados.TabStop = false;
            this.gpDados.Text = "Dados";
            // 
            // txtValidade
            // 
            this.txtValidade.CalendarMonthBackground = System.Drawing.Color.Moccasin;
            this.txtValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtValidade.Location = new System.Drawing.Point(390, 98);
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Size = new System.Drawing.Size(106, 22);
            this.txtValidade.TabIndex = 27;
            // 
            // txtPrecoBruto
            // 
            this.txtPrecoBruto.BackColor = System.Drawing.Color.Moccasin;
            this.txtPrecoBruto.Location = new System.Drawing.Point(239, 98);
            this.txtPrecoBruto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoBruto.Name = "txtPrecoBruto";
            this.txtPrecoBruto.Size = new System.Drawing.Size(59, 22);
            this.txtPrecoBruto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(236, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "R$ Bruto:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Moccasin;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(8, 49);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(70, 22);
            this.txtCodigo.TabIndex = 25;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCodigo.Location = new System.Drawing.Point(5, 29);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(55, 16);
            this.lblCodigo.TabIndex = 24;
            this.lblCodigo.Text = "Código:";
            // 
            // btnCadCategoria
            // 
            this.btnCadCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCadCategoria.Location = new System.Drawing.Point(148, 94);
            this.btnCadCategoria.Name = "btnCadCategoria";
            this.btnCadCategoria.Size = new System.Drawing.Size(24, 26);
            this.btnCadCategoria.TabIndex = 2;
            this.btnCadCategoria.Text = "+";
            this.btnCadCategoria.UseVisualStyleBackColor = true;
            this.btnCadCategoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPegarImg
            // 
            this.btnPegarImg.BackColor = System.Drawing.Color.Sienna;
            this.btnPegarImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPegarImg.Location = new System.Drawing.Point(503, 229);
            this.btnPegarImg.Name = "btnPegarImg";
            this.btnPegarImg.Size = new System.Drawing.Size(158, 34);
            this.btnPegarImg.TabIndex = 8;
            this.btnPegarImg.Text = "Buscar Imagem";
            this.btnPegarImg.UseVisualStyleBackColor = false;
            this.btnPegarImg.Click += new System.EventHandler(this.btnPegarImg_Click);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.BackColor = System.Drawing.Color.Moccasin;
            this.txtPrecoVenda.Location = new System.Drawing.Point(315, 98);
            this.txtPrecoVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(68, 22);
            this.txtPrecoVenda.TabIndex = 5;
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPrecoVenda.Location = new System.Drawing.Point(312, 79);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(71, 16);
            this.lblPrecoVenda.TabIndex = 20;
            this.lblPrecoVenda.Text = "R$ Venda:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.Moccasin;
            this.txtQuantidade.Location = new System.Drawing.Point(189, 97);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(35, 22);
            this.txtQuantidade.TabIndex = 3;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.ForeColor = System.Drawing.Color.DarkRed;
            this.lblQtd.Location = new System.Drawing.Point(185, 78);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(32, 16);
            this.lblQtd.TabIndex = 18;
            this.lblQtd.Text = "Qtd:";
            // 
            // imgProduto
            // 
            this.imgProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgProduto.Image = global::CantinaEscolarMBLanches.Properties.Resources.Produto_2;
            this.imgProduto.Location = new System.Drawing.Point(503, 29);
            this.imgProduto.Name = "imgProduto";
            this.imgProduto.Size = new System.Drawing.Size(158, 195);
            this.imgProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProduto.TabIndex = 16;
            this.imgProduto.TabStop = false;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.ForeColor = System.Drawing.Color.DarkRed;
            this.lblObservacoes.Location = new System.Drawing.Point(8, 124);
            this.lblObservacoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(76, 16);
            this.lblObservacoes.TabIndex = 9;
            this.lblObservacoes.Text = "Anotações:";
            // 
            // txtAnotacoes
            // 
            this.txtAnotacoes.BackColor = System.Drawing.Color.Moccasin;
            this.txtAnotacoes.Location = new System.Drawing.Point(8, 148);
            this.txtAnotacoes.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnotacoes.Multiline = true;
            this.txtAnotacoes.Name = "txtAnotacoes";
            this.txtAnotacoes.Size = new System.Drawing.Size(488, 115);
            this.txtAnotacoes.TabIndex = 7;
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.Moccasin;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Informática",
            "Administração",
            "Contabilidade",
            "Ensino Médio",
            "Comercio"});
            this.cbCategoria.Location = new System.Drawing.Point(8, 95);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(137, 24);
            this.cbCategoria.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.Moccasin;
            this.txtDescricao.Location = new System.Drawing.Point(92, 49);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(404, 22);
            this.txtDescricao.TabIndex = 0;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDescricao.Location = new System.Drawing.Point(93, 29);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(73, 16);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.ForeColor = System.Drawing.Color.DarkRed;
            this.lblValidade.Location = new System.Drawing.Point(394, 78);
            this.lblValidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(66, 16);
            this.lblValidade.TabIndex = 1;
            this.lblValidade.Text = "Validade:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCategoria.Location = new System.Drawing.Point(5, 75);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(70, 16);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria:";
            // 
            // tabProdutoPag2
            // 
            this.tabProdutoPag2.BackColor = System.Drawing.Color.SandyBrown;
            this.tabProdutoPag2.Controls.Add(this.panel2);
            this.tabProdutoPag2.Location = new System.Drawing.Point(4, 25);
            this.tabProdutoPag2.Margin = new System.Windows.Forms.Padding(4);
            this.tabProdutoPag2.Name = "tabProdutoPag2";
            this.tabProdutoPag2.Padding = new System.Windows.Forms.Padding(4);
            this.tabProdutoPag2.Size = new System.Drawing.Size(678, 358);
            this.tabProdutoPag2.TabIndex = 1;
            this.tabProdutoPag2.Text = "Consulta";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dgvConsulta);
            this.panel2.Controls.Add(this.lblBuscaProduto);
            this.panel2.Controls.Add(this.txtFiltro);
            this.panel2.Location = new System.Drawing.Point(5, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 297);
            this.panel2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 275);
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
            this.dgvConsulta.Size = new System.Drawing.Size(659, 245);
            this.dgvConsulta.TabIndex = 2;
            // 
            // lblBuscaProduto
            // 
            this.lblBuscaProduto.AutoSize = true;
            this.lblBuscaProduto.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBuscaProduto.Location = new System.Drawing.Point(3, 6);
            this.lblBuscaProduto.Name = "lblBuscaProduto";
            this.lblBuscaProduto.Size = new System.Drawing.Size(127, 16);
            this.lblBuscaProduto.TabIndex = 0;
            this.lblBuscaProduto.Text = "Buscar Por Produto:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.Moccasin;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(133, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(530, 22);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // toolMenuProduto
            // 
            this.toolMenuProduto.BackColor = System.Drawing.Color.SeaShell;
            this.toolMenuProduto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolMenuProduto.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolMenuProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolMenuProduto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnSalvar,
            this.btnExcluir});
            this.toolMenuProduto.Location = new System.Drawing.Point(0, 364);
            this.toolMenuProduto.Name = "toolMenuProduto";
            this.toolMenuProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolMenuProduto.Size = new System.Drawing.Size(686, 55);
            this.toolMenuProduto.TabIndex = 15;
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
            this.pnlTitulo.Size = new System.Drawing.Size(686, 32);
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
            this.btnSair.Location = new System.Drawing.Point(654, 0);
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
            this.lblTitulo.Size = new System.Drawing.Size(148, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cadastro de Produtos";
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 419);
            this.Controls.Add(this.toolMenuProduto);
            this.Controls.Add(this.tabProduto);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmCadProduto_Load);
            this.tabProduto.ResumeLayout(false);
            this.tabProdutoPag1.ResumeLayout(false);
            this.tabProdutoPag1.PerformLayout();
            this.gpDados.ResumeLayout(false);
            this.gpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).EndInit();
            this.tabProdutoPag2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.toolMenuProduto.ResumeLayout(false);
            this.toolMenuProduto.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabProduto;
        private System.Windows.Forms.TabPage tabProdutoPag1;
        private System.Windows.Forms.GroupBox gpDados;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.PictureBox imgProduto;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.TextBox txtAnotacoes;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TabPage tabProdutoPag2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblBuscaProduto;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ToolStrip toolMenuProduto;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnPegarImg;
        private System.Windows.Forms.Button btnCadCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtPrecoBruto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.DateTimePicker txtValidade;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
    }
}