using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text;
using SIGPA.INFO;

namespace SIGPA.DAO
{
    public class DAODocumento:DALGeneral
    {
        public List<INFODocumento> dbObterListaDocumento(double pIdentificador, string pCategoria)
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlDataReader objDr = null;
            INFODocumento objDocumento = null;
            List<INFODocumento> ListaDocumento = null;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine("SELECT ID_DOCUMENTO, NM_DOCUMENTO ");
                strSQL.AppendLine(" FROM documento  ");
                strSQL.AppendLine(" WHERE ID_TIPODOCUMENTO = " + pIdentificador.ToString());
                strSQL.AppendLine(" AND (DS_CATEGORIADOCUMENTO = 'S' OR DS_CATEGORIADOCUMENTO = '" + pCategoria + "')");
                strSQL.AppendLine(" ORDER BY ID_DOCUMENTO ");

                objConn = new MySqlConnection(gConnectionString);

                objDr = dbObterRegistros(objConn, strSQL.ToString(), null);

                if (objDr != null)
                {
                    while (objDr.Read())
                    {
                        objDocumento = new INFODocumento();

                        if (objDr["ID_DOCUMENTO"] != DBNull.Value)
                        {
                            objDocumento.IdDocumentos = (double)objDr["ID_DOCUMENTO"];
                        }

                        if (objDr["NM_DOCUMENTO"] != DBNull.Value)
                        {
                            objDocumento.NomeDocumento = (string)objDr["NM_DOCUMENTO"];
                        }
                        else
                        {
                            objDocumento.NomeDocumento = null;
                        }

                        if (ListaDocumento == null)
                        {
                            ListaDocumento = new List<INFODocumento>();
                        }

                        ListaDocumento.Add(objDocumento);
                    }
                }

                return ListaDocumento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
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

        

    }
}
