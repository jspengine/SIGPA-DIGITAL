using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.OleDb;
using WSOpusDigitalizacao.INFO;
using System.Text;

namespace WSOpusDigitalizacao.DAO
{
    public class DAOCotacao
    {

        private static string strConnection = null;
        public DAOCotacao()
        {
            strConnection = ConfigurationManager.ConnectionStrings["SIGPA"].ConnectionString.ToString();
        }

        public List<INFOCotacao> obterCotacao()
        {
            StringBuilder strSQL = null;
            OleDbConnection objConn = null;
            OleDbCommand objCmd = null;
            OleDbDataReader objDr = null;
            INFOCotacao cotacao = null;
            List<INFOCotacao> listacotacao = null;

            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine(" SELECT top 10 dt_cotacao, euz, cnm, usd ");
                strSQL.AppendLine(" FROM cotacao ");
                strSQL.AppendLine(" ORDER BY dt_cotacao DESC ");
               


                objConn = new OleDbConnection(strConnection);
                objConn.Open();
                objCmd = new OleDbCommand(strSQL.ToString(), objConn);
                objDr = objCmd.ExecuteReader();

                if (objDr != null)
                {
                    listacotacao = new List<INFOCotacao>();

                    while (objDr.Read())
                    {
                        cotacao = new INFOCotacao();

                        if (objDr["dt_cotacao"] != DBNull.Value)
                        {
                            cotacao.Data = ((DateTime)objDr["dt_cotacao"]).ToString("dd/MM");
                        }


                        if (objDr["euz"] != DBNull.Value)
                        {
                            cotacao.Valor_euz = objDr["euz"].ToString();
                        }

                        if (objDr["cnm"] != DBNull.Value)
                        {
                            cotacao.Valor_cnm = objDr["cnm"].ToString();
                        }

                        if (objDr["usd"] != DBNull.Value)
                        {
                            cotacao.Valor_usd = objDr["usd"].ToString();
                        }


                        listacotacao.Add(cotacao);
                    }
                }

                return listacotacao;
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