namespace DigitalView
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.mnuSistema = new System.Windows.Forms.MenuStrip();
            this.digitalizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDigitalizarDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencaoDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parâmetrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stMain = new System.Windows.Forms.StatusBar();
            this.Explorer = new System.Windows.Forms.Panel();
            this.exSistema = new System.Windows.Forms.Panel();
            this.lnkSair = new System.Windows.Forms.LinkLabel();
            this.lnkParametros = new System.Windows.Forms.LinkLabel();
            this.lnkSobre = new System.Windows.Forms.LinkLabel();
            this.exDigitalizacao = new System.Windows.Forms.Panel();
            this.lnkAtualizar = new System.Windows.Forms.LinkLabel();
            this.lnkDigitalizarDocumentos = new System.Windows.Forms.LinkLabel();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mnuSistema.SuspendLayout();
            this.Explorer.SuspendLayout();
            this.exSistema.SuspendLayout();
            this.exDigitalizacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuSistema
            // 
            this.mnuSistema.BackColor = System.Drawing.Color.AliceBlue;
            this.mnuSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.digitalizaçãoToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.mnuSistema.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mnuSistema.Location = new System.Drawing.Point(0, 0);
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Size = new System.Drawing.Size(991, 21);
            this.mnuSistema.TabIndex = 0;
            this.mnuSistema.Text = "mnuSistema";
            // 
            // digitalizaçãoToolStripMenuItem
            // 
            this.digitalizaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDigitalizarDocumentos,
            this.mnuManutencaoDoc});
            this.digitalizaçãoToolStripMenuItem.Name = "digitalizaçãoToolStripMenuItem";
            this.digitalizaçãoToolStripMenuItem.Size = new System.Drawing.Size(78, 17);
            this.digitalizaçãoToolStripMenuItem.Text = "Digitalização";
            // 
            // mnuDigitalizarDocumentos
            // 
            this.mnuDigitalizarDocumentos.Name = "mnuDigitalizarDocumentos";
            this.mnuDigitalizarDocumentos.Size = new System.Drawing.Size(283, 22);
            this.mnuDigitalizarDocumentos.Text = "Digitalizar Documentos";
            this.mnuDigitalizarDocumentos.Click += new System.EventHandler(this.mnuDigitalizarDocumentos_Click);
            // 
            // mnuManutencaoDoc
            // 
            this.mnuManutencaoDoc.Name = "mnuManutencaoDoc";
            this.mnuManutencaoDoc.Size = new System.Drawing.Size(283, 22);
            this.mnuManutencaoDoc.Text = "Manutenção de Documentos Digitalizados";
            this.mnuManutencaoDoc.Click += new System.EventHandler(this.mnuManutencaoDoc_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.parâmetrosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(56, 17);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // parâmetrosToolStripMenuItem
            // 
            this.parâmetrosToolStripMenuItem.Name = "parâmetrosToolStripMenuItem";
            this.parâmetrosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.parâmetrosToolStripMenuItem.Text = "Parâmetros";
            this.parâmetrosToolStripMenuItem.Click += new System.EventHandler(this.parâmetrosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // stMain
            // 
            this.stMain.Location = new System.Drawing.Point(0, 468);
            this.stMain.Name = "stMain";
            this.stMain.ShowPanels = true;
            this.stMain.Size = new System.Drawing.Size(989, 22);
            this.stMain.TabIndex = 0;
            this.stMain.Text = "nStatusBar1";
            // 
            // Explorer
            // 
            this.Explorer.Controls.Add(this.exSistema);
            this.Explorer.Dock = System.Windows.Forms.DockStyle.Left;
            this.Explorer.Location = new System.Drawing.Point(0, 0);
            this.Explorer.Name = "Explorer";
            this.Explorer.Size = new System.Drawing.Size(250, 468);
            this.Explorer.TabIndex = 2;
            // 
            // exSistema
            // 
            this.exSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.exSistema.Controls.Add(this.lnkSair);
            this.exSistema.Controls.Add(this.lnkParametros);
            this.exSistema.Controls.Add(this.lnkSobre);
            this.exSistema.Location = new System.Drawing.Point(8, 126);
            this.exSistema.Name = "exSistema";
            this.exSistema.Size = new System.Drawing.Size(234, 135);
            this.exSistema.TabIndex = 2;
            this.exSistema.Text = "Sistema";
            // 
            // lnkSair
            // 
            this.lnkSair.AutoSize = true;
            this.lnkSair.Location = new System.Drawing.Point(22, 105);
            this.lnkSair.Name = "lnkSair";
            this.lnkSair.Size = new System.Drawing.Size(25, 13);
            this.lnkSair.TabIndex = 7;
            this.lnkSair.TabStop = true;
            this.lnkSair.Text = "Sair";
            this.lnkSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSair_LinkClicked);
            // 
            // lnkParametros
            // 
            this.lnkParametros.AutoSize = true;
            this.lnkParametros.Location = new System.Drawing.Point(22, 84);
            this.lnkParametros.Name = "lnkParametros";
            this.lnkParametros.Size = new System.Drawing.Size(60, 13);
            this.lnkParametros.TabIndex = 6;
            this.lnkParametros.TabStop = true;
            this.lnkParametros.Text = "Parâmetros";
            this.lnkParametros.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkParametros_LinkClicked);
            // 
            // lnkSobre
            // 
            this.lnkSobre.AutoSize = true;
            this.lnkSobre.Location = new System.Drawing.Point(22, 65);
            this.lnkSobre.Name = "lnkSobre";
            this.lnkSobre.Size = new System.Drawing.Size(35, 13);
            this.lnkSobre.TabIndex = 5;
            this.lnkSobre.TabStop = true;
            this.lnkSobre.Text = "Sobre";
            this.lnkSobre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSobre_LinkClicked);
            // 
            // exDigitalizacao
            // 
            this.exDigitalizacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.exDigitalizacao.Controls.Add(this.lnkAtualizar);
            this.exDigitalizacao.Controls.Add(this.lnkDigitalizarDocumentos);
            this.exDigitalizacao.Location = new System.Drawing.Point(8, 8);
            this.exDigitalizacao.Name = "exDigitalizacao";
            this.exDigitalizacao.Size = new System.Drawing.Size(234, 110);
            this.exDigitalizacao.TabIndex = 0;
            this.exDigitalizacao.Text = "Digitalização";
            // 
            // lnkAtualizar
            // 
            this.lnkAtualizar.AutoSize = true;
            this.lnkAtualizar.Location = new System.Drawing.Point(14, 78);
            this.lnkAtualizar.Name = "lnkAtualizar";
            this.lnkAtualizar.Size = new System.Drawing.Size(210, 13);
            this.lnkAtualizar.TabIndex = 1;
            this.lnkAtualizar.TabStop = true;
            this.lnkAtualizar.Text = "Manutenção de  Documentos Digitalizados";
            this.lnkAtualizar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAtualizar_LinkClicked);
            // 
            // lnkDigitalizarDocumentos
            // 
            this.lnkDigitalizarDocumentos.AutoSize = true;
            this.lnkDigitalizarDocumentos.Location = new System.Drawing.Point(14, 59);
            this.lnkDigitalizarDocumentos.Name = "lnkDigitalizarDocumentos";
            this.lnkDigitalizarDocumentos.Size = new System.Drawing.Size(115, 13);
            this.lnkDigitalizarDocumentos.TabIndex = 0;
            this.lnkDigitalizarDocumentos.TabStop = true;
            this.lnkDigitalizarDocumentos.Text = "Digitalizar Documentos";
            this.lnkDigitalizarDocumentos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDigitalizarDocumentos_LinkClicked);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 493);
            this.statusBar.Name = "statusBar";
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(991, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "stMain";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 21);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(991, 472);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel2.BackgroundImage")));
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(19, 263);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.7732F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.22681F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(283, 242);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.linkLabel5);
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Controls.Add(this.linkLabel3);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.linkLabel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 172);
            this.panel3.TabIndex = 0;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(57, 134);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(25, 13);
            this.linkLabel5.TabIndex = 5;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Sair";
            this.linkLabel5.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(11, 116);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 33);
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(56, 87);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(60, 13);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Parâmetros";
            this.linkLabel3.Click += new System.EventHandler(this.parâmetrosToolStripMenuItem_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 69);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 33);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(9, 19);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 33);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(55, 37);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(35, 13);
            this.linkLabel4.TabIndex = 1;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Sobre";
            this.linkLabel4.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 55);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parâmetros";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(53, 49);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.7732F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.22681F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(283, 242);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 172);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(56, 87);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(203, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Manutenção de documentos digitalizados";
            this.linkLabel2.Click += new System.EventHandler(this.mnuManutencaoDoc_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(55, 37);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Digitalizar Documentos";
            this.linkLabel1.Click += new System.EventHandler(this.mnuDigitalizarDocumentos_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 55);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digitalização";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 44);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 515);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mnuSistema);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuSistema;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGPA [Módulo de Digitalização]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.mnuSistema.ResumeLayout(false);
            this.mnuSistema.PerformLayout();
            this.Explorer.ResumeLayout(false);
            this.exSistema.ResumeLayout(false);
            this.exSistema.PerformLayout();
            this.exDigitalizacao.ResumeLayout(false);
            this.exDigitalizacao.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem digitalizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDigitalizarDocumentos;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencaoDoc;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        //private Nevron.UI.WinForm.Controls.NStatusBar stMain;
        //private Nevron.UI.WinForm.Controls.NUIPanel lnkDigitalizar;
        //private Nevron.UI.WinForm.Controls.NExpander exDigitalizacao;
        //private Nevron.UI.WinForm.Controls.NExpander exSistema;

        private System.Windows.Forms.StatusBar stMain;
        private System.Windows.Forms.Panel lnkDigitalizar;
        private System.Windows.Forms.Panel exDigitalizacao;
        private System.Windows.Forms.Panel exSistema;



        private System.Windows.Forms.LinkLabel lnkAtualizar;
        private System.Windows.Forms.LinkLabel lnkDigitalizarDocumentos;
        private System.Windows.Forms.LinkLabel lnkSair;
        private System.Windows.Forms.LinkLabel lnkParametros;
        private System.Windows.Forms.LinkLabel lnkSobre;
        private System.Windows.Forms.ToolStripMenuItem parâmetrosToolStripMenuItem;
        //private Nevron.UI.WinForm.Controls.NExplorerBar Explorer;


        private System.Windows.Forms.Panel Explorer;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
       


    }
}