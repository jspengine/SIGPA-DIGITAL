using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIGPA.INFO;
using SIGPA.BO;
using SIGPA.Service;

namespace DigitalView
{
    public partial class frmCadastrarDocumentos : Form
    {
        public frmCadastrarDocumentos()
        {
            InitializeComponent();
            prepararForm();

        }

        private void prepararForm()
        {
            try
            {
                carregarComboTipoDocumento();
                carregarComboCategoriaProcesso();
                carregarListView();
                habilitarCadastro();

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO : " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregarComboTipoDocumento()
        {

            BODigitalizarDocumentos objBoDigitalizar = null;
            List<INFOTipoDocumento> ListaInfoTipoDocumento = null;
            try
            {

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

        private void btnCadastrarTipoDocumentos_Click(object sender, EventArgs e)
        {
            frmTipoDocumento frm = new frmTipoDocumento();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cmbTipoDocumento.Refresh();
                
            }
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            

            this.WindowState = FormWindowState.Minimized;
        }


        private void carregarListView()
        {
            BoManterCadastroDocumentos bo = null;
            List<INFODocumento> listaDocumento = null;
            ListViewItem listViewItem = null;

            try
            {
                lstDocumento.Items.Clear();
                bo = new BoManterCadastroDocumentos();


                String parProcessos = System.Configuration.ConfigurationManager.AppSettings.Get("NOMEPASTAPROCESSOS");

                if (parProcessos.Equals(((INFOTipoDocumento)cmbTipoDocumento.SelectedItem).NomeTipoDocumento)
                    && cmbTipoProcesso.Text != "") 
                    listaDocumento = bo.obterListaDocumento(((INFOTipoDocumento)(cmbTipoDocumento.SelectedItem)).IdTipoDocumento ,
                                                            ((INFOCategoriaProcesso)(cmbTipoProcesso.SelectedItem)).Ds_sigla.ToUpper());
                else
                    listaDocumento = bo.obterListaDocumento(((INFOTipoDocumento)(cmbTipoDocumento.SelectedItem)).IdTipoDocumento);

                if (listaDocumento != null)
                {


                    foreach (INFODocumento documento in listaDocumento)
                    {
                        listViewItem = new ListViewItem(String.Empty, 0);

                        listViewItem.SubItems.Add(documento.Ordemdocumento.ToString());
                        //listViewItem.SubItems.Add(documento.ObjTipoDocumento.NomeTipoDocumento);
                        listViewItem.SubItems.Add(documento.NomeDocumento);

                        switch (documento.Categoriadocumento)
                        {
                            case "A":
                                listViewItem.SubItems.Add(documento.Categoriadocumento + " - Aéreo");
                                break;
                            case "E":
                                listViewItem.SubItems.Add(documento.Categoriadocumento + " - Exportação");
                                break;
                            case "M":
                                listViewItem.SubItems.Add(documento.Categoriadocumento + " - Marítimo");
                                break;
                            case "R":
                                listViewItem.SubItems.Add(documento.Categoriadocumento + " - Rodoviário");
                                break;
                            default:
                                break;
                        }

                        
                        listViewItem.Tag = documento.IdDocumentos;

                        lstDocumento.Items.Add(listViewItem);
                    }
                }


            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private void carregarComboCategoriaProcesso()
        {
            BoManterCadastroDocumentos boCadastroDocumentos = null;
            List<INFOCategoriaProcesso> ListaCategoriaProcesso = null;
            try
            {

                boCadastroDocumentos = new BoManterCadastroDocumentos();

                ListaCategoriaProcesso = boCadastroDocumentos.obterListaCategoriaProcesso();

                if (ListaCategoriaProcesso != null)
                {

                    cmbTipoProcesso.DataSource = ListaCategoriaProcesso;
                    cmbTipoProcesso.DisplayMember = "Nm_categoria";
                    cmbTipoProcesso.ValueMember = "Ds_sigla";

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

        private void habilitarEdicao()
        {
            btnAtualizar.Visible = true;
            btnCadastrar.Visible = false;

        }

        private void habilitarCadastro()
        {
            btnCadastrar.Visible = true;
            btnAtualizar.Visible = false;
        }

        private void habilitarCategoriaProcesso()
        {
            String parProcessos = System.Configuration.ConfigurationManager.AppSettings.Get("NOMEPASTAPROCESSOS");

            if (parProcessos.Equals(cmbTipoDocumento.SelectedText)) cmbTipoProcesso.Enabled = false;
            else cmbTipoProcesso.Enabled = true;
        }

       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            INFODocumento documento = null;

            try
            {
                documento = new INFODocumento();

                String parProcessos = System.Configuration.ConfigurationManager.AppSettings.Get("NOMEPASTAPROCESSOS");

                if (parProcessos.Equals(cmbTipoDocumento.SelectedText))
                {
                    cmbTipoProcesso.Visible = true;
                    if (String.IsNullOrEmpty(cmbTipoProcesso.Text))
                    {

                        MessageBox.Show("Selecione um tipo de Processo. ", Global.CODAPP + " - " + Global.DESCRICAOAPP,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbTipoDocumento.Focus();
                    }
                    else
                    {
                        documento.Categoriadocumento = ((INFOCategoriaProcesso)(cmbTipoProcesso.SelectedItem)).Ds_sigla.ToUpper();
                    }

                }

                if (String.IsNullOrEmpty(cmbTipoDocumento.Text))
                {
                    MessageBox.Show("Selecione um tipo de documento. ", Global.CODAPP + " - " + Global.DESCRICAOAPP,
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbTipoDocumento.Focus();
                }
                else if (String.IsNullOrEmpty(txtNomeDocumento.Text))
                {
                    MessageBox.Show("Por favor, digite um nome para o documento. ", Global.CODAPP + " - " + Global.DESCRICAOAPP,
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeDocumento.Focus();
                }
                else
                {
                    BoManterCadastroDocumentos bo = new BoManterCadastroDocumentos();

                    documento.NomeDocumento = txtNomeDocumento.Text.ToUpper();
                    documento.Ordemdocumento = (int)nupPosicao.Value;
                    documento.Categoriadocumento = cmbTipoProcesso.SelectedValue.ToString();
                    documento.ObjTipoDocumento = new INFOTipoDocumento();
                    documento.ObjTipoDocumento.IdTipoDocumento = (double)cmbTipoDocumento.SelectedValue;

                    int i = bo.cadastrarDocumentos(documento);

                    switch (i)
                    {
                        case 1:
                            MessageBox.Show("Este documento já está cadastrado! ", 
                                Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        //case 2 :
                        //    MessageBox.Show("Este ordenador já está cadastrado.! ", 
                        //        Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //    break;
                        case 3:
                            MessageBox.Show("Documento Cadastrado com sucesso! ", 
                                Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNomeDocumento.Text = string.Empty;
                            carregarListView();
                            break;
                        default:
                            break;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO : " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                documento = null;
            }




        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            String parProcessos = System.Configuration.ConfigurationManager.AppSettings.Get("NOMEPASTAPROCESSOS");

            if (parProcessos.Equals(cmbTipoDocumento.Text))
            {
                lblTipoProcesso.Visible = true;
                cmbTipoProcesso.Visible = true;
            }
            else
            {
                lblTipoProcesso.Visible = false;
                cmbTipoProcesso.Visible = false;
            }

            carregarListView();

        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            cmbTipoDocumento.SelectedIndex = 0;
            lblTipoProcesso.Visible = false;
            cmbTipoProcesso.Visible = false;
            btnAtualizar.Visible = false;
            btnCadastrar.Visible = true;
            txtNomeDocumento.Text = string.Empty;
            nupPosicao.ResetText();
            nupPosicao.Refresh();
            lblCodigo.Visible = false;

        }

        private void cmbTipoProcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarListView();
        }

        private void lstDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstDocumento.SelectedItems.Count == 1)
                {
                    btnAtualizar.Visible = true;
                    btnCadastrar.Visible = false;

                    lblTipoProcesso.Visible = true;
                    cmbTipoProcesso.Visible = true;

                    nupPosicao.Value = decimal.Parse(lstDocumento.SelectedItems[0].SubItems[1].Text);
                    txtNomeDocumento.Text = lstDocumento.SelectedItems[0].SubItems[2].Text;
                    lblCodigo.Visible = true;
                    lblCodigo.Text = lstDocumento.SelectedItems[0].Tag.ToString();
                }   

            }
            catch (Exception ex)
            {
               MessageBox.Show("ERRO : " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            INFODocumento documento = null;

            try
            {

                documento = new INFODocumento();

                String parProcessos = System.Configuration.ConfigurationManager.AppSettings.Get("NOMEPASTAPROCESSOS");

                if (parProcessos.Equals(cmbTipoDocumento.SelectedText))
                {
                    cmbTipoProcesso.Visible = true;
                    if (String.IsNullOrEmpty(cmbTipoProcesso.Text))
                    {

                        MessageBox.Show("Selecione um tipo de Processo. ", Global.CODAPP + " - " + Global.DESCRICAOAPP,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbTipoDocumento.Focus();
                    }
                    else
                    {
                        documento.Categoriadocumento = ((INFOCategoriaProcesso)(cmbTipoProcesso.SelectedItem)).Ds_sigla.ToUpper();
                    }

                }

                if (String.IsNullOrEmpty(cmbTipoDocumento.Text))
                {
                    MessageBox.Show("Selecione um tipo de documento. ", Global.CODAPP + " - " + Global.DESCRICAOAPP,
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbTipoDocumento.Focus();
                }
                else if (String.IsNullOrEmpty(txtNomeDocumento.Text))
                {
                    MessageBox.Show("Por favor, digite um nome para o documento. ", Global.CODAPP + " - " + Global.DESCRICAOAPP,
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeDocumento.Focus();
                }
                else
                {
                    BoManterCadastroDocumentos bo = new BoManterCadastroDocumentos();


                    documento.IdDocumentos = double.Parse(lblCodigo.Text);
                    documento.NomeDocumento = txtNomeDocumento.Text.ToUpper();
                    documento.Ordemdocumento = (int)nupPosicao.Value;
                    documento.Categoriadocumento = cmbTipoProcesso.SelectedValue.ToString();
                    documento.ObjTipoDocumento = new INFOTipoDocumento();
                    documento.ObjTipoDocumento.IdTipoDocumento = (double)cmbTipoDocumento.SelectedValue;

                    int i = bo.alterarDocumentos(documento);

                    switch (i)
                    {
                        case 1:
                            MessageBox.Show("Documento alterado com sucesso! ",
                                Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            carregarListView();
                            break;  
                        default:
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
               MessageBox.Show("ERRO : " + ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
