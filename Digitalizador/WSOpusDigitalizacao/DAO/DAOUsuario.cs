using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.OleDb;
using WSOpusDigitalizacao.INFO;

namespace WSOpusDigitalizacao.DAO
{
    public class DAOUsuario
    {
        private static string strConnection = null; 
        public DAOUsuario(){
            strConnection = ConfigurationManager.ConnectionStrings["SIGPA"].ConnectionString.ToString();
        }

        public wsINFOUsuario dbObterUsuario( string pUsername, string pSenha) {
            StringBuilder strSQL = null;
            OleDbConnection objConn = null;
            OleDbCommand objCmd = null;
            OleDbDataReader objDr = null;
            wsINFOUsuario objUsuario = null;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine("SELECT nome, username, privilegio ");
                strSQL.AppendLine(" FROM usuario ");
                strSQL.AppendLine(" WHERE username = '" + pUsername + "' AND senha = '" + pSenha + "'");

                objConn = new OleDbConnection(strConnection);
                objConn.Open();
                objCmd = new OleDbCommand(strSQL.ToString(), objConn);
                objDr = objCmd.ExecuteReader();

                if (objDr != null)
                {
                    if (objDr.Read())
                    {
                        objUsuario = new wsINFOUsuario();
                        
                        if (objDr["nome"] != DBNull.Value)
                        {
                            objUsuario.NomeUsuario = objDr["nome"].ToString();
                        }
                        else {
                            objUsuario.NomeUsuario = null;
                        }

                        if (objDr["privilegio"] != DBNull.Value)
                        {
                            objUsuario.PerfilUsuario = objDr["privilegio"].ToString();
                        }
                        else
                        {
                            objUsuario.PerfilUsuario = null;
                        }
                    }
                }

                return objUsuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { 
         
                if (objCmd != null )
                {
                    objCmd.Dispose();
                    objCmd = null;
                }

                if (objDr != null )
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
