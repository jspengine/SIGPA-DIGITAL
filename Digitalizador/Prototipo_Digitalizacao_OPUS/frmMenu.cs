using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using SIGPA.Service;

namespace DigitalView
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void lnkSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sair();
        }

        private void Sair()
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void MostrarFrmDigitalizarDocumentos()
        {

            frmDigitalizarDocumentos frm = new frmDigitalizarDocumentos();
            try
            {
                frm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro tratado aconteceu: " + ex.ToString(), "SIGPA - DIGITALIZADOR", MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
            finally {
                frm.Dispose();
                frm = null;
            }
            
        }

        private void MostrarFrmParametros()
        {

            frmParametros frm = new frmParametros();
            try
            {
                frm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro tratado aconteceu: " + ex.ToString(), "SIGPA - DIGITALIZADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frm.Dispose();
                frm = null;
            }

        }

        private void mostrarFrmManutencao() {
            frmAtualizarDocumentosDigitalizados frm = new frmAtualizarDocumentosDigitalizados();
            try
            {
                frm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro tratado aconteceu: " + ex.ToString(), "SIGPA - DIGITALIZADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frm.Dispose();
                frm = null;
            }
        }

        private void mostrarFrmTipoDocumento()
        {
            frmTipoDocumento frm = new frmTipoDocumento();
            try
            {
                frm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro tratado aconteceu: " + ex.ToString(), "SIGPA - DIGITALIZADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frm.Dispose();
                frm = null;
            }
        }

        private void mostrarFrmDocumento()
        {
            frmCadastrarDocumentos frm = new frmCadastrarDocumentos();
            try
            {
                frm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro tratado aconteceu: " + ex.ToString(), "SIGPA - DIGITALIZADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frm.Dispose();
                frm = null;
            }
        }

        


        private void lnkDigitalizarDocumentos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFrmDigitalizarDocumentos();
        }

        private void mnuDigitalizarDocumentos_Click(object sender, EventArgs e)
        {
            MostrarFrmDigitalizarDocumentos();
        }

        private void lnkParametros_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFrmParametros();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //Nevron.UI.WinForm.Controls.NStatusBarPanel objPanelUsuario = null;
            //Nevron.UI.WinForm.Controls.NStatusBarPanel objPanelVersao = null;


            System.Windows.Forms.StatusBarPanel objPanelUsuario = null;
            System.Windows.Forms.StatusBarPanel objPanelVersao = null;

            try
            {
                objPanelUsuario = new  System.Windows.Forms.StatusBarPanel() ;
                objPanelVersao = new  System.Windows.Forms.StatusBarPanel ();

                this.Text = Global.CODAPP + " - " + Global.DESCRICAOAPP;

                objPanelUsuario.Text = String.Format(" Usuário: {0}", Global.USER);
                objPanelUsuario.Width = 400;
                this.statusBar.Panels.Add(objPanelUsuario);

                objPanelVersao.Text = String.Format(" Versão: {0}", AssemblyVersion);
                objPanelVersao.Width = 250;
                this.statusBar.Panels.Add(objPanelVersao);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void parâmetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFrmParametros();
        }

        private void lnkAtualizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mostrarFrmManutencao();
        }

        private void mnuManutencaoDoc_Click(object sender, EventArgs e)
        {
            mostrarFrmManutencao();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarSobre();

        }

        private void mostrarSobre(){
            frmSobre frm = new frmSobre();

            frm.ShowDialog();
        }

        private void lnkSobre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mostrarSobre();
        }

        private void lnkDigitalizarV2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmManterTiposDocumentos().Show(this);

            
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //mostrarFrmTipoDocumento();

            mostrarFrmDocumento();
        }
       

    }
}
