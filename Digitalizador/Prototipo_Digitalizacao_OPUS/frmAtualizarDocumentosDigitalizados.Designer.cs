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
            this.grpDigitalizar = new System.Windows.Forms.GroupBox();
            this.btnExcluirDocumentos = new  System.Windows.Forms.Button();
            this.btnVisualizar = new  System.Windows.Forms.Button();
            this.btnSair = new  System.Windows.Forms.Button();
            this.btnDigitalizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstDocumentosDigitalisados = new System.Windows.Forms.ListView();
            this.col1 = new System.Windows.Forms.ColumnHeader();
            this.colNomeArquivo = new System.Windows.Forms.ColumnHeader();
            this.colPath = new System.Windows.Forms.ColumnHeader();
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
            ((System.ComponentModel.ISupportInitialize)(this.grpDigitalizar)).BeginInit();
            this.grpDigitalizar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpDocumentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDigitalizar
            // 
            this.grpDigitalizar.Controls.Add(this.btnExcluirDocumentos);
            this.grpDigitalizar.Controls.Add(this.btnVisualizar);
            this.grpDigitalizar.Controls.Add(this.btnSair);
            this.grpDigitalizar.Controls.Add(this.btnDigitalizar);
            this.grpDigitalizar.Controls.Add(this.panel1);
            this.grpDigitalizar.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.grpDigitalizar.FooterItem.ContentAlign = System.Drawing.ContentAlignment.MiddleRight;
            //this.grpDigitalizar.FooterItem.Text = "Digitalização de Documentos [Modo de Manutenção]";
            //this.grpDigitalizar.HeaderItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.grpDigitalizar.HeaderItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            //this.grpDigitalizar.HeaderItem.Image = ((System.Drawing.Image)(resources.GetObject("grpDigitalizar.HeaderItem.Image")));
            //this.grpDigitalizar.HeaderItem.ImageSize = new System.Drawing.Size(48, 48);
            //this.grpDigitalizar.HeaderItem.Text = "Digitalização de Documentos [MODO DE MANUTENÇÃO]";
            this.grpDigitalizar.Location = new System.Drawing.Point(0, 0);
            this.grpDigitalizar.Name = "grpDigitalizar";
            //this.grpDigitalizar.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Ocean;
            this.grpDigitalizar.Size = new System.Drawing.Size(997, 655);
            this.grpDigitalizar.TabIndex = 2;
            // 
            // btnExcluirDocumentos
            // 
            this.btnExcluirDocumentos.Enabled = false;
            this.btnExcluirDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirDocumentos.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirDocumentos.Image")));
            this.btnExcluirDocumentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirDocumentos.Location = new System.Drawing.Point(260, 587);
            this.btnExcluirDocumentos.Name = "btnExcluirDocumentos";
            //this.btnExcluirDocumentos.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Ocean;
            this.btnExcluirDocumentos.Size = new System.Drawing.Size(209, 30);
            this.btnExcluirDocumentos.TabIndex = 12;
            this.btnExcluirDocumentos.Text = "&Excluir Documento";
            this.btnExcluirDocumentos.Click += new System.EventHandler(this.btnExcluirDocumentos_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Enabled = false;
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizar.Location = new System.Drawing.Point(12, 587);
            this.btnVisualizar.Name = "btnVisualizar";
            //this.btnVisualizar.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Ocean;
            this.btnVisualizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVisualizar.Size = new System.Drawing.Size(209, 30);
            this.btnVisualizar.TabIndex = 11;
            this.btnVisualizar.Text = "&Visualizar Documento";
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(766, 587);
            this.btnSair.Name = "btnSair";
            //this.btnSair.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Ocean;
            this.btnSair.Size = new System.Drawing.Size(209, 30);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "&Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDigitalizar
            // 
            this.btnDigitalizar.Enabled = false;
            this.btnDigitalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigitalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnDigitalizar.Image")));
            this.btnDigitalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDigitalizar.Location = new System.Drawing.Point(510, 587);
            this.btnDigitalizar.Name = "btnDigitalizar";
            //this.btnDigitalizar.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Ocean;
            this.btnDigitalizar.Size = new System.Drawing.Size(209, 30);
            this.btnDigitalizar.TabIndex = 9;
            this.btnDigitalizar.Text = "&Alterar Documento";
            this.btnDigitalizar.Click += new System.EventHandler(this.btnDigitalizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lstDocumentosDigitalisados);
            this.panel1.Controls.Add(this.lblCNPJCPF);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.grpDocumentos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNomeCliente);
            this.panel1.Controls.Add(this.txtReferencia);
            this.panel1.Controls.Add(this.lblCPForCNPJ);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 511);
            this.panel1.TabIndex = 7;
            // 
            // lstDocumentosDigitalisados
            // 
            this.lstDocumentosDigitalisados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstDocumentosDigitalisados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.colNomeArquivo,
            this.colPath});
            this.lstDocumentosDigitalisados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstDocumentosDigitalisados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lstDocumentosDigitalisados.FullRowSelect = true;
            this.lstDocumentosDigitalisados.GridLines = true;
            this.lstDocumentosDigitalisados.Location = new System.Drawing.Point(0, 293);
            this.lstDocumentosDigitalisados.MultiSelect = false;
            this.lstDocumentosDigitalisados.Name = "lstDocumentosDigitalisados";
            this.lstDocumentosDigitalisados.Size = new System.Drawing.Size(963, 218);
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
            this.label4.Location = new System.Drawing.Point(18, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "NOME DO CLIENTE:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(457, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(338, 13);
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
            this.grpDocumentos.Size = new System.Drawing.Size(958, 140);
            this.grpDocumentos.TabIndex = 11;
            this.grpDocumentos.TabStop = false;
            this.grpDocumentos.Text = "DOCUMENTO A SEREM DIGITALIZADOS";
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.Enabled = false;
            this.cmbDocumento.Location = new System.Drawing.Point(179, 71);
            this.cmbDocumento.Name = "cmbDocumento";
            //this.cmbDocumento.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Ocean;
            this.cmbDocumento.Size = new System.Drawing.Size(299, 22);
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
            this.cmbTipoDocumento.Location = new System.Drawing.Point(179, 43);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            //this.cmbTipoDocumento.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Ocean;
            this.cmbTipoDocumento.Size = new System.Drawing.Size(217, 22);
            this.cmbTipoDocumento.TabIndex = 3;
            this.cmbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "TIPO DE DOCUMENTOS :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROCESSO:";
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
            this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtReferencia.Location = new System.Drawing.Point(151, 16);
            this.txtReferencia.MaxLength = 15;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(285, 32);
            this.txtReferencia.TabIndex = 1;
            this.txtReferencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReferencia_KeyDown);
            // 
            // lblCPForCNPJ
            // 
            this.lblCPForCNPJ.AutoSize = true;
            this.lblCPForCNPJ.Location = new System.Drawing.Point(18, 108);
            this.lblCPForCNPJ.Name = "lblCPForCNPJ";
            this.lblCPForCNPJ.Size = new System.Drawing.Size(83, 13);
            this.lblCPForCNPJ.TabIndex = 3;
            this.lblCPForCNPJ.Text = "CNPJ / CPF :";
            // 
            // frmAtualizarDocumentosDigitalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 655);
            this.Controls.Add(this.grpDigitalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAtualizarDocumentosDigitalizados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Documentos Digitalizados";
            this.Load += new System.EventHandler(this.frmAtualizarDocumentosDigitalizados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpDigitalizar)).EndInit();
            this.grpDigitalizar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpDocumentos.ResumeLayout(false);
            this.grpDocumentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private Nevron.UI.WinForm.Controls.NGrouper grpDigitalizar;
        //private Nevron.UI.WinForm.Controls.NButton btnSair;
        //private Nevron.UI.WinForm.Controls.NButton btnDigitalizar;

        private System.Windows.Forms.GroupBox grpDigitalizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDigitalizar;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCNPJCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpDocumentos;
        //private Nevron.UI.WinForm.Controls.NComboBox cmbDocumento;

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
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnExcluirDocumentos;
        private System.Windows.Forms.ListView lstDocumentosDigitalisados;
        private System.Windows.Forms.ColumnHeader colNomeArquivo;
        private System.Windows.Forms.ColumnHeader colPath;
        private System.Windows.Forms.ColumnHeader col1;
    }
}