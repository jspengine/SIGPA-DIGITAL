using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using SIGPA.INFO;

namespace SIGPA.DAO
{
    public class DAODocumentoDigital:DALGeneral
    {
        public bool dbExcluirDocumento(INFODocumentoDigital pObjDocumentoDigital, MySqlTransaction pObjTrans)
        {
            StringBuilder strSql = new StringBuilder();

            try
            {
                strSql.Append("UPDATE DOCUMENTODIGITAL  SET FL_EXCLUIDO = 1 WHERE ID_DOCUMENTODIGITAL = " + pObjDocumentoDigital.IdDocumentoDigital.ToString());

                if (dbExecutarQuery(strSql.ToString(), pObjTrans) > 0) return true; else return false;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally{
                strSql = null;
            }
        }

        public bool dbAlterarDocumento(INFODocumentoDigital pObjDocumentoDigital, MySqlTransaction pObjTrans)
        {
            StringBuilder strSql = new StringBuilder();

            try
            {
                strSql.Append("UPDATE DOCUMENTODIGITAL  SET ");
                strSql.Append("NM_ARQUIVO ='" + pObjDocumentoDigital.NomeArquivo + "',");
                strSql.Append("NM_DIRETORIOARQUIVO = '" + pObjDocumentoDigital.NomeDiretorioArquivo.Replace("\\","\\\\") + "'");
                strSql.Append("WHERE ID_DOCUMENTODIGITAL =" + pObjDocumentoDigital.IdDocumentoDigital.ToString());


                if (dbExecutarQuery(strSql.ToString(), pObjTrans) > 0) return true; else return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                strSql = null;
            }
        }

        public long dbInserirDocumentos(INFODocumentoDigital pObjDocumentoDigital, MySqlTransaction pObjTrans)
        {
            StringBuilder strSql = new StringBuilder();
            MySqlDataReader objDr = null;
            long lastId = 0;
            try
            {
                strSql.Append("INSERT INTO DOCUMENTODIGITAL (NM_ARQUIVO, NM_DIRETORIOARQUIVO, ID_DOCUMENTO, ID_PROCESSO) ");
                strSql.Append("VALUES (" );
                strSql.Append("'" + pObjDocumentoDigital.NomeArquivo + "',");
                strSql.Append("'" + pObjDocumentoDigital.NomeDiretorioArquivo.Replace("\\","\\\\" )+ "',");
                strSql.Append( pObjDocumentoDigital.IdDocumento  + ",");
                strSql.Append(pObjDocumentoDigital.IdProcesso + ")");

                if (dbExecutarQuery(strSql.ToString(), pObjTrans) > 0)
                {
                    strSql.Remove(0, strSql.Length);
                    strSql.Append("SELECT LAST_INSERT_ID()");

                    objDr = dbObterRegistros(null, strSql.ToString(), pObjTrans);

                    if (objDr.HasRows) {
                        if (objDr.Read())
                        {
                            lastId = (long)objDr[0];     
                        }
                    }
                }
                return lastId;
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
                objDr=null;
            }
        }

        public List<INFODocumentoDigital> dbObterDocumentosDigitais(string pNref, double pIdDocumento) {

            StringBuilder strSql = new StringBuilder();
            MySqlConnection objConn = null;
            MySqlDataReader objDr = null;
            List<INFODocumentoDigital> listaDocumentoDigital = null;
            INFODocumentoDigital objDocumentoDigital = null;
            try
            {
                strSql.Append(" SELECT ID_DOCUMENTODIGITAL, NM_ARQUIVO, NM_DIRETORIOARQUIVO ");
                strSql.Append(" FROM `documentodigital` AS DD, `processo` AS P, `documento` AS D");
                strSql.Append(" WHERE P.`ID_PROCESSO` = DD.`ID_PROCESSO` ");
                strSql.Append(" AND DD.`ID_DOCUMENTO` = D.`ID_DOCUMENTO`");
                strSql.Append(" AND P.`NR_REFERENCIA` ='"+ pNref +"'");
                strSql.Append(" AND D.`ID_DOCUMENTO` =" +pIdDocumento.ToString());
                strSql.Append(" AND DD.`FL_EXCLUIDO` = 0" );

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
            finally {
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
    }
}
