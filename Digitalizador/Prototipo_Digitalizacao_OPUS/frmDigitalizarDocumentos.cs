using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIGPA.BO;
using SIGPA.INFO;
using SIGPA.Service;
using RImageScan;
using RImageScan.RTwainLib;
using System.Runtime.InteropServices;

namespace DigitalView
{  
    public partial class frmDigitalizarDocumentos : Form, IMessageFilter 
    {
        //Variáveis de Classe
     
        //Scanner
        private Twain objTwain;
        private bool objMsgFilter;

        //
        BITMAPINFOHEADER bmi;
        Rectangle bmprect;
        //IntPtr dibhand;
        //IntPtr bmpptr;
        //IntPtr pixptr;

        //Log Variables
        private Log gObjLog = null;
        
        private static INFOCliente objCliente ;

        public frmDigitalizarDocumentos()
        {
            InitializeComponent();
            //Inicializando uma instancia do scanner
            objTwain = new Twain();
            objTwain.Init(this.Handle);

            //para Salvar
            bmprect = new Rectangle(0, 0, 0, 0);

            gObjLog = new Log("DIGITALIZAR DOCUMENTOS");
            gObjLog.FormatoArquivo = FormatoArquivoLog.NOME_DDMMAAAA;
            gObjLog.FormatoDiretorio = FormatoDiretorioLog.MES_ANO;
        }

       

