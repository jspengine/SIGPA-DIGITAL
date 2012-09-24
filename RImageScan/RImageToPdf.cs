using System;
using System.Diagnostics;
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace RImageScan
{
    public class RImageToPdf
    {
        public static XGraphics objGfx = null;

        public bool ExportToPDF(string FileNamePDF, bool ShowFile){
       
        string strFileTmpPdf = string.Empty ;
        PdfDocument objDocument = null;
        FileInfo objFileInfo = null;
        PdfPage objPage = null;
        XImage objImage = null;
        try
        {
            // Create a new PDF document
            objDocument = new PdfDocument();
            objDocument.Info.Title = "Criado por OPUS DIGITALIZADOR";
            objDocument.Info.Author = "OPUS Comérico Exterior Ltda";
            objDocument.Info.Creator = "OPUS DIGITALIZADOR";
            
            //Se o diretório de PDF não existir eu o crio
            if (!Directory.Exists(System.Configuration.ConfigurationSettings.AppSettings["DIRPDF"].ToString())) {
                Directory.CreateDirectory (System.Configuration.ConfigurationSettings.AppSettings["DIRPDF"].ToString());
            }

            strFileTmpPdf = System.Configuration.ConfigurationSettings.AppSettings["DIRPDF"].ToString()+ FileNamePDF;
            foreach (string strFileName in System.IO.Directory.GetFiles(System.Configuration.ConfigurationSettings.AppSettings["DIRIMGSCANNER"].ToString() + FileNamePDF))
            {
                objFileInfo = new FileInfo(strFileName);

                if (objFileInfo.Extension.ToUpper() == System.Configuration.ConfigurationSettings.AppSettings["EXTIMG"].ToString())
                {
                    // Create an empty page
                    objPage = objDocument.AddPage();

                    // Get an XGraphics object for drawing
                    objGfx = XGraphics.FromPdfPage(objPage);

                    objImage = XImage.FromFile(strFileName);

                    //double x = (250 - objImage.PixelWidth * 72 / objImage.HorizontalResolution) / 2;
                    int x = Convert.ToInt32 (System.Configuration.ConfigurationSettings.AppSettings["BEGINX"].ToString());
                    int y = Convert.ToInt32 (System.Configuration.ConfigurationSettings.AppSettings["BEGINY"].ToString());
                    int largura = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["WIDTH"].ToString());
                    int altura = Convert.ToInt32 (System.Configuration.ConfigurationSettings.AppSettings["HEIGHT"].ToString());

                    objGfx.DrawImage(objImage,x, y, largura,altura );

                    if (File.Exists(strFileTmpPdf)) File.Delete(strFileTmpPdf);
                    
                    objDocument.Save(strFileTmpPdf);

                }
            }

            if (ShowFile) Process.Start(strFileTmpPdf);
            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally {

            objPage = null;
            
            objImage.Dispose();
            objImage = null;

            objDocument.Dispose();
            objDocument = null;

            objFileInfo = null;

        }
      }
   }
}
