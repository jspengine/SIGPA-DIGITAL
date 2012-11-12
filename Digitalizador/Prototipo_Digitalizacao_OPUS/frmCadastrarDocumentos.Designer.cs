namespace DigitalView
{
    partial class frmCadastrarDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarDocumentos));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstDocumento = new System.Windows.Forms.ListView();
            this.coId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosicao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDocumento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipoProcesso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpVisualizador = new System.Windows.Forms.GroupBox();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nupPosicao = new System.Windows.Forms.NumericUpDown();
            this.btnCadastrarTipoDocumentos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoProcesso = new System.Windows.Forms.ComboBox();
            this.lblTipoProcesso = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.txtNomeDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpVisualizador.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPosicao)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lstDocumento, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grpVisualizador, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlTitle, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 486);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lstDocumento
            // 
            this.lstDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDocumento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coId,
            this.colPosicao,
            this.colDocumento,
            this.colTipoProcesso});
            this.lstDocumento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lstDocumento.FullRowSelect = true;
            this.lstDocumento.GridLines = true;
            this.lstDocumento.Location = new System.Drawing.Point(4, 324);
            this.lstDocumento.MultiSelect = false;
            this.lstDocumento.Name = "lstDocumento";
            this.lstDocumento.Size = new System.Drawing.Size(764, 158);
            this.lstDocumento.TabIndex = 18;
            this.lstDocumento.UseCompatibleStateImageBehavior = false;
            this.lstDocumento.View = System.Windows.Forms.View.Details;
            // 
            // coId
            // 
            this.coId.DisplayIndex = 1;
            this.coId.Text = "ID";
            this.coId.Width = 1;
            // 
            // colPosicao
            // 
            this.colPosicao.DisplayIndex = 0;
            this.colPosicao.Text = "Posicionamento";
            this.colPosicao.Width = 100;
            // 
            // colDocumento
            // 
            this.colDocumento.Text = "Documento";
            this.colDocumento.Width = 451;
            // 
            // colTipoProcesso
            // 
            this.colTipoProcesso.Text = "Tipo Processo";
            this.colTipoProcesso.Width = 210;
            // 
            // grpVisualizador
            // 
            this.grpVisualizador.BackColor = System.Drawing.Color.Transparent;
            this.grpVisualizador.Controls.Add(this.btnNovoCadastro);
            this.grpVisualizador.Controls.Add(this.btnAtualizar);
            this.grpVisualizador.Controls.Add(this.btnCadastrar);
            this.grpVisualizador.Controls.Add(this.panel1);
            this.grpVisualizador.Controls.Add(this.btnSair);
            this.grpVisualizador.Location = new System.Drawing.Point(4, 55);
            this.grpVisualizador.Name = "grpVisualizador";
            this.grpVisualizador.Size = new System.Drawing.Size(764, 262);
            this.grpVisualizador.TabIndex = 1;
            this.grpVisualizador.TabStop = false;
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovoCadastro.BackgroundImage")));
            this.btnNovoCadastro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCadastro.ForeColor = System.Drawing.Color.White;
            this.btnNovoCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoCadastro.Image")));
            this.btnNovoCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCadastro.Location = new System.Drawing.Point(567, 19);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(185, 38);
            this.btnNovoCadastro.TabIndex = 10;
            this.btnNovoCadastro.Text = "&Novo Cadastro";
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(567, 151);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(185, 38);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "&Atualizar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.BackgroundImage")));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(567, 85);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(185, 38);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.nupPosicao);
            this.panel1.Controls.Add(this.btnCadastrarTipoDocumentos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbTipoProcesso);
            this.panel1.Controls.Add(this.lblTipoProcesso);
            this.panel1.Controls.Add(this.cmbTipoDocumento);
            this.panel1.Controls.Add(this.lblTipoDocumento);
            this.panel1.Controls.Add(this.txtNomeDocumento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 237);
            this.panel1.TabIndex = 7;
            // 
            // nupPosicao
            // 
            this.nupPosicao.Location = new System.Drawing.Point(21, 205);
            this.nupPosicao.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupPosicao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPosicao.Name = "nupPosicao";
            this.nupPosicao.Size = new System.Drawing.Size(120, 20);
            this.nupPosicao.TabIndex = 21;
            this.nupPosicao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCadastrarTipoDocumentos
            // 
            this.btnCadastrarTipoDocumentos.BackgroundImage = global::DigitalView.Properties.Resources.backgroundTitle;
            this.btnCadastrarTipoDocumentos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarTipoDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarTipoDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarTipoDocumentos.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarTipoDocumentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarTipoDocumentos.Location = new System.Drawing.Point(334, 9);
            this.btnCadastrarTipoDocumentos.Name = "btnCadastrarTipoDocumentos";
            this.btnCadastrarTipoDocumentos.Size = new System.Drawing.Size(196, 38);
            this.btnCadastrarTipoDocumentos.TabIndex = 11;
            this.btnCadastrarTipoDocumentos.Text = "Cadastrar Tipos de Documentos";
            this.btnCadastrarTipoDocumentos.Click += new System.EventHandler(this.btnCadastrarTipoDocumentos_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Posição :";
            // 
            // cmbTipoProcesso
            // 
            this.cmbTipoProcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProcesso.FormattingEnabled = true;
            this.cmbTipoProcesso.Location = new System.Drawing.Point(20, 89);
            this.cmbTipoProcesso.Name = "cmbTipoProcesso";
            this.cmbTipoProcesso.Size = new System.Drawing.Size(304, 21);
            this.cmbTipoProcesso.TabIndex = 17;
            this.cmbTipoProcesso.Visible = false;
            this.cmbTipoProcesso.SelectedIndexChanged += new System.EventHandler(this.cmbTipoProcesso_SelectedIndexChanged);
            // 
            // lblTipoProcesso
            // 
            this.lblTipoProcesso.Location = new System.Drawing.Point(16, 66);
            this.lblTipoProcesso.Name = "lblTipoProcesso";
            this.lblTipoProcesso.Size = new System.Drawing.Size(308, 23);
            this.lblTipoProcesso.TabIndex = 16;
            this.lblTipoProcesso.Text = "Para que tipo de Processo (A, M, E ou R):";
            this.lblTipoProcesso.Visible = false;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(21, 28);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(304, 21);
            this.cmbTipoDocumento.TabIndex = 14;
            this.cmbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedIndexChanged);
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(18, 12);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(126, 13);
            this.lblTipoDocumento.TabIndex = 13;
            this.lblTipoDocumento.Text = "Tipo de documentos:";
            // 
            // txtNomeDocumento
            // 
            this.txtNomeDocumento.Location = new System.Drawing.Point(20, 150);
            this.txtNomeDocumento.MaxLength = 300;
            this.txtNomeDocumento.Name = "txtNomeDocumento";
            this.txtNomeDocumento.Size = new System.Drawing.Size(506, 20);
            this.txtNomeDocumento.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome dos Documento:";
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(567, 217);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(185, 38);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitle.BackgroundImage")));
            this.pnlTitle.Controls.Add(this.tableLayoutPanel2);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Controls.Add(this.label3);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(4, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(764, 44);
            this.pnlTitle.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.iconFechar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.iconMinimizar, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(644, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(119, 42);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // iconFechar
            // 
            this.iconFechar.BackColor = System.Drawing.Color.Transparent;
            this.iconFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconFechar.Image = global::DigitalView.Properties.Resources.ni0073_32;
            this.iconFechar.Location = new System.Drawing.Point(62, 3);
            this.iconFechar.Name = "iconFechar";
            this.iconFechar.Size = new System.Drawing.Size(54, 36);
            this.iconFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconFechar.TabIndex = 5;
            this.iconFechar.TabStop = false;
            this.iconFechar.Click += new System.EventHandler(this.iconFechar_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconMinimizar.Image = global::DigitalView.Properties.Resources.ni0067_32;
            this.iconMinimizar.Location = new System.Drawing.Point(3, 3);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(53, 36);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconMinimizar.TabIndex = 4;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DigitalView.Properties.Resources.pdf;
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.label3.Size = new System.Drawing.Size(326, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cadastrar Documentos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCadastrarDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DigitalView.Properties.Resources.background_main;
            this.ClientSize = new System.Drawing.Size(772, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastrarDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarDocumentos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpVisualizador.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPosicao)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lstDocumento;
        private System.Windows.Forms.ColumnHeader coId;
        private System.Windows.Forms.ColumnHeader colPosicao;
        private System.Windows.Forms.GroupBox grpVisualizador;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.TextBox txtNomeDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrarTipoDocumentos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoProcesso;
        private System.Windows.Forms.Label lblTipoProcesso;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.NumericUpDown nupPosicao;
        private System.Windows.Forms.ColumnHeader colDocumento;
        private System.Windows.Forms.ColumnHeader colTipoProcesso;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
    }
}