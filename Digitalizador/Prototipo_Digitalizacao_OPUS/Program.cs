using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using Nevron.Utility;
using System.Diagnostics;

using System.Threading;

namespace DigitalView
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {

            //NLicense objLicenca;
            Form frmPrincipal = null;
            string TempDir = string.Empty;
            string TempDirPdf = string.Empty;

            try
            {

                //objLicenca = new NLicense("f2f23218-3148-67ce-07d9-b355d8839dd9");
                //NLicenseManager.Instance.SetLicense(objLicenca);
                //NLicenseManager.Instance.LockLicense = true;

                //Deleting Temporary Directory
                TempDir = System.Configuration.ConfigurationSettings.AppSettings["DIRIMGSCANNER"].ToString();
                TempDirPdf = System.Configuration.ConfigurationSettings.AppSettings["DIRPDF"].ToString();

                if (System.IO.Directory.Exists(TempDir)) System.IO.Directory.Delete(TempDir, true);
                if (System.IO.Directory.Exists(TempDirPdf)) System.IO.Directory.Delete(TempDirPdf, true);

                if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName.ToString()).Length > 1)
                {
                    MessageBox.Show("Já existe uma instância da aplicação rodando", "SIGPA - DIGITALIZAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

        
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);

                //Application.Run(new frmLogin());   

                //frmSplashScreen frmSplash = new frmSplashScreen();
                //frmSplash.Show();

                //Thread.Sleep(3000);

                //frmSplash.Close();
                
                frmPrincipal = new frmLogin();
              
                if (frmPrincipal.ShowDialog() == DialogResult.OK)
                {
                    frmPrincipal = new frmMenu();
                    frmPrincipal.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algum erro aconteceu: " + ex.ToString());
                //throw ;
            }
        }
    }
}
