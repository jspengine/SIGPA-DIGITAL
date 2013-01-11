using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIGPA.DAO;
using SIGPA.INFO;

namespace Recovery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAOFix dao = null;


            try
            {
                Cursor = Cursors.WaitCursor;
                dao = new DAOFix();


                toValidPath(dao.getDocumentosDigital());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally {
                Cursor = Cursors.Default;
            }
        }


        private void toValidPath(List<INFODocumentoDigital> listDocumentoDigital) {

            List<INFODocumentoDigital> listDDInvalidPath = null; 
            DAOFix dao = null;
            StringBuilder query = null;
            try
            {
                listDDInvalidPath = new List<INFODocumentoDigital>();

                foreach (var documentoDigital in listDocumentoDigital)
                {

                    if (documentoDigital.NomeDiretorioArquivo.StartsWith("\\\\\\\\\\\\\\\\Rjsigpadigital\\\\\\\\sigpa-digital-arquivos") )
                        listDDInvalidPath.Add(documentoDigital);
                }

                if (MessageBox.Show("Foram encontrados " + listDDInvalidPath.Count.ToString() + " registros invalidos") == System.Windows.Forms.DialogResult.OK) {

                    dao = new DAOFix();
                    INFODocumentoDigital infodd = null;

                    query = new StringBuilder();

                    query.Append("select * from documentodigital where id_documentodigital in ( ".ToUpper() );

                    foreach (var ddinvalid in listDDInvalidPath)
                    {
                        //Fix primeiro nivel dos registros
                        String nomediretorio = ddinvalid.NomeDiretorioArquivo.Replace("\\\\\\\\\\\\\\\\", "\\\\");


                        String validDir = nomediretorio.Replace("\\\\\\\\", "\\");

                       infodd = new INFODocumentoDigital();

                       infodd.IdDocumentoDigital = ddinvalid.IdDocumentoDigital;
                       infodd.NomeDiretorioArquivo = validDir;
                            
                       if (dao.updateValidPath(infodd)){
                           query.Append(infodd.IdDocumentoDigital).Append(", ");
                           //MessageBox.Show(" ID: " + infodd.IdDocumentoDigital + " Atualizado.");
                       }

                        
                       infodd = null;

                    }

                    query.Append(")");

                    textBox1.Text = query.ToString();
                }
                


            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