        private void txtReferencia_KeyDown(object sender, KeyEventArgs e)
        {
            BODigitalizarDocumentos objDigitalizar = null;

            try
            {
                Cursor = Cursors.WaitCursor;

                if (e.KeyCode == Keys.Enter)
                {
                    cmbTipoDocumento.SelectedIndex = -1;

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
                            grpDocumentos.Enabled = true;
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
            finally {
                Cursor = Cursors.Default;
            }
            
        }


        private void montaArvoreDiretorio() { 
            
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDigitalizarDocumentos_Load(object sender, EventArgs e)
        {
            PrepararFormulario();
        }

        public void PrepararFormulario() {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO : " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoDocumento.SelectedIndex > 0)
            {
                cmbDocumento.Items.Clear();
                CarregarComboDocumento();
                cmbDocumento.Enabled = true;

                //Dados cadastrais será montado acima da referência
                if ("1".Equals(cmbTipoDocumento.SelectedValue)) { 
                    //Monto o diretório de dados cadastrais abaixo do cliente

                    // + Nome Cliente
                    // |----- + Dados Cadastrais
                    // |----- + Processos Importacao
                    //          |------ + CI
                    //          |------ + LI
                    //          |------ + DI
                    //          |------ + LI
                    // |----- + Processos Exportacao
                    //          |------ + RE
                    //          |------ + DDE
                    //          |------ + AWB

                }

            }
            else {
                cmbDocumento.SelectedIndex = -1;
                cmbDocumento.Enabled = true;
            }
        }

        private void CarregarComboDocumento(){
            BODigitalizarDocumentos objBoDigitalizar = null;
            List<INFODocumento> ListaInfoDocumento = null;

            try
            {
                objBoDigitalizar = new BODigitalizarDocumentos();

                ListaInfoDocumento = objBoDigitalizar.boObterListaDocumento((double)(cmbTipoDocumento.SelectedValue), txtReferencia.Text.Substring(0,1).ToUpper());

                if (ListaInfoDocumento != null)
                {

                    cmbDocumento.DataSource = ListaInfoDocumento;
                    cmbDocumento.DisplayMember = "NomeDocumento";
                    cmbDocumento.ValueMember = "IdDocumentos";

                    //cmbDocumento.Items.Insert(0, "SELECIONE ...");
                    //for (int i = 0; i < ListaInfoDocumento.Count; i++)
                    //{
                    //    cmbDocumento.Items.Add(new ComboCustom(ListaInfoDocumento[i].IdDocumentos, ListaInfoDocumento[i].NomeDocumento));
                    //}
                    //cmbDocumento.SelectedIndex = 0;
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

        private void cmbDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            BODigitalizarDocumentos objBoDigitalizarDocumentos = null;
            string NomeArquivo;
            string NomeDir;
            try
            {
                if (cmbDocumento.SelectedIndex > 0)
                {
                    objBoDigitalizarDocumentos = new BODigitalizarDocumentos();

                    objBoDigitalizarDocumentos.boMontarNomeArquivoeDiretorio(txtReferencia.Text,
                                                                             cmbTipoDocumento.Text,
                                                                             cmbDocumento.Text,
                                                                             objCliente,
                                                                             out NomeArquivo,
                                                                             out NomeDir);

                    lblNomeArquivo.Text = NomeArquivo;
                    lblPathDiretorio.Text = NomeDir;
                    btnDigitalizar.Enabled = true;
                }
                else {
                    lblNomeArquivo.Text = string.Empty;
                    lblPathDiretorio.Text = string.Empty;
                    btnDigitalizar.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO : " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }

        }



        private void btnDigitalizar_Click(object sender, EventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                btnDigitalizar.Enabled = false;
                InitializeScan();
                objTwain.Acquire();
                //EndingScan();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO : " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
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
            gObjLog.Inserir("Lendo eventos de Imessage Filter --> " + m.ToString (), TipoLog.AVISO );
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
                            TempDirPdf = System.Configuration.ConfigurationSettings.AppSettings["DIRPDF"].ToString();
                            ArrayList pics = objTwain.TransferPictures();
                            
                            EndingScan();
                            objTwain.CloseSrc();

                            for (int i = 0; i < pics.Count; i++)
                            {
                                img = (IntPtr)pics[i];
                                RImageScan.GdiPlusLib.Gdip.SaveImage(i.ToString() +
                                                    System.Configuration.ConfigurationSettings.AppSettings["EXTIMG"].ToString().ToLower(),
                                                    GlobalLock(img), GetPixelInfo(GlobalLock(img)),lblNomeArquivo.Text);
                                GdipDisposeImage(img);
                                GlobalFree(img);
                            }
                            //Generate the PDF file
                            gObjLog.Inserir("Escaneou as imagens para o diretório temporario ", TipoLog.AVISO);

                            if (pics.Count != 0)
                            {
                                RImageScan.RImageToPdf objPDF = new RImageScan.RImageToPdf();
                                objPDF.ExportToPDF(lblNomeArquivo.Text, chkVisualizacao.Checked );
                                gObjLog.Inserir("Escaneou as imagens para o diretório temporario ", TipoLog.AVISO);

                                //Save file to System DataBase.

                                objBoDigitalizarDocumentos = new BODigitalizarDocumentos();

                                gObjLog.Inserir("Salvando os Informações no banco de dados.", TipoLog.AVISO);

                                if (objBoDigitalizarDocumentos.boDigitalizarDocumentos(TempDirPdf + lblNomeArquivo.Text,
                                                                                    lblPathDiretorio.Text,
                                                                                    lblNomeArquivo.Text,
                                                                                    (double)cmbDocumento.SelectedValue,
                                                                                    objCliente.ObjProcesso[0].IdProcesso))
                                {
                                    MessageBox.Show("Documento Digitalizado com SUCESSO!!!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    btnDigitalizar.Enabled = true;
                                    gObjLog.Inserir("Documento foi digitalizado com sucesso!!!.", TipoLog.AVISO);
                                }
                               
                            }
                            break;
                        }
                }
                ReturnValue = true;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                gObjLog.Inserir("ERROR: " + ex.ToString (), TipoLog.ERRO );
                Cursor.Current = Cursors.Default ;
                btnDigitalizar.Enabled = true;
                EndingScan();
                MessageBox.Show("ERROR : " + ex.ToString());
            }

            return ReturnValue;
        }

        private void InitializeScan() {
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

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



       
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    internal class BITMAPINFOHEADER
    {
        public int biSize;
        public int biWidth;
        public int biHeight;
        public short biPlanes;
        public short biBitCount;
        public int biCompression;
        public int biSizeImage;
        public int biXPelsPerMeter;
        public int biYPelsPerMeter;
        public int biClrUsed;
        public int biClrImportant;
    }
}
