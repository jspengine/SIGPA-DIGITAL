using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SIGPA.Service;

namespace DigitalView
{
    public partial class frmManterTiposDocumentos : Form
    {
        public frmManterTiposDocumentos()
        {
            InitializeComponent();
            popularArvoreDiretorio();
        }


        private void popularArvoreDiretorio() {

            TreeNode noRaiz = null;
            DirectoryInfo infoDir = null;

            try
            {
                SIGPA.BO.BOManterParametros param = new SIGPA.BO.BOManterParametros();

                String workDir = param.boObterParametros().NomeDiretorioDocumentos;

                infoDir = new DirectoryInfo(@workDir);

                if (infoDir.Exists) {
                    noRaiz = new TreeNode(infoDir.Name);
                    noRaiz.Tag = infoDir;
                    obterDiretorios(infoDir.GetDirectories(), noRaiz);
                    noRaiz.ContextMenuStrip = ctxMnuExplorer;
                    trvExplorer.Nodes.Add(noRaiz);


                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void obterDiretorios(DirectoryInfo[] subDirs, TreeNode noParaAdicionar) {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
                
            try
            {

                foreach (var subDir in subDirs)
                {
                    aNode = new TreeNode(subDir.Name, 0, 0);
                    aNode.Tag = subDir;
                    aNode.ImageIndex = 0;
                    aNode.ContextMenuStrip = ctxMnuExplorer;

                    subSubDirs = subDir.GetDirectories();

                    if (subSubDirs.Length != 0) {
                        obterDiretorios(subSubDirs, aNode);
                    }

                    noParaAdicionar.Nodes.Add(aNode);
                }

            }
            catch (Exception ex)
            {
                throw ex;
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

        private void trvExplorer_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode novaSelecao = e.Node;
            lsvExplorer.Items.Clear();
            DirectoryInfo infoDir = (DirectoryInfo)novaSelecao.Tag;

            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in infoDir.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"), 
                     new ListViewItem.ListViewSubItem(item, 
						dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                lsvExplorer.Items.Add(item);
            }
            foreach (FileInfo file in infoDir.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"), 
                     new ListViewItem.ListViewSubItem(item, 
						file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                lsvExplorer.Items.Add(item);
            }

            lsvExplorer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trvExplorer.SelectedNode.FullPath);
        }


    }
}
