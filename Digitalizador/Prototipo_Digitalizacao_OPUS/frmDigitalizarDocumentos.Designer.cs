namespace DigitalView
{
    partial class frmDigitalizarDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDigitalizarDocumentos));
            this.chkVisualizacao = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDigitalizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCNPJCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpDocumentos = new System.Windows.Forms.GroupBox();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPathDiretorio = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblCPForCNPJ = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpDocumentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkVisualizacao
            // 
            this.chkVisualizacao.AutoSize = true;
            this.chkVisualizacao.BackColor = System.Drawing.Color.Transparent;
            this.chkVisualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVisualizacao.Location = new System.Drawing.Point(15, 87);
            this.chkVisualizacao.Name = "chkVisualizacao";
            this.chkVisualizacao.Size = new System.Drawing.Size(364, 21);
            this.chkVisualizacao.TabIndex = 14;
            this.chkVisualizacao.Text = "Visualizar documento durante DIGITALIZAÇÃO";
            this.chkVisualizacao.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(765, 485);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(209, 30);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "&SAIR";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDigitalizar
            // 
            this.btnDigitalizar.Enabled = false;
            this.btnDigitalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigitalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnDigitalizar.Image")));
            this.btnDigitalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDigitalizar.Location = new System.Drawing.Point(550, 485);
            this.btnDigitalizar.Name = "btnDigitalizar";
            this.btnDigitalizar.Size = new System.Drawing.Size(209, 30);
            this.btnDigitalizar.TabIndex = 9;
            this.btnDigitalizar.Text = "DIGITALIZAR DOCUMENTOS";
            this.btnDigitalizar.Click += new System.EventHandler(this.btnDigitalizar_Click);
            // 
            // panel1
            // 
            //this.panel1.BackColor = System.Drawing.Color.Transparent;
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
            this.panel1.Location = new System.Drawing.Point(12, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 337);
            this.panel1.TabIndex = 7;
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
            this.grpDocumentos.Controls.Add(this.lblNomeArquivo);
            this.grpDocumentos.Controls.Add(this.cmbTipoDocumento);
            this.grpDocumentos.Controls.Add(this.label7);
            this.grpDocumentos.Controls.Add(this.label6);
            this.grpDocumentos.Enabled = false;
            this.grpDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDocumentos.Location = new System.Drawing.Point(3, 147);
            this.grpDocumentos.Name = "grpDocumentos";
            this.grpDocumentos.Size = new System.Drawing.Size(958, 187);
            this.grpDocumentos.TabIndex = 11;
            this.grpDocumentos.TabStop = false;
            this.grpDocumentos.Text = "DOCUMENTO A SEREM DIGITALIZADOS";
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.Enabled = false;
            this.cmbDocumento.Location = new System.Drawing.Point(179, 71);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(299, 21);
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
            this.lblPathDiretorio.Location = new System.Drawing.Point(224, 137);
            this.lblPathDiretorio.Name = "lblPathDiretorio";
            this.lblPathDiretorio.Size = new System.Drawing.Size(0, 17);
            this.lblPathDiretorio.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "DIRETÓRIO DE DIGITALIZAÇÃO:";
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeArquivo.ForeColor = System.Drawing.Color.Navy;
            this.lblNomeArquivo.Location = new System.Drawing.Point(224, 104);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(0, 20);
            this.lblNomeArquivo.TabIndex = 7;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.Location = new System.Drawing.Point(179, 43);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(217, 21);
            this.cmbTipoDocumento.TabIndex = 3;
            this.cmbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "NOME DO ARQUIVO :";
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
            // frmDigitalizarDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 562);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDigitalizarDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitalizar Documentos";
            this.Load += new System.EventHandler(this.frmDigitalizarDocumentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpDocumentos.ResumeLayout(false);
            this.grpDocumentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDigitalizar;
        //private Nevron.UI.WinForm.Controls.NButton btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpDocumentos;
        private System.Windows.Forms.Label lblPathDiretorio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblCPForCNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEscanear;
        private System.Windows.Forms.Label label11;
        //private Nevron.UI.WinForm.Controls.NComboBox cmbDocumento;
        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCNPJCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDigitalizar;
        private System.Windows.Forms.CheckBox chkVisualizacao;
    }
}