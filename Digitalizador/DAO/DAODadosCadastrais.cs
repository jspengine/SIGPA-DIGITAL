using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIGPA.INFO;
using MySql.Data.MySqlClient;

namespace SIGPA.DAO
{
    public class DAODadosCadastrais:DALGeneral
    {

        public long dbInserirDadosCadastrais(INFODadosCadastrais dadoscadastrais, MySqlTransaction pObjTrans)
        {
            StringBuilder strSql = new StringBuilder();
            MySqlDataReader objDr = null;
            long lastId = 0;
            try
            {
                strSql.Append("INSERT INTO DADOSCADASTRAIS (NM_ARQUIVO, NM_DIRETORIOARQUIVO, ID_DOCUMENTO, PK_ID_CLIENTE) ");
                strSql.Append("VALUES (");
                strSql.Append("'" + dadoscadastrais.Nome_arquivo + "',");
                strSql.Append("'" + dadoscadastrais.Nome_diretorio_arquivo.Replace("\\", "\\\\") + "',");
                strSql.Append(dadoscadastrais.Id_documento + ",");
                strSql.Append(dadoscadastrais.Id_cliente + ")");

                if (dbExecutarQuery(strSql.ToString(), pObjTrans) > 0)
                {
                    strSql.Remove(0, strSql.Length);
                    strSql.Append("SELECT LAST_INSERT_ID()");

                    objDr = dbObterRegistros(null, strSql.ToString(), pObjTrans);

                    if (objDr.HasRows)
                    {
                        if (objDr.Read())
                        {
                            lastId = (long)objDr[0];
                        }
                    }
                }
                return lastId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                strSql = null;
                if (!objDr.IsClosed)
                {
                    objDr.Close();
                    objDr.Dispose();
                }
                objDr = null;
            }
        }

        /// <summary>
        /// Obtem a lista dos Documentos de Dados cadastrais do cliente 
        /// </summary>
        /// <param name="pIdentificador"></param>
        /// <returns></returns>
        public List<INFODadosCadastrais> dbObterListaDocumentoDadosCadastraisdoCliente(double idcliente, double iddocumento)
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlDataReader objDr = null;
            INFODadosCadastrais dadoscadastrais = null;
            List<INFODadosCadastrais> listaDadosCadastrais = null;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine("SELECT ID_DADOSCADASTRAIS, PK_ID_CLIENTE,  NM_ARQUIVO, NM_DIRETORIOARQUIVO, ID_DOCUMENTO ");
                strSQL.AppendLine(" FROM dadoscadastrais  ");
                strSQL.AppendLine(" WHERE ID_DOCUMENTO = " + iddocumento.ToString());
                strSQL.AppendLine(" AND PK_ID_CLIENTE = " + idcliente.ToString());
                

                objConn = new MySqlConnection(gConnectionString);

                objDr = dbObterRegistros(objConn, strSQL.ToString(), null);

                if (objDr != null)
                {
                    while (objDr.Read())
                    {
                        dadoscadastrais = new INFODadosCadastrais();

                        if (objDr["ID_DADOSCADASTRAIS"] != DBNull.Value)
                        {
                            dadoscadastrais.Id_dadoscadastrais = (int)objDr["ID_DADOSCADASTRAIS"];
                        }

                        if (objDr["PK_ID_CLIENTE"] != DBNull.Value)
                        {
                            dadoscadastrais.Id_cliente = (double)objDr["PK_ID_CLIENTE"];
                        }
                       

                        if (objDr["NM_ARQUIVO"] != DBNull.Value)
                        {
                            dadoscadastrais.Nome_arquivo = (string)objDr["NM_ARQUIVO"];
                        }
                        else
                        {
                            dadoscadastrais.Nome_arquivo = null;
                        }

                        if (objDr["NM_DIRETORIOARQUIVO"] != DBNull.Value)
                        {
                            dadoscadastrais.Nome_diretorio_arquivo = (string )objDr["NM_DIRETORIOARQUIVO"];
                        }

                        if (objDr["ID_DOCUMENTO"] != DBNull.Value)
                        {
                            dadoscadastrais.Id_documento = (double)objDr["ID_DOCUMENTO"];
                        }

                        if (listaDadosCadastrais == null)
                        {
                            listaDadosCadastrais = new List<INFODadosCadastrais>();
                        }

                        listaDadosCadastrais.Add(dadoscadastrais);
                    }
                }

                return listaDadosCadastrais;
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
