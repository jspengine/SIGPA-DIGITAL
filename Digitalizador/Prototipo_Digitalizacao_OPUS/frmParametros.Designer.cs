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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtURLWs = new System.Windows.Forms.TextBox();
            this.btnTestConectionWS = new System.Windows.Forms.Button();
            this.btnDiretorio = new System.Windows.Forms.Button();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.lblNuDocDigital = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCPForCNPJ = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpVisualizador.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVisualizador
            // 
            this.grpVisualizador.Controls.Add(this.btnAtualizar);
            this.grpVisualizador.Controls.Add(this.panel1);
            this.grpVisualizador.Controls.Add(this.btnSair);
            this.grpVisualizador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVisualizador.Location = new System.Drawing.Point(0, 0);
            this.grpVisualizador.Name = "grpVisualizador";
            this.grpVisualizador.Size = new System.Drawing.Size(848, 309);
            this.grpVisualizador.TabIndex = 1;
            this.grpVisualizador.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(456, 241);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(185, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "&Atualizar Parâmetros";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "URL do WebService de Integração  SIGPA.";
            // 
            // txtURLWs
            // 
            this.txtURLWs.Location = new System.Drawing.Point(21, 130);
            this.txtURLWs.Name = "txtURLWs";
            this.txtURLWs.Size = new System.Drawing.Size(685, 20);
            this.txtURLWs.TabIndex = 12;
            // 
            // btnTestConectionWS
            // 
            this.btnTestConectionWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConectionWS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestConectionWS.Location = new System.Drawing.Point(712, 130);
            this.btnTestConectionWS.Name = "btnTestConectionWS";
            this.btnTestConectionWS.Size = new System.Drawing.Size(105, 24);
            this.btnTestConectionWS.TabIndex = 9;
            this.btnTestConectionWS.Text = "Testar Conexão";
            this.btnTestConectionWS.Click += new System.EventHandler(this.btnTestConectionWS_Click);
            // 
            // btnDiretorio
            // 
            this.btnDiretorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiretorio.Image = ((System.Drawing.Image)(resources.GetObject("btnDiretorio.Image")));
            this.btnDiretorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiretorio.Location = new System.Drawing.Point(735, 24);
            this.btnDiretorio.Name = "btnDiretorio";
            this.btnDiretorio.Size = new System.Drawing.Size(82, 23);
            this.btnDiretorio.TabIndex = 9;
            this.btnDiretorio.Text = "...";
            this.btnDiretorio.Click += new System.EventHandler(this.btnDiretorio_Click);
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(178, 27);
            this.txtDiretorio.MaxLength = 300;
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(551, 20);
            this.txtDiretorio.TabIndex = 6;
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Diretório de Digitalização:";
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
            // lblCPForCNPJ
            // 
            this.lblCPForCNPJ.AutoSize = true;
            this.lblCPForCNPJ.Location = new System.Drawing.Point(18, 72);
            this.lblCPForCNPJ.Name = "lblCPForCNPJ";
            this.lblCPForCNPJ.Size = new System.Drawing.Size(222, 13);
            this.lblCPForCNPJ.TabIndex = 3;
            this.lblCPForCNPJ.Text = "Número de Documentos Digitalizados:";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(647, 241);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(185, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 309);
            this.Controls.Add(this.grpVisualizador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmParametros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parâmetros";
            this.Load += new System.EventHandler(this.frmParametros_Load);
            this.grpVisualizador.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private Nevron.UI.WinForm.Controls.NGrouper grpVisualizador;
        //private Nevron.UI.WinForm.Controls.NButton btnSair;


        private System.Windows.Forms.GroupBox grpVisualizador;
        private System.Windows.Forms.Button btnSair;


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCPForCNPJ;
        //private Nevron.UI.WinForm.Controls.NButton btnAtualizar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblNuDocDigital;
        //private Nevron.UI.WinForm.Controls.NTextBox txtDiretorio;
        //private Nevron.UI.WinForm.Controls.NButton btnDiretorio;
        //private Nevron.UI.WinForm.Controls.NButton btnTestConectionWS;

        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Button btnDiretorio;
        private System.Windows.Forms.Button btnTestConectionWS;


        private System.Windows.Forms.Label label2;
        //private Nevron.UI.WinForm.Controls.NTextBox txtURLWs;
        private System.Windows.Forms.TextBox txtURLWs;
    }
}