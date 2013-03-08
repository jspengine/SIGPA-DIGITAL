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

        /// <summary>
        /// Obtem uma instancia do objeto [wsInfoUsuario] a partir de 2 parametros do tipo string (Usuario e senha)
        /// Este é um método de autenticação de usuário
        /// </summary>
        /// <param name="pUsername">Username do usuário no SIGPA</param>
        /// <param name="pSenha">Senha do Usuário do SIGPA</param>
        /// <returns>Um objeto [wsINFOUsuario]</returns>
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


        /// <summary>
        /// Obtem uma lista com todos os usuários que contenham data de nascimento
        /// </summary>
        /// <returns>Lista com todos os usuários </returns>
        public List<wsINFOUsuario> obterAniversariantes()
        {
            StringBuilder strSQL = null;
            OleDbConnection objConn = null;
            OleDbCommand objCmd = null;
            OleDbDataReader objDr = null;
            wsINFOUsuario aniversariantes = null;
            List<wsINFOUsuario> listaAniversariante = null;

            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine(" SELECT nome, dt_nascimento ");
                strSQL.AppendLine(" FROM usuario ");
                strSQL.AppendLine(" WHERE dt_nascimento <> null ");


                objConn = new OleDbConnection(strConnection);
                objConn.Open();
                objCmd = new OleDbCommand(strSQL.ToString(), objConn);
                objDr = objCmd.ExecuteReader();

                if (objDr != null)
                {
                    listaAniversariante = new List<wsINFOUsuario>();

                    while (objDr.Read())
                    {
                        aniversariantes = new wsINFOUsuario();

                        if (objDr["nome"] != DBNull.Value)
                        {
                            aniversariantes.NomeUsuario = objDr["nome"].ToString();
                        }


                        if (objDr["dt_nascimento"] != DBNull.Value)
                        {
                            aniversariantes.DataAniversario = (DateTime)objDr["dt_nascimento"];
                        }


                        listaAniversariante.Add(aniversariantes);
                    }
                }

                return listaAniversariante;
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


    }
}
