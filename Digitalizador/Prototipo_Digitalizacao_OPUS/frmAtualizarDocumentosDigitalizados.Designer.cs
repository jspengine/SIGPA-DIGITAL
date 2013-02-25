namespace DigitalView
{
    partial class frmAtualizarDocumentosDigitalizados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtualizarDocumentosDigitalizados));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabManutencao = new System.Windows.Forms.TabControl();
            this.tabProcessos = new System.Windows.Forms.TabPage();
            this.grpAcao = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnExcluirDocumentos = new System.Windows.Forms.Button();
            this.btnDigitalizar = new System.Windows.Forms.Button();
            this.lblCNPJCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpDocumentos = new System.Windows.Forms.GroupBox();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPathDiretorio = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblCPForCNPJ = new System.Windows.Forms.Label();
            this.tabDadosCadastrais = new System.Windows.Forms.TabPage();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboDocumentoDadosCadastrais = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVisualizarDocumentosCadastrais = new System.Windows.Forms.Button();
            this.btnExcluirDocumentosCadastrais = new System.Windows.Forms.Button();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstDocumentosDigitalisados = new System.Windows.Forms.ListView();
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNomeArquivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tabManutencao.SuspendLayout();
            this.tabProcessos.SuspendLayout();
            this.grpAcao.SuspendLayout();
            this.grpDocumentos.SuspendLayout();
            this.tabDadosCadastrais.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 725);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.tabManutencao);
            this.pnlMain.Controls.Add(this.lstDocumentosDigitalisados);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(5, 57);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(987, 663);
            this.pnlMain.TabIndex = 8;
            // 
            // tabManutencao
            // 
            this.tabManutencao.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabManutencao.Controls.Add(this.tabProcessos);
            this.tabManutencao.Controls.Add(this.tabDadosCadastrais);
            this.tabManutencao.Location = new System.Drawing.Point(7, 3);
            this.tabManutencao.Name = "tabManutencao";
            this.tabManutencao.SelectedIndex = 0;
            this.tabManutencao.Size = new System.Drawing.Size(977, 434);
            this.tabManutencao.TabIndex = 18;
            this.tabManutencao.SelectedIndexChanged += new System.EventHandler(this.tabManutencao_SelectedIndexChanged);
            // 
            // tabProcessos
            // 
            this.tabProcessos.BackColor = System.Drawing.Color.Transparent;
            this.tabProcessos.BackgroundImage = global::DigitalView.Properties.Resources.background_main;
            this.tabProcessos.Controls.Add(this.grpAcao);
            this.tabProcessos.Controls.Add(this.lblCNPJCPF);
            this.tabProcessos.Controls.Add(this.lblNome);
            this.tabProcessos.Controls.Add(this.label4);
            this.tabProcessos.Controls.Add(this.label11);
            this.tabProcessos.Controls.Add(this.grpDocumentos);
            this.tabProcessos.Controls.Add(this.label1);
            this.tabProcessos.Controls.Add(this.lblNomeCliente);
            this.tabProcessos.Controls.Add(this.txtReferencia);
            this.tabProcessos.Controls.Add(this.lblCPForCNPJ);
            this.tabProcessos.Location = new System.Drawing.Point(4, 25);
            this.tabProcessos.Name = "tabProcessos";
            this.tabProcessos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcessos.Size = new System.Drawing.Size(969, 405);
            this.tabProcessos.TabIndex = 0;
            this.tabProcessos.Text = "Processos";
            // 
            // grpAcao
            // 
            this.grpAcao.Controls.Add(this.btnSair);
            this.grpAcao.Controls.Add(this.btnVisualizar);
            this.grpAcao.Controls.Add(this.btnExcluirDocumentos);
            this.grpAcao.Controls.Add(this.btnDigitalizar);
            this.grpAcao.Location = new System.Drawing.Point(11, 322);
            this.grpAcao.Name = "grpAcao";
            this.grpAcao.Size = new System.Drawing.Size(950, 74);
            this.grpAcao.TabIndex = 27;
            this.grpAcao.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(744, 21);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 35);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.BackgroundImage")));
            this.btnVisualizar.Enabled = false;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnVisualizar.Image = global::DigitalView.Properties.Resources.magnifying_glass_24x24;
            this.btnVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizar.Location = new System.Drawing.Point(498, 21);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(200, 35);
            this.btnVisualizar.TabIndex = 2;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnExcluirDocumentos
            // 
            this.btnExcluirDocumentos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirDocumentos.BackgroundImage")));
            this.btnExcluirDocumentos.Enabled = false;
            this.btnExcluirDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirDocumentos.ForeColor = System.Drawing.Color.White;
            this.btnExcluirDocumentos.Image = global::DigitalView.Properties.Resources.trash_fill_24x24;
            this.btnExcluirDocumentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirDocumentos.Location = new System.Drawing.Point(249, 21);
            this.btnExcluirDocumentos.Name = "btnExcluirDocumentos";
            this.btnExcluirDocumentos.Size = new System.Drawing.Size(200, 35);
            this.btnExcluirDocumentos.TabIndex = 1;
            this.btnExcluirDocumentos.Text = "Excluir";
            this.btnExcluirDocumentos.UseVisualStyleBackColor = true;
            this.btnExcluirDocumentos.Click += new System.EventHandler(this.btnExcluirDocumentos_Click);
            // 
            // btnDigitalizar
            // 
            this.btnDigitalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDigitalizar.BackgroundImage")));
            this.btnDigitalizar.Enabled = false;
            this.btnDigitalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDigitalizar.ForeColor = System.Drawing.Color.White;
            this.btnDigitalizar.Image = global::DigitalView.Properties.Resources.play_alt_24x24;
            this.btnDigitalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDigitalizar.Location = new System.Drawing.Point(14, 21);
            this.btnDigitalizar.Name = "btnDigitalizar";
            this.btnDigitalizar.Size = new System.Drawing.Size(200, 35);
            this.btnDigitalizar.TabIndex = 0;
            this.btnDigitalizar.Text = "Digitalizar";
            this.btnDigitalizar.UseVisualStyleBackColor = true;
            this.btnDigitalizar.Click += new System.EventHandler(this.btnDigitalizar_Click);
            // 
            // lblCNPJCPF
            // 
            this.lblCNPJCPF.AutoSize = true;
            this.lblCNPJCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJCPF.ForeColor = System.Drawing.Color.Navy;
            this.lblCNPJCPF.Location = new System.Drawing.Point(139, 78);
            this.lblCNPJCPF.Name = "lblCNPJCPF";
            this.lblCNPJCPF.Size = new System.Drawing.Size(0, 20);
            this.lblCNPJCPF.TabIndex = 26;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Navy;
            this.lblNome.Location = new System.Drawing.Point(138, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 20);
            this.lblNome.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "NOME DO CLIENTE:";
            this.label4.Enter += new System.EventHandler(this.frmAtualizarDocumentosDigitalizados_Load);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(520, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(419, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "<DIGITE O NÚMERO DE REFERÊNCIA E TECLE ENTER>";
            this.label11.Enter += new System.EventHandler(this.frmAtualizarDocumentosDigitalizados_Load);
            // 
            // grpDocumentos
            // 
            this.grpDocumentos.Controls.Add(this.cmbDocumento);
            this.grpDocumentos.Controls.Add(this.label3);
            this.grpDocumentos.Controls.Add(this.lblPathDiretorio);
            this.grpDocumentos.Controls.Add(this.label9);
            this.grpDocumentos.Controls.Add(this.cmbTipoDocumento);
            this.grpDocumentos.Controls.Add(this.label6);
            this.grpDocumentos.Enabled = false;
            this.grpDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDocumentos.Location = new System.Drawing.Point(11, 176);
            this.grpDocumentos.Name = "grpDocumentos";
            this.grpDocumentos.Size = new System.Drawing.Size(950, 140);
            this.grpDocumentos.TabIndex = 22;
            this.grpDocumentos.TabStop = false;
            this.grpDocumentos.Text = "DOCUMENTO A SEREM DIGITALIZADOS";
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumento.Enabled = false;
            this.cmbDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDocumento.Location = new System.Drawing.Point(179, 71);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(400, 28);
            this.cmbDocumento.TabIndex = 12;
            this.cmbDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbDocumento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "DOCUMENTOS :";
            // 
            // lblPathDiretorio
            // 
            this.lblPathDiretorio.AutoSize = true;
            this.lblPathDiretorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathDiretorio.ForeColor = System.Drawing.Color.Navy;
            this.lblPathDiretorio.Location = new System.Drawing.Point(224, 110);
            this.lblPathDiretorio.Name = "lblPathDiretorio";
            this.lblPathDiretorio.Size = new System.Drawing.Size(0, 17);
            this.lblPathDiretorio.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "DIRETÓRIO DE DIGITALIZAÇÃO:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDocumento.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(179, 26);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(400, 28);
            this.cmbTipoDocumento.TabIndex = 3;
            this.cmbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "TIPO DE DOCUMENTOS :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "PROCESSO (NREF):";
            this.label1.Enter += new System.EventHandler(this.frmAtualizarDocumentosDigitalizados_Load);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.ForeColor = System.Drawing.Color.Navy;
            this.lblNomeCliente.Location = new System.Drawing.Point(116, 29);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(0, 13);
            this.lblNomeCliente.TabIndex = 21;
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtReferencia.Location = new System.Drawing.Point(195, 17);
            this.txtReferencia.MaxLength = 15;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(303, 41);
            this.txtReferencia.TabIndex = 19;
            this.txtReferencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReferencia_KeyDown);
            // 
            // lblCPForCNPJ
            // 
            this.lblCPForCNPJ.AutoSize = true;
            this.lblCPForCNPJ.Location = new System.Drawing.Point(11, 107);
            this.lblCPForCNPJ.Name = "lblCPForCNPJ";
            this.lblCPForCNPJ.Size = new System.Drawing.Size(83, 13);
            this.lblCPForCNPJ.TabIndex = 20;
            this.lblCPForCNPJ.Text = "CNPJ / CPF :";
            this.lblCPForCNPJ.Enter += new System.EventHandler(this.frmAtualizarDocumentosDigitalizados_Load);
            // 
            // tabDadosCadastrais
            // 
            this.tabDadosCadastrais.BackColor = System.Drawing.Color.Transparent;
            this.tabDadosCadastrais.BackgroundImage = global::DigitalView.Properties.Resources.background_main;
            this.tabDadosCadastrais.Controls.Add(this.btnConsultar);
            this.tabDadosCadastrais.Controls.Add(this.label7);
            this.tabDadosCadastrais.Controls.Add(this.comboDocumentoDadosCadastrais);
            this.tabDadosCadastrais.Controls.Add(this.groupBox1);
            this.tabDadosCadastrais.Controls.Add(this.cmbCliente);
            this.tabDadosCadastrais.Controls.Add(this.label5);
            this.tabDadosCadastrais.Location = new System.Drawing.Point(4, 25);
            this.tabDadosCadastrais.Name = "tabDadosCadastrais";
            this.tabDadosCadastrais.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosCadastrais.Size = new System.Drawing.Size(969, 405);
            this.tabDadosCadastrais.TabIndex = 1;
            this.tabDadosCadastrais.Text = "Dados Cadastrais";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Image = global::DigitalView.Properties.Resources.magnifying_glass_24x24;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(723, 82);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(200, 35);
            this.btnConsultar.TabIndex = 31;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "DOCUMENTOS :";
            // 
            // comboDocumentoDadosCadastrais
            // 
            this.comboDocumentoDadosCadastrais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDocumentoDadosCadastrais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDocumentoDadosCadastrais.Location = new System.Drawing.Point(132, 85);
            this.comboDocumentoDadosCadastrais.Name = "comboDocumentoDadosCadastrais";
            this.comboDocumentoDadosCadastrais.Size = new System.Drawing.Size(563, 28);
            this.comboDocumentoDadosCadastrais.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnVisualizarDocumentosCadastrais);
            this.groupBox1.Controls.Add(this.btnExcluirDocumentosCadastrais);
            this.groupBox1.Location = new System.Drawing.Point(6, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 74);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(686, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVisualizarDocumentosCadastrais
            // 
            this.btnVisualizarDocumentosCadastrais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisualizarDocumentosCadastrais.BackgroundImage")));
            this.btnVisualizarDocumentosCadastrais.Enabled = false;
            this.btnVisualizarDocumentosCadastrais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarDocumentosCadastrais.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarDocumentosCadastrais.Image = global::DigitalView.Properties.Resources.magnifying_glass_24x24;
            this.btnVisualizarDocumentosCadastrais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarDocumentosCadastrais.Location = new System.Drawing.Point(361, 19);
            this.btnVisualizarDocumentosCadastrais.Name = "btnVisualizarDocumentosCadastrais";
            this.btnVisualizarDocumentosCadastrais.Size = new System.Drawing.Size(200, 35);
            this.btnVisualizarDocumentosCadastrais.TabIndex = 2;
            this.btnVisualizarDocumentosCadastrais.Text = "Visualizar";
            this.btnVisualizarDocumentosCadastrais.UseVisualStyleBackColor = true;
            this.btnVisualizarDocumentosCadastrais.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnExcluirDocumentosCadastrais
            // 
            this.btnExcluirDocumentosCadastrais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirDocumentosCadastrais.BackgroundImage")));
            this.btnExcluirDocumentosCadastrais.Enabled = false;
            this.btnExcluirDocumentosCadastrais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirDocumentosCadastrais.ForeColor = System.Drawing.Color.White;
            this.btnExcluirDocumentosCadastrais.Image = global::DigitalView.Properties.Resources.trash_fill_24x24;
            this.btnExcluirDocumentosCadastrais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirDocumentosCadastrais.Location = new System.Drawing.Point(53, 19);
            this.btnExcluirDocumentosCadastrais.Name = "btnExcluirDocumentosCadastrais";
            this.btnExcluirDocumentosCadastrais.Size = new System.Drawing.Size(200, 35);
            this.btnExcluirDocumentosCadastrais.TabIndex = 1;
            this.btnExcluirDocumentosCadastrais.Text = "Excluir";
            this.btnExcluirDocumentosCadastrais.UseVisualStyleBackColor = true;
            this.btnExcluirDocumentosCadastrais.Click += new System.EventHandler(this.btnExcluirDocumentosCadastrais_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.ForeColor = System.Drawing.Color.Black;
            this.cmbCliente.Location = new System.Drawing.Point(132, 37);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(791, 28);
            this.cmbCliente.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CLIENTE:";
            // 
            // lstDocumentosDigitalisados
            // 
            this.lstDocumentosDigitalisados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstDocumentosDigitalisados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDocumentosDigitalisados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.colNomeArquivo,
            this.colPath});
            this.lstDocumentosDigitalisados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstDocumentosDigitalisados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lstDocumentosDigitalisados.FullRowSelect = true;
            this.lstDocumentosDigitalisados.GridLines = true;
            this.lstDocumentosDigitalisados.Location = new System.Drawing.Point(0, 443);
            this.lstDocumentosDigitalisados.MultiSelect = false;
            this.lstDocumentosDigitalisados.Name = "lstDocumentosDigitalisados";
            this.lstDocumentosDigitalisados.Size = new System.Drawing.Size(987, 220);
            this.lstDocumentosDigitalisados.TabIndex = 16;
            this.lstDocumentosDigitalisados.UseCompatibleStateImageBehavior = false;
            this.lstDocumentosDigitalisados.View = System.Windows.Forms.View.Details;
            // 
            // col1
            // 
            this.col1.DisplayIndex = 2;
            this.col1.Width = 0;
            // 
            // colNomeArquivo
            // 
            this.colNomeArquivo.DisplayIndex = 0;
            this.colNomeArquivo.Text = "Nome do Arquivo";
            this.colNomeArquivo.Width = 200;
            // 
            // colPath
            // 
            this.colPath.DisplayIndex = 1;
            this.colPath.Text = "Caminho do Arquivo";
            this.colPath.Width = 750;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel2.BackgroundImage")));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.Controls.Add(this.iconFechar, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.iconMinimizar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(987, 44);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // iconFechar
            // 
            this.iconFechar.BackColor = System.Drawing.Color.Transparent;
            this.iconFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconFechar.Image = global::DigitalView.Properties.Resources.x_alt_32x32;
            this.iconFechar.Location = new System.Drawing.Point(929, 3);
            this.iconFechar.Name = "iconFechar";
            this.iconFechar.Size = new System.Drawing.Size(55, 38);
            this.iconFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconFechar.TabIndex = 1;
            this.iconFechar.TabStop = false;
            this.iconFechar.Click += new System.EventHandler(this.iconFechar_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconMinimizar.Image = global::DigitalView.Properties.Resources.minus_alt_32x32;
            this.iconMinimizar.Location = new System.Drawing.Point(870, 3);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(53, 38);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconMinimizar.TabIndex = 2;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manutenção dos documentos digitalizados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAtualizarDocumentosDigitalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAtualizarDocumentosDigitalizados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Documentos Digitalizados";
            this.Load += new System.EventHandler(this.frmAtualizarDocumentosDigitalizados_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.tabManutencao.ResumeLayout(false);
            this.tabProcessos.ResumeLayout(false);
            this.tabProcessos.PerformLayout();
            this.grpAcao.ResumeLayout(false);
            this.grpDocumentos.ResumeLayout(false);
            this.grpDocumentos.PerformLayout();
            this.tabDadosCadastrais.ResumeLayout(false);
            this.tabDadosCadastrais.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListView lstDocumentosDigitalisados;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader colNomeArquivo;
        private System.Windows.Forms.ColumnHeader colPath;
        private System.Windows.Forms.TabControl tabManutencao;
        private System.Windows.Forms.TabPage tabProcessos;
        private System.Windows.Forms.GroupBox grpAcao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnExcluirDocumentos;
        private System.Windows.Forms.Button btnDigitalizar;
        private System.Windows.Forms.Label lblCNPJCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpDocumentos;
        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPathDiretorio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblCPForCNPJ;
        private System.Windows.Forms.TabPage tabDadosCadastrais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVisualizarDocumentosCadastrais;
        private System.Windows.Forms.Button btnExcluirDocumentosCadastrais;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboDocumentoDadosCadastrais;
        private System.Windows.Forms.Button btnConsultar;

        //private Nevron.UI.WinForm.Controls.NGrouper grpDigitalizar;
        //private Nevron.UI.WinForm.Controls.NButton btnSair;
        //private Nevron.UI.WinForm.Controls.NButton btnDigitalizar;
        //private Nevron.UI.WinForm.Controls.NComboBox cmbDocumento;
    }
}