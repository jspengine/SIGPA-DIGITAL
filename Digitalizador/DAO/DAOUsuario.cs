using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using MySql.Data.MySqlClient;
using SIGPA.INFO;

namespace SIGPA.DAO
{
    public class DAOUsuario
    {
        private static string strConnection = null; 
        public DAOUsuario(){
            strConnection = ConfigurationManager.ConnectionStrings["SIGPA"].ConnectionString.ToString();
        }

        public INFOUsuario dbObterUsuario( string pUsername, string pSenha) {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlCommand objCmd = null;
            MySqlDataReader objDr = null;
            INFOUsuario objUsuario = null;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine("SELECT nome, username, privilegio ");
                strSQL.AppendLine(" FROM usuario ");
                strSQL.AppendLine(" WHERE username = ? AND senha = ?");

                objConn = new MySqlConnection(strConnection);
                objConn.Open();
                objCmd = new MySqlCommand(strSQL.ToString(), objConn);
                int i = 0;

                objCmd.Parameters.Insert(++i, pUsername);
                objCmd.Parameters.Insert(++i, pSenha);
                

                objDr = objCmd.ExecuteReader();

                if (objDr != null)
                {
                    if (objDr.Read())
                    {
                        objUsuario = new INFOUsuario();
                        
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
