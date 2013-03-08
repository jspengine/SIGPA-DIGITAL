using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Text;
using WSOpusDigitalizacao.INFO;
using System.Data.OleDb;


namespace WSOpusDigitalizacao.DAO
{
    public class DAOComunicado
    {

        private static string strConnection = null;
        public DAOComunicado()
        {
            strConnection = ConfigurationManager.ConnectionStrings["SIGPA"].ConnectionString.ToString();
        }

        /// <summary>
        /// Retorna uma lista de Comunicados
        /// </summary>
        /// <returns>Lista de Comunicados</returns>
        public List<wsINFOInformativos> obterComunicado()
        {
            StringBuilder strSQL = null;
            OleDbConnection objConn = null;
            OleDbCommand objCmd = null;
            OleDbDataReader objDr = null;
            wsINFOInformativos comunicado = null;
            List<wsINFOInformativos> listaComunicado = null;

            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine(" SELECT titulo, dt_publicacao ");
                strSQL.AppendLine(" FROM comunicado ");
                strSQL.AppendLine(" WHERE is_ativo = true ");


                objConn = new OleDbConnection(strConnection);
                objConn.Open();
                objCmd = new OleDbCommand(strSQL.ToString(), objConn);
                objDr = objCmd.ExecuteReader();

                if (objDr != null)
                {
                    listaComunicado = new List<wsINFOInformativos>();

                    while (objDr.Read())
                    {
                        comunicado = new wsINFOInformativos();

                        comunicado.Categoriainformativo = "Comunicado";


                        if (objDr["titulo"] != DBNull.Value)
                        {
                            comunicado.Resenha = objDr["titulo"].ToString().ToUpper();
                        }


                        if (objDr["dt_publicacao"] != DBNull.Value)
                        {
                            comunicado.Datapublicacao = "Data de Publicação: " + ((DateTime)objDr["dt_publicacao"]).ToString("dd/MM/yyyy"); 
                        }


                        listaComunicado.Add(comunicado);
                    }
                }

                return listaComunicado;
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