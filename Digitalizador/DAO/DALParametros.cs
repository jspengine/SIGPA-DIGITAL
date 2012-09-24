using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;
using SIGPA.INFO;

namespace SIGPA.DAO
{
    public class DALParametros:DALGeneral
    {
        private string gConnectionString = string.Empty;
       
        public DALParametros()
        {
            gConnectionString = ConfigurationManager.ConnectionStrings["SIGPA_DIGITAL"].ConnectionString ; 
        }

        public INFOParametros dbObterParametros()
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlCommand objCmd = null;
            MySqlDataReader objDr = null;
            INFOParametros objParametros = null;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine("SELECT * ");
                strSQL.AppendLine(" FROM parametros ");

                objConn = new MySqlConnection(gConnectionString);
                objConn.Open();
                objCmd = new MySqlCommand(strSQL.ToString(), objConn);
                objDr = objCmd.ExecuteReader();

                if (objDr != null)
                {
                    if (objDr.Read())
                    {
                        objParametros = new INFOParametros();

                        if (objDr["id_parametros"] != DBNull.Value)
                        {
                            objParametros.IdParametros = (int) objDr["id_parametros"];
                        }

                        if (objDr["nr_contador"] != DBNull.Value)
                        {
                            objParametros.NumeroContador = (double)objDr["nr_contador"];
                        }

                        if (objDr["nm_diretoriodocumentos"] != DBNull.Value)
                        {
                            objParametros.NomeDiretorioDocumentos = (string)objDr["NM_DIRETORIODOCUMENTOS"];
                        }
                    }
                }

                return objParametros;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                if (objCmd != null)
                {
                    objCmd.Dispose();
                    objCmd = null;
                }

                if (objDr != null)
                {
                    if (objDr.IsClosed == false)
                    {
                        objDr.Close();
                    }
                    objDr = null;
                }

                if (objConn.State == System.Data.ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                    objConn = null;
                }

                strSQL = null;
            }
        }

        public Boolean dbAtualizarParametros(INFOParametros pObjParametros)
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlCommand objCmd = null;

            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine("UPDATE parametros SET ");
                strSQL.AppendLine(" nm_diretoriodocumentos = '" + pObjParametros.NomeDiretorioDocumentos.Replace("\\", "\\\\") + "'");

                objConn = new MySqlConnection(gConnectionString);
                objConn.Open();
                objCmd = new MySqlCommand(strSQL.ToString(), objConn);

                if (objCmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else{
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                if (objCmd != null)
                {
                    objCmd.Dispose();
                    objCmd = null;
                }

                if (objConn.State == System.Data.ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                    objConn = null;
                }

                strSQL = null;
            }
        }


        public Boolean dbAtualizarContador(INFOParametros pObjParametros, MySqlTransaction pObjTrans)
        {
            StringBuilder strSQL = null;
            double contador = pObjParametros.NumeroContador + 1;

            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine("UPDATE parametros SET ");
                strSQL.AppendLine(" NR_CONTADOR = " + contador);

                
                if (dbExecutarQuery(strSQL.ToString(), pObjTrans) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                strSQL = null;
            }
        }

    }
}
