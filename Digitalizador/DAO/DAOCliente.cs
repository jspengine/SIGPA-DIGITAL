using System;
using System.Collections.Generic;
using System.Text;
using SIGPA.INFO;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace SIGPA.DAO
{
    public class DAOCliente : DALGeneral
    {
        //private string gConnectionString = string.Empty;

        public DAOCliente()
        {
            gConnectionString = ConfigurationManager.ConnectionStrings["SIGPA_DIGITAL"].ConnectionString;
        }

        public INFOCliente dbObterCliente(double pIntIdCliente)
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlCommand objCmd = null;
            MySqlDataReader objDr = null;
            INFOCliente objCliente = null;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine(" SELECT ID_CLIENTE, NM_CLIENTE, NM_CLIENTE_MAPA, NR_CNPJ, NR_CPF  ");
                strSQL.AppendLine(" FROM cliente  ");
                strSQL.AppendLine(" WHERE ID_CLIENTE = ?idCliente" );

                objConn = new MySqlConnection(gConnectionString);
                objConn.Open();
                objCmd = new MySqlCommand(strSQL.ToString(), objConn);

                objCmd.Parameters.Add("?idCliente", MySqlDbType.Int32).Value = pIntIdCliente ;

                objDr = objCmd.ExecuteReader();

                if (objDr != null)
                {
                    if (objDr.Read())
                    {
                        objCliente = new INFOCliente();

                        if (objDr["ID_CLIENTE"] != DBNull.Value)
                        {
                            objCliente.IdCliente = (double)objDr["ID_CLIENTE"];
                        }

                        if (objDr["NM_CLIENTE"] != DBNull.Value)
                        {
                            objCliente.NomeCliente = (string)objDr["NM_CLIENTE"];
                        }
                        else
                        {
                            objCliente.NomeCliente = null;
                        }

                        if (objDr["NM_CLIENTE_MAPA"] != DBNull.Value)
                        {
                            objCliente.NomeClienteMapa = (string)objDr["NM_CLIENTE_MAPA"];
                        }
                        else
                        {
                            objCliente.NomeClienteMapa = null;
                        }

                        if (objDr["NR_CNPJ"] != DBNull.Value)
                        {
                            objCliente.NumeroCnpj = (string)objDr["NR_CNPJ"];
                        }

                        if (objDr["NR_CPF"] != DBNull.Value)
                        {
                            objCliente.NumeroCpf = (string)objDr["NR_CPF"];
                        }
                    }
                }

                return objCliente;
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

        public INFOCliente dbObterClientePorIDSigpa(double pIntIdClienteSigpa)
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlCommand objCmd = null;
            MySqlDataReader objDr = null;
            INFOCliente objCliente = null;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine(" SELECT ID_CLIENTE, NM_CLIENTE, NM_CLIENTE_MAPA, NR_CNPJ, NR_CPF  ");
                strSQL.AppendLine(" FROM cliente  ");
                strSQL.AppendLine(" WHERE ID_CLIENTE_SIGPA = ?idClienteSigpa");

                objConn = new MySqlConnection(gConnectionString);
                objConn.Open();
                objCmd = new MySqlCommand(strSQL.ToString(), objConn);

                objCmd.Parameters.Add("?idClienteSigpa", MySqlDbType.Int32).Value = pIntIdClienteSigpa;

                objDr = objCmd.ExecuteReader();

                if (objDr != null)
                {
                    if (objDr.Read())
                    {
                        objCliente = new INFOCliente();

                        if (objDr["ID_CLIENTE"] != DBNull.Value)
                        {
                            objCliente.IdCliente = (double)objDr["ID_CLIENTE"];
                        }

                        if (objDr["NM_CLIENTE"] != DBNull.Value)
                        {
                            objCliente.NomeCliente = (string)objDr["NM_CLIENTE"];
                        }
                        else
                        {
                            objCliente.NomeCliente = null;
                        }

                        if (objDr["NM_CLIENTE_MAPA"] != DBNull.Value)
                        {
                            objCliente.NomeClienteMapa = (string)objDr["NM_CLIENTE_MAPA"];
                        }
                        else
                        {
                            objCliente.NomeClienteMapa = null;
                        }

                        if (objDr["NR_CNPJ"] != DBNull.Value)
                        {
                            objCliente.NumeroCnpj = (string)objDr["NR_CNPJ"];
                        }

                        if (objDr["NR_CPF"] != DBNull.Value)
                        {
                            objCliente.NumeroCpf = (string)objDr["NR_CPF"];
                        }
                    }
                }

                return objCliente;
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

        public bool dbInserirCliente(INFOCliente objCliente)
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlCommand objCmd = null;
            
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine(" INSERT INTO CLIENTES ( NM_CLIENTE, NM_CLIENTE_MAPA, NR_CNPJ, NR_CPF, ID_CLIENTE_SIGPA)").
                       AppendLine(" VALUES ( ?nomeCliente, ?nomeClienteMapa, ?nrCnpj, ?nrCpf, ?idCliente ) ");
                       
                
                objConn = new MySqlConnection(gConnectionString);
                objConn.Open();
                objCmd = new MySqlCommand(strSQL.ToString(), objConn);

                objCmd.Parameters.Add("?nomeCliente", MySqlDbType.VarChar).Value = objCliente.NomeCliente;
                objCmd.Parameters.Add("?nomeClienteMapa", MySqlDbType.VarChar).Value = objCliente.NomeClienteMapa;
                objCmd.Parameters.Add("?nrCnpj", MySqlDbType.VarChar).Value = objCliente.NumeroCnpj;
                objCmd.Parameters.Add("?nrCpf", MySqlDbType.VarChar).Value = objCliente.NumeroCpf;
                objCmd.Parameters.Add("?idCliente", MySqlDbType.Int32).Value = objCliente.IdClienteSigpa;
                

                return  (objCmd.ExecuteNonQuery() > 0) ? true : false;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally{
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

        public bool dbInserirCliente(INFOCliente objCliente, MySqlTransaction pTrans)
        {
            StringBuilder strSQL = null;
            bool vRetorno = false;
       
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine(" INSERT INTO CLIENTE ( NM_CLIENTE, NM_CLIENTE_MAPA, NR_CNPJ, NR_CPF, ID_CLIENTE_SIGPA)");
                strSQL.AppendLine(" VALUES ( '" + objCliente.NomeCliente.Replace("'", "''") + "', ");
                strSQL.AppendLine("  '" + objCliente.NomeClienteMapa.Replace("'", "''") + "', ");
                strSQL.AppendLine(" '" + objCliente.NumeroCnpj + "', ");
                strSQL.AppendLine(" '" + objCliente.NumeroCpf + "', ");
                strSQL.AppendLine( + objCliente.IdClienteSigpa + ") ");

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

        public long dbObterUltimoID( MySqlTransaction pTrans)
        {
            StringBuilder strSQL = null;
            MySqlDataReader objDr = null;
            long ultimoID=0;
            try
            {
                strSQL = new StringBuilder();

                //strSQL.AppendLine(" SELECT MAX(ID_CLIENTE) as ID FROM CLIENTE ");

                strSQL.AppendLine(" SELECT DISTINCT LAST_INSERT_ID() as ID FROM cliente;");

                objDr = dbObterRegistros(null, strSQL.ToString(), pTrans);

                if (objDr.HasRows)
                {
                    if (objDr.Read())
                    {
                        ultimoID = (long)objDr["ID"];
                    }
                }

                return ultimoID;
              
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
                strSQL = null;
            }
        }

    }
}
