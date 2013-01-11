using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIGPA.INFO;
using MySql.Data.MySqlClient;

namespace SIGPA.DAO
{
   public class DAOFix :DALGeneral
    {
       public List<INFODocumentoDigital> getDocumentosDigital() {
           StringBuilder strSql = new StringBuilder();
           MySqlConnection objConn = null;
           MySqlDataReader objDr = null;
           List<INFODocumentoDigital> listaDocumentoDigital = null;
           INFODocumentoDigital objDocumentoDigital = null;
           try
           {
               strSql.Append(" SELECT ID_DOCUMENTODIGITAL, NM_ARQUIVO, NM_DIRETORIOARQUIVO ");
               strSql.Append(" FROM `documentodigital` ");
                  
               objConn = new MySqlConnection(gConnectionString);

               objDr = dbObterRegistros(objConn, strSql.ToString(), null);

               if (objDr != null)
               {
                   //listaDocumentoDigital = new List<INFODocumentoDigital>();
                   while (objDr.Read())
                   {
                       objDocumentoDigital = new INFODocumentoDigital();

                       if (objDr["ID_DOCUMENTODIGITAL"] != DBNull.Value)
                           objDocumentoDigital.IdDocumentoDigital = (double)objDr["ID_DOCUMENTODIGITAL"];

                       if (objDr["NM_ARQUIVO"] != DBNull.Value)
                           objDocumentoDigital.NomeArquivo = (string)objDr["NM_ARQUIVO"];
                       else objDocumentoDigital.NomeArquivo = null;

                       if (objDr["NM_DIRETORIOARQUIVO"] != DBNull.Value)
                           objDocumentoDigital.NomeDiretorioArquivo = (string)objDr["NM_DIRETORIOARQUIVO"];
                       else objDocumentoDigital.NomeDiretorioArquivo = null;

                       if (listaDocumentoDigital == null) listaDocumentoDigital = new List<INFODocumentoDigital>();

                       listaDocumentoDigital.Add(objDocumentoDigital);
                   }
               }

               return listaDocumentoDigital;
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               strSql = null;

               if (!objDr.IsClosed)
               {
                   objDr.Close();
                   objDr.Dispose();
               }
               objDr = null;

               if (objConn.State == System.Data.ConnectionState.Open)
               {
                   objConn.Close();
                   objConn.Dispose();
                   objConn = null;
               }

           }

       }


       public bool updateValidPath(INFODocumentoDigital pObjDocumentoDigital)
       {
               StringBuilder strSql = new StringBuilder();
               MySqlConnection objConn = null;
               MySqlCommand objCmd = null;

               try
               {
                   strSql.Append(" UPDATE DOCUMENTODIGITAL  SET ");
                   strSql.Append(" NM_DIRETORIOARQUIVO =?dirdocumento ");
                   strSql.Append(" WHERE ID_DOCUMENTODIGITAL =?iddocumento");

                   objConn = new MySqlConnection(gConnectionString);
                   objConn.Open();
                   objCmd = new MySqlCommand(strSql.ToString(), objConn);

                   objCmd.Parameters.Add("?dirdocumento", MySqlDbType.VarChar).Value = pObjDocumentoDigital.NomeDiretorioArquivo;
                   objCmd.Parameters.Add("?iddocumento", MySqlDbType.Double).Value = pObjDocumentoDigital.IdDocumentoDigital;


                   
                   return (objCmd.ExecuteNonQuery() > 0) ? true : false;

               }
               catch (Exception ex)
               {
                   throw ex;
               }
               finally
               {
                   strSql = null;

                   objCmd.Dispose();
                   objCmd = null;

                   if (objConn.State == System.Data.ConnectionState.Open)
                   {
                       objConn.Close();
                       objConn.Dispose();
                       objConn = null;
                   }

               }


               
       }



    }
}
