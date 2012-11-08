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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNomeArquivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDocumentosDigitalisados = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpAcao.SuspendLayout();
            this.grpDocumentos.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 655);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.grpAcao);
            this.pnlMain.Controls.Add(this.lstDocumentosDigitalisados);
            this.pnlMain.Controls.Add(this.lblCNPJCPF);
            this.pnlMain.Controls.Add(this.lblNome);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label11);
            this.pnlMain.Controls.Add(this.grpDocumentos);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lblNomeCliente);
            this.pnlMain.Controls.Add(this.txtReferencia);
            this.pnlMain.Controls.Add(this.lblCPForCNPJ);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(5, 57);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(987, 593);
            this.pnlMain.TabIndex = 8;
            // 
            // grpAcao
            // 
            this.grpAcao.Controls.Add(this.btnSair);
            this.grpAcao.Controls.Add(this.btnVisualizar);
            this.grpAcao.Controls.Add(this.btnExcluirDocumentos);
            this.grpAcao.Controls.Add(this.btnDigitalizar);
            this.grpAcao.Location = new System.Drawing.Point(3, 293);
            this.grpAcao.Name = "grpAcao";
            this.grpAcao.Size = new System.Drawing.Size(981, 76);
            this.grpAcao.TabIndex = 17;
            this.grpAcao.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(827, 17);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(148, 48);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.BackgroundImage")));
            this.btnVisualizar.Enabled = false;
            this.btnVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(334, 17);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(148, 48);
            this.btnVisualizar.TabIndex = 2;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnExcluirDocumentos
            // 
            this.btnExcluirDocumentos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirDocumentos.BackgroundImage")));
            this.btnExcluirDocumentos.Enabled = false;
            this.btnExcluirDocumentos.ForeColor = System.Drawing.Color.White;
            this.btnExcluirDocumentos.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirDocumentos.Image")));
            this.btnExcluirDocumentos.Location = new System.Drawing.Point(171, 17);
            this.btnExcluirDocumentos.Name = "btnExcluirDocumentos";
            this.btnExcluirDocumentos.Size = new System.Drawing.Size(148, 48);
            this.btnExcluirDocumentos.TabIndex = 1;
            this.btnExcluirDocumentos.Text = "Excluir";
            this.btnExcluirDocumentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirDocumentos.UseVisualStyleBackColor = true;
            this.btnExcluirDocumentos.Click += new System.EventHandler(this.btnExcluirDocumentos_Click);
            // 
            // btnDigitalizar
            // 
            this.btnDigitalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDigitalizar.BackgroundImage")));
            this.btnDigitalizar.Enabled = false;
            this.btnDigitalizar.ForeColor = System.Drawing.Color.White;
            this.btnDigitalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnDigitalizar.Image")));
            this.btnDigitalizar.Location = new System.Drawing.Point(8, 17);
            this.btnDigitalizar.Name = "btnDigitalizar";
            this.btnDigitalizar.Size = new System.Drawing.Size(148, 48);
            this.btnDigitalizar.TabIndex = 0;
            this.btnDigitalizar.Text = "Digitalizar";
            this.btnDigitalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDigitalizar.UseVisualStyleBackColor = true;
            this.btnDigitalizar.Click += new System.EventHandler(this.btnDigitalizar_Click);
            // 
            // lblCNPJCPF
            // 
            this.lblCNPJCPF.AutoSize = true;
            this.lblCNPJCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJCPF.ForeColor = System.Drawing.Color.Navy;
            this.lblCNPJCPF.Location = new System.Drawing.Point(154, 102);
            this.lblCNPJCPF.Name = "lblCNPJCPF";
            this.lblCNPJCPF.Size = new System.Drawing.Size(0, 20);
            this.lblCNPJCPF.TabIndex = 15;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Navy;
            this.lblNome.Location = new System.Drawing.Point(153, 77);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 20);
            this.lblNome.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "NOME DO CLIENTE:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(522, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(419, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "<DIGITE O NÚMERO DE REFERÊNCIA E TECLE ENTER>";
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
            this.grpDocumentos.Location = new System.Drawing.Point(3, 147);
            this.grpDocumentos.Name = "grpDocumentos";
            this.grpDocumentos.Size = new System.Drawing.Size(981, 140);
            this.grpDocumentos.TabIndex = 11;
            this.grpDocumentos.TabStop = false;
            this.grpDocumentos.Text = "DOCUMENTO A SEREM DIGITALIZADOS";
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.Enabled = false;
            this.cmbDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDocumento.Location = new System.Drawing.Point(179, 71);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(400, 28);
            this.cmbDocumento.TabIndex = 12;
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
            this.cmbTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDocumento.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(179, 26);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(400, 28);
            this.cmbTipoDocumento.TabIndex = 3;
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
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROCESSO (NREF):";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.ForeColor = System.Drawing.Color.Navy;
            this.lblNomeCliente.Location = new System.Drawing.Point(131, 53);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(0, 13);
            this.lblNomeCliente.TabIndex = 4;
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtReferencia.Location = new System.Drawing.Point(182, 17);
            this.txtReferencia.MaxLength = 15;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(334, 41);
            this.txtReferencia.TabIndex = 1;
            this.txtReferencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReferencia_KeyDown);
            // 
            // lblCPForCNPJ
            // 
            this.lblCPForCNPJ.AutoSize = true;
            this.lblCPForCNPJ.Location = new System.Drawing.Point(13, 107);
            this.lblCPForCNPJ.Name = "lblCPForCNPJ";
            this.lblCPForCNPJ.Size = new System.Drawing.Size(83, 13);
            this.lblCPForCNPJ.TabIndex = 3;
            this.lblCPForCNPJ.Text = "CNPJ / CPF :";
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
            this.iconFechar.Image = ((System.Drawing.Image)(resources.GetObject("iconFechar.Image")));
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
            this.iconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconMinimizar.Image")));
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
            this.lstDocumentosDigitalisados.Location = new System.Drawing.Point(0, 375);
            this.lstDocumentosDigitalisados.MultiSelect = false;
            this.lstDocumentosDigitalisados.Name = "lstDocumentosDigitalisados";
            this.lstDocumentosDigitalisados.Size = new System.Drawing.Size(987, 218);
            this.lstDocumentosDigitalisados.TabIndex = 16;
            this.lstDocumentosDigitalisados.UseCompatibleStateImageBehavior = false;
            this.lstDocumentosDigitalisados.View = System.Windows.Forms.View.Details;
            // 
            // frmAtualizarDocumentosDigitalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 655);
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
            this.pnlMain.PerformLayout();
            this.grpAcao.ResumeLayout(false);
            this.grpDocumentos.ResumeLayout(false);
            this.grpDocumentos.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpAcao;
        private System.Windows.Forms.Button btnDigitalizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnExcluirDocumentos;
        private System.Windows.Forms.ListView lstDocumentosDigitalisados;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader colNomeArquivo;
        private System.Windows.Forms.ColumnHeader colPath;

        //private Nevron.UI.WinForm.Controls.NGrouper grpDigitalizar;
        //private Nevron.UI.WinForm.Controls.NButton btnSair;
        //private Nevron.UI.WinForm.Controls.NButton btnDigitalizar;
        //private Nevron.UI.WinForm.Controls.NComboBox cmbDocumento;
    }
}