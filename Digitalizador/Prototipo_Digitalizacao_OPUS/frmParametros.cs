using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIGPA.BO;
using SIGPA.INFO;
using SIGPA.Service;

namespace DigitalView
{
    
    public partial class frmParametros : Form
    {
        private Log gObjLog = null;

        public frmParametros()
        {
            InitializeComponent();
            gObjLog = new Log("MANTER PARAMETROS");
            gObjLog.FormatoArquivo = FormatoArquivoLog.NOME_DDMMAAAA;
            gObjLog.FormatoDiretorio = FormatoDiretorioLog.MES_ANO;
        }

        private void btnDiretorio_Click(object sender, EventArgs e)
        {

             FolderBrowserDialog open = null;
             DialogResult Result;
             try
             {

                 open = new FolderBrowserDialog();

                 open.ShowNewFolderButton = false;
                 Result = open.ShowDialog();

                 if (Result == System.Windows.Forms.DialogResult.OK)
                 {
                     txtDiretorio.Text = open.SelectedPath;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             finally
             {
                 if (open != null)
                 {
                     open.Dispose();
                 }
                 open = null;
             }
           
        }

        private void frmParametros_Load(object sender, EventArgs e)
        {
            BOManterParametros objManterParametros = null;
            INFOParametros objParametros = null;
            try
            {
                objManterParametros = new BOManterParametros();
                objParametros = objManterParametros.boObterParametros();

                if (objParametros != null)
                {
                    txtDiretorio.Text = objParametros.NomeDiretorioDocumentos;
                    lblNuDocDigital.Text = objParametros.NumeroContador.ToString();
                }
                txtURLWs.Text = System.Configuration.ConfigurationManager.AppSettings["URLWSSIGPA"].ToString();
            }
            catch (Exception ex)
            {
                gObjLog.Inserir("Erro: " + ex.ToString(), TipoLog.ERRO);
                MessageBox.Show("ERRO: "+ ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            BOManterParametros objBoParametros = null;
            INFOParametros objInfoParametros = null;
            try
            {
                if (string.IsNullOrEmpty(txtDiretorio.Text))
                {
                    MessageBox.Show("Por favor, o campo diretório não pode ser vazio!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiretorio.Focus();
                }
                else {
                    objBoParametros = new BOManterParametros();
                    objInfoParametros = new INFOParametros();

                    objInfoParametros.NomeDiretorioDocumentos = txtDiretorio.Text;

                    if (objBoParametros.boAtualizarParametros(objInfoParametros))
                    {
                        MessageBox.Show("Parâmetros Alterados com sucesso!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                gObjLog.Inserir("Erro: " + ex.ToString(), TipoLog.ERRO);
                MessageBox.Show("ERRO: "+ ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTestConectionWS_Click(object sender, EventArgs e)
        {
            if (SIGPA.Service.Ultil.verifyWebService())
            {
                MessageBox.Show("WEBSERVICE ESTÁ ONLINE !!!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("WEBSERVICE ESTÁ OFFLINE !!!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
