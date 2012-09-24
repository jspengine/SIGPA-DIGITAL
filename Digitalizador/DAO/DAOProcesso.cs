using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using SIGPA.INFO;
using MySql.Data.MySqlClient;

namespace SIGPA.DAO
{
    public class DAOProcesso:DALGeneral
    {
        private static string strConnection = null;
        public DAOProcesso(){
            strConnection = ConfigurationManager.ConnectionStrings["SIGPA_DIGITAL"].ConnectionString.ToString();
        }

        public INFOProcesso dbObterProcesso(string pStrReferencia) {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlCommand objCmd = null;
            MySqlDataReader objDr = null;
            INFOProcesso objProcesso = null;
            DAOCliente objDaoCliente = null;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine("SELECT ID_PROCESSO, NR_REFERENCIA, ID_CLIENTE, ID_PROCESSO_SIGPA ");
                strSQL.AppendLine(" FROM processo  ");
                strSQL.AppendLine(" WHERE NR_REFERENCIA = '" + pStrReferencia + "'");

                objConn = new MySqlConnection(gConnectionString);
                objConn.Open();
                objCmd = new MySqlCommand(strSQL.ToString(), objConn);
                objDr = objCmd.ExecuteReader();

                if (objDr != null)
                {
                    if (objDr.Read())
                    {
                        objProcesso = new INFOProcesso();

                        if (objDr["ID_PROCESSO"] != DBNull.Value)
                        {
                            objProcesso.IdProcesso = (double)objDr["ID_PROCESSO"];
                        }

                        if (objDr["NR_REFERENCIA"] != DBNull.Value)
                        {
                            objProcesso.NumeroReferencia = (string)objDr["NR_REFERENCIA"];
                        }
                        else
                        {
                            objProcesso.NumeroReferencia = null;
                        }

                        if (objDr["ID_CLIENTE"] != DBNull.Value)
                        {
                            objDaoCliente = new DAOCliente();
                            objProcesso.ObjCliente = objDaoCliente.dbObterCliente((double)objDr["ID_CLIENTE"]);
                        }
                        else {
                            objProcesso.ObjCliente = null;
                        }

                        if (objDr["ID_PROCESSO_SIGPA"] != DBNull.Value)
                        {
                            objProcesso.IdProcessoSigpa = (double)objDr["ID_PROCESSO_SIGPA"];
                        }

                    }
                }

                return objProcesso;
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

        public Boolean dbInserirProcesso(INFOCliente objCliente)
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlCommand objCmd = null;
            bool vRetorno = false;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine(" INSERT INTO CLIENTES ( NM_CLIENTE, NM_CLIENTE_MAPA, NR_CNPJ, NR_CPF, ID_CLIENTE_SIGPA)");
                strSQL.AppendLine(" VALUES ( '" + objCliente.NomeCliente + "', ");
                strSQL.AppendLine("  '" + objCliente.NomeClienteMapa + "', ");
                strSQL.AppendLine(" '" + objCliente.NumeroCnpj + "', ");
                strSQL.AppendLine(" '" + objCliente.NumeroCpf + "', ");
                strSQL.AppendLine(" '" + objCliente.IdClienteSigpa + ") ");

                objConn = new MySqlConnection(gConnectionString);
                objConn.Open();
                objCmd = new MySqlCommand(strSQL.ToString(), objConn);

                if (objCmd.ExecuteNonQuery() > 0)
                {
                    vRetorno = true;
                }

                return vRetorno;
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

        public Boolean dbInserirProcesso(INFOProcesso pObjProcesso, MySqlTransaction pTrans)
        {
            StringBuilder strSQL = null;
            bool vRetorno = false;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine(" INSERT INTO PROCESSO ( NR_REFERENCIA, ID_CLIENTE, ID_PROCESSO_SIGPA )");
                strSQL.AppendLine(" VALUES ( '" + pObjProcesso.NumeroReferencia + "', ");
                strSQL.AppendLine(+ pObjProcesso.ObjCliente.IdCliente + ", ");
                strSQL.AppendLine(+ pObjProcesso.IdProcessoSigpa + ")");

                if (dbExecutarQuery(strSQL.ToString(), pTrans) > 0)
                {
                    vRetorno = true;
                }

                return vRetorno;
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
