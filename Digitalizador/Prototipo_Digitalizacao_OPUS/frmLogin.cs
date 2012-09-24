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
    public partial class frmLogin : Form
    {
        private Log gObjLog = null;

        public frmLogin()
        {
            InitializeComponent();
            gObjLog = new Log("LOGAR NO SISTEMA");
            gObjLog.FormatoArquivo = FormatoArquivoLog.NOME_DDMMAAAA;
            gObjLog.FormatoDiretorio = FormatoDiretorioLog.MES_ANO ;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }

        private void RealizarLogin() {
            BORealizarLogin objBoRealizarLogin = null;
            try
            {
                Cursor = Cursors.WaitCursor;
                btnEntrar.Enabled = false;
                if (txtLogin.Text.Equals("") || txtSenha.Text.Equals(""))
                {
                    MessageBox.Show("Por favor, verifique se o login e senha estão corretos!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLogin.Focus();
                    txtSenha.Text = string.Empty;
                }
                else
                {
                    objBoRealizarLogin = new BORealizarLogin();

                    if (objBoRealizarLogin.boRealizarLogin(txtLogin.Text.Replace ("'", "''"), txtSenha.Text.Replace ("'", "''")) != null)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Você não está habilitado a entrar no sistema!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtLogin.Focus();
                        txtSenha.Text = string.Empty;
                    }

                }
                Cursor = Cursors.Default;
                btnEntrar.Enabled = true;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                btnEntrar.Enabled = true;

                gObjLog.Inserir(" Erro: " + ex.ToString(), TipoLog.ERRO);
                MessageBox.Show("ERRO: " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (SIGPA.Service.Ultil.verifyWebService())
            {
                RealizarLogin();
            }
            else{
                MessageBox.Show(" Talvez o WEBSERVICE esteja OFF LINE, por favor conctate o adminsitrador do sistema ", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (SIGPA.Service.Ultil.verifyWebService())
                {
                    RealizarLogin();
                }
                else
                {
                    MessageBox.Show(" Talvez o WEBSERVICE esteja OFF LINE, por favor conctate o adminsitrador do sistema ", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
