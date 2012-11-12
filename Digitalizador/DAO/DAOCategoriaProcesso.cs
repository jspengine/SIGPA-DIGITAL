using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIGPA.INFO;
using MySql.Data.MySqlClient;

namespace SIGPA.DAO
{
   public  class DAOCategoriaProcesso : DALGeneral
    {

       public List<INFOCategoriaProcesso> dbObterListaCategoriaProcessos()
       {
           StringBuilder strSQL = null;
           MySqlConnection objConn = null;
           MySqlDataReader objDr = null;
           INFOCategoriaProcesso categoriaprocesso = null;
           List<INFOCategoriaProcesso> ListaCategoriaProcesso = null;
           try
           {
               strSQL = new StringBuilder();

               strSQL.AppendLine("SELECT id_categoriaprocesso, nm_categoriaprocesso, ds_sigla ");
               strSQL.AppendLine(" FROM categoriaprocesso  ");
               //strSQL.AppendLine(" WHERE ID_TIPODOCUMENTO = " + pIdentificador.ToString());
               //strSQL.AppendLine(" AND (DS_CATEGORIADOCUMENTO = 'S' OR DS_CATEGORIADOCUMENTO = '" + pCategoria + "')");
               //strSQL.AppendLine(" ORDER BY ID_DOCUMENTO ");

               objConn = new MySqlConnection(gConnectionString);

               objDr = dbObterRegistros(objConn, strSQL.ToString(), null);

               if (objDr != null)
               {
                   while (objDr.Read())
                   {
                       categoriaprocesso = new INFOCategoriaProcesso();

                       if (objDr["id_categoriaprocesso"] != DBNull.Value)
                       {
                           categoriaprocesso.Id_categoria= (int)objDr["id_categoriaprocesso"];
                       }

                       if (objDr["nm_categoriaprocesso"] != DBNull.Value)
                       {
                           categoriaprocesso.Nm_categoria = (string)objDr["nm_categoriaprocesso"];
                       }
                       else
                       {
                           categoriaprocesso.Nm_categoria = null;
                       }

                       if (objDr["ds_sigla"] != DBNull.Value)
                       {
                           categoriaprocesso.Ds_sigla = (string)objDr["ds_sigla"];
                       }
                       else
                       {
                           categoriaprocesso.Ds_sigla = null;
                       }

                       if (ListaCategoriaProcesso == null)
                       {
                           ListaCategoriaProcesso = new List<INFOCategoriaProcesso>();
                       }

                       ListaCategoriaProcesso.Add(categoriaprocesso);
                   }
               }

               return ListaCategoriaProcesso;
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
