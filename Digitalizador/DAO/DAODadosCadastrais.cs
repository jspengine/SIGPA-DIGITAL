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

    }
}
