namespace DigitalView
{
    partial class frmParametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametros));
            this.grpVisualizador = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCPForCNPJ = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNuDocDigital = new System.Windows.Forms.Label();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDiretorio = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTestConectionWS = new System.Windows.Forms.Button();
            this.txtURLWs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.grpVisualizador.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVisualizador
            // 
            this.grpVisualizador.BackColor = System.Drawing.Color.Transparent;
            this.grpVisualizador.Controls.Add(this.btnAtualizar);
            this.grpVisualizador.Controls.Add(this.panel1);
            this.grpVisualizador.Controls.Add(this.btnSair);
            this.grpVisualizador.Location = new System.Drawing.Point(4, 55);
            this.grpVisualizador.Name = "grpVisualizador";
            this.grpVisualizador.Size = new System.Drawing.Size(840, 318);
            this.grpVisualizador.TabIndex = 1;
            this.grpVisualizador.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtURLWs);
            this.panel1.Controls.Add(this.btnTestConectionWS);
            this.panel1.Controls.Add(this.btnDiretorio);
            this.panel1.Controls.Add(this.txtDiretorio);
            this.panel1.Controls.Add(this.lblNuDocDigital);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNomeCliente);
            this.panel1.Controls.Add(this.lblCPForCNPJ);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 173);
            this.panel1.TabIndex = 7;
            // 
            // lblCPForCNPJ
            // 
            this.lblCPForCNPJ.AutoSize = true;
            this.lblCPForCNPJ.Location = new System.Drawing.Point(18, 72);
            this.lblCPForCNPJ.Name = "lblCPForCNPJ";
            this.lblCPForCNPJ.Size = new System.Drawing.Size(222, 13);
            this.lblCPForCNPJ.TabIndex = 3;
            this.lblCPForCNPJ.Text = "Número de Documentos Digitalizados:";
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Diretório de Digitalização:";
            // 
            // lblNuDocDigital
            // 
            this.lblNuDocDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuDocDigital.ForeColor = System.Drawing.Color.Red;
            this.lblNuDocDigital.Location = new System.Drawing.Point(246, 65);
            this.lblNuDocDigital.Name = "lblNuDocDigital";
            this.lblNuDocDigital.Size = new System.Drawing.Size(100, 23);
            this.lblNuDocDigital.TabIndex = 10;
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(178, 27);
            this.txtDiretorio.MaxLength = 300;
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(551, 20);
            this.txtDiretorio.TabIndex = 6;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(456, 259);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(185, 38);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "&Atualizar Parâmetros";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpVisualizador, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlTitle, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 377);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnDiretorio
            // 
            this.btnDiretorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiretorio.BackgroundImage")));
            this.btnDiretorio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDiretorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiretorio.ForeColor = System.Drawing.Color.White;
            this.btnDiretorio.Image = ((System.Drawing.Image)(resources.GetObject("btnDiretorio.Image")));
            this.btnDiretorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiretorio.Location = new System.Drawing.Point(735, 19);
            this.btnDiretorio.Name = "btnDiretorio";
            this.btnDiretorio.Size = new System.Drawing.Size(70, 42);
            this.btnDiretorio.TabIndex = 9;
            this.btnDiretorio.Text = "...";
            this.btnDiretorio.Click += new System.EventHandler(this.btnDiretorio_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(647, 259);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(185, 38);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnTestConectionWS
            // 
            this.btnTestConectionWS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTestConectionWS.BackgroundImage")));
            this.btnTestConectionWS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTestConectionWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConectionWS.ForeColor = System.Drawing.Color.White;
            this.btnTestConectionWS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestConectionWS.Location = new System.Drawing.Point(735, 116);
            this.btnTestConectionWS.Name = "btnTestConectionWS";
            this.btnTestConectionWS.Size = new System.Drawing.Size(70, 47);
            this.btnTestConectionWS.TabIndex = 9;
            this.btnTestConectionWS.Text = "Testar Conexão";
            this.btnTestConectionWS.Click += new System.EventHandler(this.btnTestConectionWS_Click);
            // 
            // txtURLWs
            // 
            this.txtURLWs.Location = new System.Drawing.Point(21, 130);
            this.txtURLWs.Name = "txtURLWs";
            this.txtURLWs.Size = new System.Drawing.Size(708, 20);
            this.txtURLWs.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(58, 7);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(327, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parâmetros do sistema";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitle.BackgroundImage")));
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Controls.Add(this.label3);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(4, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(840, 44);
            this.pnlTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "URL do WebService de Integração  SIGPA.";
            // 
            // frmParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 377);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmParametros";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parâmetros";
            this.Load += new System.EventHandler(this.frmParametros_Load);
            this.grpVisualizador.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVisualizador;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtURLWs;
        private System.Windows.Forms.Button btnTestConectionWS;
        private System.Windows.Forms.Button btnDiretorio;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Label lblNuDocDigital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCPForCNPJ;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;


        //private Nevron.UI.WinForm.Controls.NGrouper grpVisualizador;
        //private Nevron.UI.WinForm.Controls.NButton btnSair;
        //private Nevron.UI.WinForm.Controls.NButton btnAtualizar;
        //private Nevron.UI.WinForm.Controls.NTextBox txtDiretorio;
        //private Nevron.UI.WinForm.Controls.NButton btnDiretorio;
        //private Nevron.UI.WinForm.Controls.NButton btnTestConectionWS;
        //private Nevron.UI.WinForm.Controls.NTextBox txtURLWs;
    }
}