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
            //this.stMain = new Nevron.UI.WinForm.Controls.NStatusBar();
            this.stMain = new System.Windows.Forms.StatusBar();

            //this.lnkDigitalizar = new Nevron.UI.WinForm.Controls.NUIPanel();
            //this.Explorer = new Nevron.UI.WinForm.Controls.NExplorerBar();
            this.Explorer = new System.Windows.Forms.Panel();

            this.exDigitalizacao = new System.Windows.Forms.Panel();

            this.exDigitalizacao = new System.Windows.Forms.Panel();

            this.lnkAtualizar = new System.Windows.Forms.LinkLabel();
            this.lnkDigitalizarDocumentos = new System.Windows.Forms.LinkLabel();
            //this.exSistema = new Nevron.UI.WinForm.Controls.NExpander();

            this.exSistema = new System.Windows.Forms.Panel();

            this.lnkSair = new System.Windows.Forms.LinkLabel();
            this.lnkParametros = new System.Windows.Forms.LinkLabel();
            this.lnkSobre = new System.Windows.Forms.LinkLabel();
            this.mnuSistema.SuspendLayout();
            this.lnkDigitalizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Explorer)).BeginInit();
            this.Explorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exDigitalizacao)).BeginInit();
            this.exDigitalizacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exSistema)).BeginInit();
            this.exSistema.SuspendLayout();
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
            this.mnuSistema.Size = new System.Drawing.Size(991, 23);
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
            this.parâmetrosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.parâmetrosToolStripMenuItem.Text = "Parâmetros";
            this.parâmetrosToolStripMenuItem.Click += new System.EventHandler(this.parâmetrosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // stMain
            // 
            this.stMain.Location = new System.Drawing.Point(0, 468);
            this.stMain.Name = "stMain";
            //this.stMain.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Ocean;
            this.stMain.ShowPanels = true;
            this.stMain.Size = new System.Drawing.Size(989, 22);
            this.stMain.TabIndex = 0;
            this.stMain.Text = "nStatusBar1";
            // 
            // lnkDigitalizar
            // 
            this.lnkDigitalizar.Controls.Add(this.Explorer);
            this.lnkDigitalizar.Controls.Add(this.stMain);
            this.lnkDigitalizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkDigitalizar.Location = new System.Drawing.Point(0, 23);
            this.lnkDigitalizar.Name = "lnkDigitalizar";
            //this.lnkDigitalizar.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Ocean;
            this.lnkDigitalizar.Size = new System.Drawing.Size(991, 492);
            this.lnkDigitalizar.TabIndex = 1;
            this.lnkDigitalizar.Text = "48";
            // 
            // Explorer
            // 
            this.Explorer.Controls.Add(this.exDigitalizacao);
            this.Explorer.Controls.Add(this.exSistema);
            this.Explorer.Dock = System.Windows.Forms.DockStyle.Left;
            this.Explorer.Location = new System.Drawing.Point(0, 0);
            this.Explorer.Name = "Explorer";
            //this.Explorer.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Ocean;
            this.Explorer.Size = new System.Drawing.Size(250, 468);
            this.Explorer.TabIndex = 2;
            // 
            // exDigitalizacao
            // 
            this.exDigitalizacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.exDigitalizacao.Controls.Add(this.lnkAtualizar);
            this.exDigitalizacao.Controls.Add(this.lnkDigitalizarDocumentos);
            //this.exDigitalizacao.HeaderImage = ((System.Drawing.Image)(resources.GetObject("exDigitalizacao.HeaderImage")));
            //this.exDigitalizacao.HeaderImageSize = new System.Drawing.Size(48, 48);
            this.exDigitalizacao.Location = new System.Drawing.Point(8, 8);
            this.exDigitalizacao.Name = "exDigitalizacao";
            //this.exDigitalizacao.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Ocean;
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
            // exSistema
            // 
            this.exSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.exSistema.Controls.Add(this.lnkSair);
            this.exSistema.Controls.Add(this.lnkParametros);
            this.exSistema.Controls.Add(this.lnkSobre);
            //this.exSistema.HeaderImage = ((System.Drawing.Image)(resources.GetObject("exSistema.HeaderImage")));
            //this.exSistema.HeaderImageSize = new System.Drawing.Size(48, 48);
            this.exSistema.Location = new System.Drawing.Point(8, 126);
            this.exSistema.Name = "exSistema";
            //this.exSistema.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Ocean;
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
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(991, 515);
            this.Controls.Add(this.lnkDigitalizar);
            this.Controls.Add(this.mnuSistema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuSistema;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGPA [Módulo de Digitalização]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.mnuSistema.ResumeLayout(false);
            this.mnuSistema.PerformLayout();
            this.lnkDigitalizar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Explorer)).EndInit();
            this.Explorer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exDigitalizacao)).EndInit();
            this.exDigitalizacao.ResumeLayout(false);
            this.exDigitalizacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exSistema)).EndInit();
            this.exSistema.ResumeLayout(false);
            this.exSistema.PerformLayout();
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
       


    }
}