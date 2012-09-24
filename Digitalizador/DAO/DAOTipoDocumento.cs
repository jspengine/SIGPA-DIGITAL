using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using SIGPA.INFO;


namespace SIGPA.DAO
{
    public class DAOTipoDocumento: DALGeneral
    {
        public List<INFOTipoDocumento> dbObterListaTipoDocumento()
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlCommand objCmd = null;
            MySqlDataReader objDr = null;
            INFOTipoDocumento objTipodocumento = null;
            List<INFOTipoDocumento> ListaTipoDocumento = null;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine("SELECT ID_TIPODOCUMENTO, NM_TIPODOCUMENTO ");
                strSQL.AppendLine(" FROM tipodocumento  ");
                strSQL.AppendLine(" ORDER BY NM_TIPODOCUMENTO ");

                objConn = new MySqlConnection(gConnectionString);
                objDr = dbObterRegistros(objConn, strSQL.ToString(), null);

                if (objDr != null)
                {
                    while (objDr.Read())
                    {
                        objTipodocumento = new INFOTipoDocumento();

                        if (objDr["ID_TIPODOCUMENTO"] != DBNull.Value)
                        {
                            objTipodocumento.IdTipoDocumento = (double)objDr["ID_TIPODOCUMENTO"];
                        }

                        if (objDr["NM_TIPODOCUMENTO"] != DBNull.Value)
                        {
                            objTipodocumento.NomeTipoDocumento = (string)objDr["NM_TIPODOCUMENTO"];
                        }
                        else
                        {
                            objTipodocumento.NomeTipoDocumento = null;
                        }

                        if (ListaTipoDocumento == null) {
                            ListaTipoDocumento = new List<INFOTipoDocumento>();
                        }

                        ListaTipoDocumento.Add(objTipodocumento);
                    }
                }

                return ListaTipoDocumento;
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
