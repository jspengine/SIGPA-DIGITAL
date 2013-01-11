using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIGPA.BO;
using SIGPA.INFO;
using SIGPA.Service;

namespace DigitalView
{
    public partial class frmTipoDocumento : Form
    {
        public frmTipoDocumento()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
                
        }

        //------------ Carregar a List View
        private void ListViewLoad()
        {
            ListViewItem lObjListViewItem = null;
            List<INFOTipoDocumento> ListaTipoDocumento = null; 

            BOTipoDocumento objTipoDocumento = null;
            try
            {
                this.lstTipoDocumento.Items.Clear();

                objTipoDocumento = new BOTipoDocumento();
                ListaTipoDocumento = objTipoDocumento.boObterTipoDocumento();
              
                if (ListaTipoDocumento != null)
                {

                    for (int i = 0; i < ListaTipoDocumento.Count; i++)
                    {
                        lObjListViewItem = new ListViewItem(string.Empty, 0);


                        lObjListViewItem.SubItems.Add(ListaTipoDocumento[i].NomeTipoDocumento);
                        lObjListViewItem.Tag = ListaTipoDocumento[i].IdTipoDocumento;

                        this.lstTipoDocumento.Items.Add(lObjListViewItem);   //Add(new ListViewItem[] { lObjListViewItem });

                    }
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


        //------------ Carregar a List View
        private void frmTipoDocumento_Load(object sender, EventArgs e)
        {
            ListViewLoad();
        }


        //------------ realiza o cadastro 
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            BOTipoDocumento objBoTipoDocumento = null;
            INFOTipoDocumento objInfoTipoDocumento = null;
            try
            {
                if (string.IsNullOrEmpty(txtTipoDocumento.Text))
                {
                    MessageBox.Show("O campo de Cadastro de Tipo de Documentos não pode ser vazio!", Global.CODAPP + " - " + Global.DESCRICAOAPP,                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTipoDocumento.Focus();
                }
                else {
                    objBoTipoDocumento = new BOTipoDocumento();
                    objInfoTipoDocumento = new INFOTipoDocumento();

                     objInfoTipoDocumento.NomeTipoDocumento = txtTipoDocumento.Text;

                     if (objBoTipoDocumento.boInserirTipoDocumento(objInfoTipoDocumento))
                     {
                         MessageBox.Show("Novo Tipo de Documento alterados com sucesso!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         txtTipoDocumento.Clear();
                         txtTipoDocumento.Focus();
                         ListViewLoad();
                     }
                     else
                     {
                         MessageBox.Show("Os cadastros devem ser únicos, verifique se o novo Tipo de Documento está previamente cadastrado no sistema", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                     }
                }

            }
            catch (Exception ex)
            {
  
                MessageBox.Show("ERRO: "+ ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //------------ sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        //Se tiver algum item da list box selecionado e carregado na txtbox, atualiza o cadastro do cara.
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            BOTipoDocumento objBoTipoDocumento = null;
            INFOTipoDocumento objInfoTipoDocumento = null;
            try
            {
                if (string.IsNullOrEmpty(txtTipoDocumento.Text))
                {
                    MessageBox.Show("O campo de Cadastro de Tipo de Documentos não pode ser vazio!", Global.CODAPP + " - " + Global.DESCRICAOAPP,                                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTipoDocumento.Focus();
                }
                else {
                    objBoTipoDocumento = new BOTipoDocumento();
                    objInfoTipoDocumento = new INFOTipoDocumento();

                     objInfoTipoDocumento.NomeTipoDocumento = txtTipoDocumento.Text;
                     objInfoTipoDocumento.IdTipoDocumento = Convert.ToDouble(lbCodigo.Text);

                     if (objBoTipoDocumento.boAtualizarTipoDocumento(objInfoTipoDocumento))
                     {
                         MessageBox.Show("Cadastro alterado com sucesso!", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         btnAtualizar.Visible = false;
                         btnNovoCadastro.Visible = false;
                         txtTipoDocumento.Clear();
                         lbCodigo.Visible = false;
                         lbtxtcodigo.Visible = false;
                         btnCadastrar.Visible = true;
                         txtTipoDocumento.Focus();
                         ListViewLoad();
                     }
                     else
                     {
                         MessageBox.Show("Cadastro não efetuado, verifique se o item não está préviamente cadastrado", Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                     
                }

            }
            catch (Exception ex)
            {
  
                MessageBox.Show("ERRO: "+ ex.ToString(), Global.CODAPP + " - " + Global.DESCRICAOAPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        //pega o item selecionado e carrega na textbox, habilita o botão atualizar e desabilita o botão cadastrar
        private void lstTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTipoDocumento.SelectedItems.Count == 1)
            {
                btnNovoCadastro.Visible = true;
                btnAtualizar.Visible = true;
                btnCadastrar.Visible = false;
                //txtTipoDocumento.Text = lstTipoDocumento.SelectedItems
               //MessageBox.Show(lstTipoDocumento.SelectedItems[0].Tag.ToString());
                txtTipoDocumento.Text = lstTipoDocumento.SelectedItems[0].SubItems[1].Text;
                lbCodigo.Visible = true;
                lbCodigo.Text = lstTipoDocumento.SelectedItems[0].Tag.ToString();
                lbtxtcodigo.Visible = true;

                

            }
            
        }

        private void lstTipoDocumento_DoubleClick(object sender, EventArgs e)
        {
        
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            btnAtualizar.Visible = false;
            btnNovoCadastro.Visible = false;
            txtTipoDocumento.Clear();
            lbCodigo.Visible = false;
            lbtxtcodigo.Visible = false;
            btnCadastrar.Visible = true;
            txtTipoDocumento.Focus();
        }
    }
}
