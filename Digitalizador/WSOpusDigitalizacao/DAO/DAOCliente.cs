using System;
using System.Data.OleDb;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using WSOpusDigitalizacao.INFO;
using System.Text;

namespace WSOpusDigitalizacao.DAO
{
    public class DAOCliente
    {
        private static string strConnection = null; 
        public DAOCliente(){
            strConnection = ConfigurationManager.ConnectionStrings["SIGPA"].ConnectionString.ToString();
        }


        public wsINFOCliente dbObterCliente(string pNumeroProcesso)
        {
            StringBuilder strSQL = null;
            OleDbConnection objConn = null;
            OleDbCommand objCmd = null;
            OleDbDataReader objDr = null;
            wsINFOCliente objCliente = null;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine(" SELECT c.id_cliente, c.cliente, c.nome, c.cnpj, p.id_processo ");
                strSQL.AppendLine(" FROM clientes c, processos p WHERE c.id_cliente = p.id_cliente ");
                strSQL.AppendLine(" AND p.nref = '" + pNumeroProcesso + "'");

                objConn = new OleDbConnection(strConnection);
                objConn.Open();
                objCmd = new OleDbCommand(strSQL.ToString(), objConn);
                objDr = objCmd.ExecuteReader();

                if (objDr != null)
                {
                    if (objDr.Read())
                    {
                        objCliente = new wsINFOCliente();
                        
                        if (objDr["id_cliente"] != DBNull.Value)
                        {
                            objCliente.IdCliente = (int)objDr["id_cliente"];
                        }

                        if (objDr["cliente"] != DBNull.Value)
                        {
                            objCliente.NomeCliente = objDr["cliente"].ToString();
                        }
                        else {
                            objCliente.NomeCliente = null;
                        }

                        if (objDr["nome"] != DBNull.Value)
                        {
                            objCliente.NomeMapa = objDr["nome"].ToString();
                        }
                        else {
                            objCliente.NomeMapa = null;
                        }

                        if (objDr["cnpj"] != DBNull.Value)
                        {
                            objCliente.NumeroCNPJ = objDr["cnpj"].ToString();
                        }
                        else
                        {
                            objCliente.NumeroCNPJ = null;
                        }

                        if (objDr["id_processo"] != DBNull.Value)
                        {
                            objCliente.IdProcessoSigpa =(int) objDr["id_processo"];
                        }
                       
                    }
                }

                return objCliente;
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
