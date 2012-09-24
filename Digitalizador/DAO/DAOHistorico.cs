using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using SIGPA.INFO;

namespace SIGPA.DAO
{
    public class DAOHistorico:DALGeneral
    {
        public bool dbInserirHistorico(INFOHistorico pObjHistorico, MySqlTransaction pObjTrans)
        {
            StringBuilder strSql = new StringBuilder();
            bool bolRetorno = false;
            try
            {
                strSql.Append("INSERT INTO HISTORICO(DATA_OPERACAO, DS_OPERACAO, NM_PESSOARESPONSAVEL, ID_DOCUMENTODIGITAL) ");
                strSql.Append("VALUES (Sysdate() ,");
                strSql.Append("'" + pObjHistorico.DescricaoOperacao.Replace ("\\","\\\\") + "',");
                strSql.Append("'" + pObjHistorico.NomeUsuarioResponsavel + "',");
                strSql.Append( pObjHistorico.ObjDocumentoDigital.IdDocumentoDigital + ")");

                if (dbExecutarQuery(strSql.ToString(), pObjTrans) > 0)
                {
                    bolRetorno = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                strSql = null;
            }
            return bolRetorno;
        }

    }
}
