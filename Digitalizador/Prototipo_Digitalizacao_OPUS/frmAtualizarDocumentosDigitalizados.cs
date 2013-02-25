using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using RImageScan;
using RImageScan.RTwainLib;
using System.Runtime.InteropServices;

using SIGPA.BO;
using SIGPA.INFO;
using SIGPA.Service;

namespace DigitalView
{
    public partial class frmAtualizarDocumentosDigitalizados : Form, IMessageFilter
    {

        //Scanner
        private Twain objTwain;
        private bool objMsgFilter;

        //
        BITMAPINFOHEADER bmi;
        Rectangle bmprect;
        IntPtr dibhand;
        IntPtr bmpptr;
        IntPtr pixptr;

        private static INFOCliente objCliente = null;


        public frmAtualizarDocumentosDigitalizados()
        {
            InitializeComponent();

            //Inicializando uma instancia do scanner
            objTwain = new Twain();
            objTwain.Init(this.Handle);

            //para Salvar
            bmprect = new Rectangle(0, 0, 0, 0);
        }

        //Disparo de Ações dos Controles de Formulário
        private void frmAtualizarDocumentosDigitalizados_Load(object sender, EventArgs e)
        {
            PrepararFormulario();
        }

        private void txtReferencia_KeyDown(object sender, KeyEventArgs e)
        {
            BODigitalizarDocumentos objDigitalizar = null;

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbTipoDocumento.SelectedIndex = 0;

                    if (string.IsNullOrEmpty(txtReferencia.Text))
                    {
                        MessageBox.Show("Por favor, digite uma referencia válida!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtReferencia.Focus();
                    }
                    else
                    {
                        objDigitalizar = new BODigitalizarDocumentos();
                        objCliente = objDigitalizar.boSincronizarBaseSIGPA(txtReferencia.Text);

                        if (objCliente != null)
                        {
                            lblCNPJCPF.Text = objCliente.NumeroCnpj;
                            lblNome.Text = objCliente.NomeCliente;
                            //grpDigitalizar.Enabled = true;
                            grpDocumentos.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Processo NÃO ESTÁ CADASTRADO no Sistema!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO : " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnExcluirDocumentos_Click(object sender, EventArgs e)
        {
            BOManterDocumentosDigitais objManterDocumentosDigitais = null;
            INFODocumentoDigital objInfoDocumentoDigitais = null;
            try
            {
                if (lstDocumentosDigitalisados.SelectedItems.Count > 0){

                    objManterDocumentosDigitais = new BOManterDocumentosDigitais();
                    
                    
                    for (int i = 0; i < lstDocumentosDigitalisados.SelectedItems.Count; i++)
			        {
                        objInfoDocumentoDigitais = new INFODocumentoDigital();
                        objInfoDocumentoDigitais.IdDocumentoDigital = (double)lstDocumentosDigitalisados.SelectedItems[i].Tag;
                        objInfoDocumentoDigitais.NomeArquivo = lstDocumentosDigitalisados.SelectedItems[i].SubItems[1].Text;
                        objInfoDocumentoDigitais.NomeDiretorioArquivo = lstDocumentosDigitalisados.SelectedItems[i].SubItems[2].Text;
			        }

                    if (objManterDocumentosDigitais.boExcluirDocumentosDigitais(objInfoDocumentoDigitais)){
                        PopularListView();
                        MessageBox.Show("Documento excluido com sucesso!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                 }
                 else{
                    MessageBox.Show("Por favor, Selecione um documento para excluir!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lstDocumentosDigitalisados.Focus();
                 }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO : " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoDocumento.SelectedItem != null && !String.IsNullOrEmpty(txtReferencia.Text))
            {

                CarregarComboDocumento();
                cmbDocumento.Enabled = true;
                lblPathDiretorio.Text = "";
                btnDigitalizar.Enabled = false;
            }
        }

        private void cmbDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            BODigitalizarDocumentos objBoDigitalizarDocumentos = null;
            string NomeArquivo;
            string NomeDir;
            try
            {

                //Dados cadastrais será montado acima da referência
                String nomePastaDadosCadastraisemParametros = System.Configuration.ConfigurationManager.AppSettings["NOMEPASTADADOSCADASTRAIS"].ToString();
                if (nomePastaDadosCadastraisemParametros.Equals(cmbTipoDocumento.Text) && cmbDocumento.SelectedItem != null)
                {
                    tabManutencao.SelectTab(1);
                    //Monto o diretório de dados cadastrais abaixo do cliente

                    // |----- + Nome Cliente Mapa 
                    //      |----- + Dados Cadastrais
                    //                  |------ + Identidade
                    //                  |------ + CPF
                    //                  |------ + Outros
                    //objBoDigitalizarDocumentos = new BODigitalizarDocumentos();

                    //objBoDigitalizarDocumentos.boMontarDiretorioDadosCadastrais(
                    //                                                         cmbTipoDocumento.Text,
                    //                                                         cmbDocumento.Text,
                    //                                                         objCliente,
                    //                                                         out NomeArquivo,
                    //                                                         out NomeDir);

                    //PopularListView();

                    //lblPathDiretorio.Text = NomeDir;
                    //btnDigitalizar.Enabled = true;


                }
                else if (!nomePastaDadosCadastraisemParametros.Equals(cmbTipoDocumento.Text) && cmbDocumento.Text != "")
                {
                    objBoDigitalizarDocumentos = new BODigitalizarDocumentos();

                    objBoDigitalizarDocumentos.boMontarNomeArquivoeDiretorio(txtReferencia.Text,
                                                                             cmbTipoDocumento.Text,
                                                                             cmbDocumento.Text,
                                                                             objCliente,
                                                                             out NomeArquivo,
                                                                             out NomeDir);

                  

                    PopularListView();

                    lblPathDiretorio.Text = NomeDir;
                    btnDigitalizar.Enabled = true;
                }
           


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO : " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Métodos privados
        public void PrepararFormulario()
        {
            BODigitalizarDocumentos objBoDigitalizar = null;
            List<INFOTipoDocumento> ListaInfoTipoDocumento = null;
            try
            {
                //Preparando o Formulário
                objBoDigitalizar = new BODigitalizarDocumentos();

                ListaInfoTipoDocumento = objBoDigitalizar.boObterListaTipoDocumento();

                if (ListaInfoTipoDocumento != null)
                {
                  

                    cmbTipoDocumento.DataSource = ListaInfoTipoDocumento;
                    cmbTipoDocumento.DisplayMember = "NomeTipoDocumento";
                    cmbTipoDocumento.ValueMember = "IdTipoDocumento";

                }
                else
                {
                    MessageBox.Show("Cadastre os Tipos de Documentos no Banco de Dados!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                popularComboCliente();
                popularComboDadosCadastrais();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO : " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CarregarComboDocumento()
        {
            BODigitalizarDocumentos objBoDigitalizar = null;
            List<INFODocumento> ListaInfoDocumento = null;

            try
            {

                cmbDocumento.DataSource = null;
                objBoDigitalizar = new BODigitalizarDocumentos();

                ListaInfoDocumento = objBoDigitalizar.boObterListaDocumento((double)cmbTipoDocumento.SelectedValue, txtReferencia.Text.Substring(0, 1).ToUpper());

                if (ListaInfoDocumento != null)
                {
                    cmbDocumento.DataSource = ListaInfoDocumento;
                    cmbDocumento.DisplayMember = "NomeDocumento";
                    cmbDocumento.ValueMember = "IdDocumentos";
                   
                }
                else
                {
                    MessageBox.Show("Cadastre os Documentos para este Tipo de Documento no Banco de Dados!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO : " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
        private void PopularListView()
        {
            ListViewItem lObjListViewItem = null;
            List<INFODocumentoDigital> ListaDocumentosDigitais = null;

            BOManterDocumentosDigitais objManterDocumentosDigitais = null;
            try
            {
                this.lstDocumentosDigitalisados.Items.Clear();

                objManterDocumentosDigitais = new BOManterDocumentosDigitais();
                ListaDocumentosDigitais = objManterDocumentosDigitais.boObterDocumentosDigitais(txtReferencia.Text,(double)((INFODocumento)(cmbDocumento.SelectedItem)).IdDocumentos );

                if (ListaDocumentosDigitais != null)
                {
                    //HABILITO OS BOTÕES de manutenção
                    btnExcluirDocumentos.Enabled = true;
                    btnVisualizar.Enabled = true;
                    btnDigitalizar.Enabled = true;

                    for (int i = 0; i < ListaDocumentosDigitais.Count; i++)
                    {
                        lObjListViewItem = new ListViewItem(string.Empty, 0);


                        lObjListViewItem.SubItems.Add(ListaDocumentosDigitais[i].NomeArquivo);
                        lObjListViewItem.SubItems.Add(ListaDocumentosDigitais[i].NomeDiretorioArquivo);


                        lObjListViewItem.Tag = ListaDocumentosDigitais[i].IdDocumentoDigital;

                        this.lstDocumentosDigitalisados.Items.AddRange(new ListViewItem[] { lObjListViewItem });
                    }
                }
                else
                {
                    //DESABILITO OS BOTÕES de manutenção
                    btnExcluirDocumentos.Enabled = false;
                    btnVisualizar.Enabled = false;
                    btnDigitalizar.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                lObjListViewItem = null;
            }
        }

        private void btnDigitalizar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            btnDigitalizar.Enabled = false;
            InitializeScan();
            objTwain.Acquire();
            //EndingScan();

        }

        private void AtualizarDigitralizacao() {
            BOManterDocumentosDigitais objManterDocumentosDigitais = null;
            INFODocumentoDigital objInfoDocumentoDigitais = null;
            string TempDirPdf = System.Configuration.ConfigurationSettings.AppSettings["DIRPDF"].ToString();
            try
            {
                if (lstDocumentosDigitalisados.SelectedItems.Count > 0)
                {

                    objManterDocumentosDigitais = new BOManterDocumentosDigitais();


                    for (int i = 0; i < lstDocumentosDigitalisados.SelectedItems.Count; i++)
                    {
                        objInfoDocumentoDigitais = new INFODocumentoDigital();
                        objInfoDocumentoDigitais.IdDocumentoDigital = (double)lstDocumentosDigitalisados.SelectedItems[i].Tag;
                        objInfoDocumentoDigitais.NomeArquivo = lstDocumentosDigitalisados.SelectedItems[i].SubItems[1].Text;
                        objInfoDocumentoDigitais.NomeDiretorioArquivo = lstDocumentosDigitalisados.SelectedItems[i].SubItems[2].Text;
                    }

                    if (objManterDocumentosDigitais.boAtualizarDocumentosDigitais(objInfoDocumentoDigitais, TempDirPdf))
                    {
                        PopularListView();
                        MessageBox.Show("Documento Alterado com sucesso!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, Selecione um documento para alterar!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lstDocumentosDigitalisados.Focus();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO : " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            INFODocumentoDigital objInfoDocumentoDigitais = null;

            if (lstDocumentosDigitalisados.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lstDocumentosDigitalisados.SelectedItems.Count; i++)
                {
                    objInfoDocumentoDigitais = new INFODocumentoDigital();
                    //objInfoDocumentoDigitais.IdDocumentoDigital = (double)lstDocumentosDigitalisados.SelectedItems[i].Tag;
                    objInfoDocumentoDigitais.NomeArquivo = lstDocumentosDigitalisados.SelectedItems[i].SubItems[1].Text;
                    objInfoDocumentoDigitais.NomeDiretorioArquivo = lstDocumentosDigitalisados.SelectedItems[i].SubItems[2].Text;
                }


                System.Diagnostics.Process objExplorer = new System.Diagnostics.Process();
                objExplorer.EnableRaisingEvents = false;
                objExplorer.StartInfo.FileName = System.Configuration.ConfigurationManager.
                        AppSettings.Get("LEITORPDF").ToString();//"AcroRd32.exe";
                objExplorer.StartInfo.Arguments = objInfoDocumentoDigitais.NomeDiretorioArquivo + objInfoDocumentoDigitais.NomeArquivo;
                objExplorer.Start();

                //System.Diagnostics.Process.Start(@"" + objInfoDocumentoDigitais.NomeDiretorioArquivo + objInfoDocumentoDigitais.NomeArquivo);
            }
            else {
                MessageBox.Show("Por favor, Selecione um documento para Visualizar!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
           
        }



        #region "ImessageFilter Lendo os eventos "
        bool IMessageFilter.PreFilterMessage(ref Message m)
        {
            IntPtr img;
            TwainCommand cmd;
            bool ReturnValue = false;
            string TempDirPdf = string.Empty;
            BODigitalizarDocumentos objBoDigitalizarDocumentos = null;
            try
            {
                cmd = objTwain.PassMessage(ref m);

                if (cmd == TwainCommand.Null )
                {
                    MessageBox.Show("Talvez o Scanner esteja DESLIGADO, DESPLUGADO ou DESCONECTADO, por favor verifique !!!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor.Current = Cursors.Default;
                    btnDigitalizar.Enabled = true;
                    EndingScan();
                    objTwain.CloseSrc();
                    return false;
                }

                if (cmd == TwainCommand.Not)

                    return false;

                switch (cmd)
                {
                    case TwainCommand.CloseRequest:
                        {
                            EndingScan();
                            objTwain.CloseSrc();
                            break;
                        }
                    case TwainCommand.CloseOk:
                        {
                            EndingScan();
                            objTwain.CloseSrc();
                            break;
                        }
                    case TwainCommand.DeviceEvent:
                        {
                            break;
                        }
                    case TwainCommand.TransferReady:
                        {
                            
                            ArrayList pics = objTwain.TransferPictures();
                            string FileNameTemp = string.Empty;
                            string DirTemp = string.Empty;
                            EndingScan();
                            objTwain.CloseSrc();

                            for (int i = 0; i < lstDocumentosDigitalisados.SelectedItems.Count; i++)
                            {
                                FileNameTemp = lstDocumentosDigitalisados.SelectedItems[i].SubItems[1].Text;
                                DirTemp = lstDocumentosDigitalisados.SelectedItems[i].SubItems[2].Text;
                            }

                            for (int i = 0; i < pics.Count; i++)
                            {
                                img = (IntPtr)pics[i];
                                RImageScan.GdiPlusLib.Gdip.SaveImage(i.ToString() +
                                                    System.Configuration.ConfigurationSettings.AppSettings["EXTIMG"].ToString().ToLower(),
                                                    GlobalLock(img), GetPixelInfo(GlobalLock(img)), FileNameTemp);
                                GdipDisposeImage(img);
                                GlobalFree(img);
                            }
                            //Generate the PDF file

                            if (pics.Count != 0)
                            {

                                if (MessageBox.Show("Você deseja realmente [ SALVAR ] o arquivo digitalizado?", "SALVAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    RImageScan.RImageToPdf objPDF = new RImageScan.RImageToPdf();
                                    objPDF.ExportToPDF(FileNameTemp, false);

                                    //Save file to System DataBase.
                                    AtualizarDigitralizacao();
                                    btnDigitalizar.Enabled = true;
                                }
                                else
                                {

                                    MessageBox.Show("Documento não foi gravado!!!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    btnDigitalizar.Enabled = true;

                                }
                            }
                            break;
                        }
                }
                ReturnValue = true;
                Cursor.Current = Cursors.Default ;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default ;
                btnDigitalizar.Enabled = true;
                EndingScan();
                MessageBox.Show("ERROR : " + ex.ToString());
            }

            return ReturnValue;
        }

        private void InitializeScan()
        {
            if (!objMsgFilter)
            {
                //this.Enabled = false;
                objMsgFilter = true;
                Application.AddMessageFilter(this);
            }
        }
        private void EndingScan()
        {
            if (objMsgFilter)
            {
                Application.RemoveMessageFilter(this);
                objMsgFilter = false;
                //this.Enabled = true;
                //this.Activate();
            }
        }

        #endregion

        //Captura Informações das imagens 
        protected IntPtr GetPixelInfo(IntPtr bmpptr)
        {
            bmi = new BITMAPINFOHEADER();
            Marshal.PtrToStructure(bmpptr, bmi);

            bmprect.X = bmprect.Y = 0;
            bmprect.Width = bmi.biWidth;
            bmprect.Height = bmi.biHeight;

            if (bmi.biSizeImage == 0)
                bmi.biSizeImage = ((((bmi.biWidth * bmi.biBitCount) + 31) & ~31) >> 3) * bmi.biHeight;

            int p = bmi.biClrUsed;
            if ((p == 0) && (bmi.biBitCount <= 8))
                p = 1 << bmi.biBitCount;
            p = (p * 4) + bmi.biSize + (int)bmpptr;
            return (IntPtr)p;
        }

        //APIS 
        [DllImport("gdi32.dll", ExactSpelling = true)]
        internal static extern int SetDIBitsToDevice(IntPtr hdc, int xdst, int ydst,
                                                int width, int height, int xsrc, int ysrc, int start, int lines,
                                                IntPtr bitsptr, IntPtr bmiptr, int color);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GlobalLock(IntPtr handle);
        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GlobalFree(IntPtr handle);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern void OutputDebugString(string outstr);

        //GDI
        [DllImport("gdiplus.dll", ExactSpelling = true)]
        internal static extern int GdipDisposeImage(IntPtr image);

      

        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        


        private void popularComboCliente() {
            BOManterCliente boCliente = null;

            List<INFOCliente> listaCliente = null;

            try
            {
                boCliente = new BOManterCliente();

                cmbCliente.DataSource = null;
                boCliente = new BOManterCliente();

                listaCliente = boCliente.obterClientes();


                if (listaCliente != null)
                {
                    cmbCliente.DataSource = listaCliente;
                    cmbCliente.DisplayMember = "NomeClienteMapa";
                    cmbCliente.ValueMember = "IdCliente";

                }

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }


        /// <summary>
        /// Popula a combo de dados Cadastrais
        /// </summary>
        private void popularComboDadosCadastrais()
        {
            BODigitalizarDocumentos bo = null;

            List<INFODocumento> listaDocumentos = null;

            try
            {
                bo = new BODigitalizarDocumentos();
                comboDocumentoDadosCadastrais.DataSource = null;
                listaDocumentos = bo.obterDocumentosDadosCadastrais(3.0);


                if (listaDocumentos != null)
                {
                    comboDocumentoDadosCadastrais.DataSource = listaDocumentos;
                    comboDocumentoDadosCadastrais.DisplayMember = "NomeDocumento";
                    comboDocumentoDadosCadastrais.ValueMember = "IdDocumentos";

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Popula o listView com as informações de dados Cadastrais
        /// </summary>
        private void PopularListViewDadosCadastrais()
        {
            ListViewItem lObjListViewItem = null;
            List<INFODadosCadastrais> listadadosCadastrais = null;

            BOManterDocumentosDigitais objManterDocumentosDigitais = null;
            try
            {
                this.lstDocumentosDigitalisados.Items.Clear();

                objManterDocumentosDigitais = new BOManterDocumentosDigitais();
                
                listadadosCadastrais = objManterDocumentosDigitais.obterDocumentosDadosCadastraisDigitalizados(
                                        (double)((INFOCliente)cmbCliente.SelectedItem).IdCliente,
                                        (double)((INFODocumento)comboDocumentoDadosCadastrais.SelectedItem).IdDocumentos);

                if (listadadosCadastrais != null)
                {
                    //HABILITO OS BOTÕES de manutenção
                    btnExcluirDocumentosCadastrais.Enabled = true;
                    btnVisualizarDocumentosCadastrais.Enabled = true;
                   

                    for (int i = 0; i < listadadosCadastrais.Count; i++)
                    {
                        lObjListViewItem = new ListViewItem(string.Empty, 0);


                        lObjListViewItem.SubItems.Add(listadadosCadastrais[i].Nome_arquivo);
                        lObjListViewItem.SubItems.Add(listadadosCadastrais[i].Nome_diretorio_arquivo);


                        lObjListViewItem.Tag = listadadosCadastrais[i].Id_dadoscadastrais;

                        this.lstDocumentosDigitalisados.Items.AddRange(new ListViewItem[] { lObjListViewItem });
                    }
                }
                else
                {
                    //DESABILITO OS BOTÕES de manutenção
                    btnExcluirDocumentosCadastrais.Enabled = false;
                    btnVisualizarDocumentosCadastrais.Enabled = false;
                    //MessageBox.Show("Este documento ainda não foi digitalizado!", 
                    //    Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                lObjListViewItem = null;
            }
        }

        /// <summary>
        /// Consulta os Dados Cadastrais e coloca na grid
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            PopularListViewDadosCadastrais();
        }

       


        private void limparListView(){
            this.lstDocumentosDigitalisados.Items.Clear();
        }

       

        private void tabManutencao_SelectedIndexChanged(object sender, EventArgs e)
        {
                limparListView();
        }


        /// <summary>
        /// Ação do Botão excluir dadosCadastrais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluirDocumentosCadastrais_Click(object sender, EventArgs e)
        {
            BOManterDocumentosDigitais objManterDocumentosDigitais = null;
            INFODadosCadastrais infodadoscadastrais = null;
            try
            {
                if (lstDocumentosDigitalisados.SelectedItems.Count > 0)
                {

                    objManterDocumentosDigitais = new BOManterDocumentosDigitais();


                    for (int i = 0; i < lstDocumentosDigitalisados.SelectedItems.Count; i++)
                    {
                        infodadoscadastrais = new INFODadosCadastrais();
                        infodadoscadastrais.Id_dadoscadastrais = (int)lstDocumentosDigitalisados.SelectedItems[i].Tag;
                        infodadoscadastrais.Nome_arquivo = lstDocumentosDigitalisados.SelectedItems[i].SubItems[1].Text;
                        infodadoscadastrais.Nome_diretorio_arquivo = lstDocumentosDigitalisados.SelectedItems[i].SubItems[2].Text;
                    }

                    if (objManterDocumentosDigitais.boExcluirDadosCadastrais(infodadoscadastrais))
                    {
                        PopularListViewDadosCadastrais();
                        MessageBox.Show("Documento excluido com sucesso!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, Selecione um documento para excluir!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lstDocumentosDigitalisados.Focus();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO : " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

  
}
