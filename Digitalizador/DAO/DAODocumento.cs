using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text;
using SIGPA.INFO;

namespace SIGPA.DAO
{
    public class DAODocumento:DALGeneral
    {
        public List<INFODocumento> dbObterListaDocumento(double pIdentificador, string pCategoria)
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlDataReader objDr = null;
            INFODocumento objDocumento = null;
            List<INFODocumento> ListaDocumento = null;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine("SELECT ID_DOCUMENTO, NM_DOCUMENTO, DS_CATEGORIADOCUMENTO, NR_ORDEM ");
                strSQL.AppendLine(" FROM documento  ");
                strSQL.AppendLine(" WHERE ID_TIPODOCUMENTO = " + pIdentificador.ToString());
                strSQL.AppendLine(" AND (DS_CATEGORIADOCUMENTO = 'S' OR DS_CATEGORIADOCUMENTO = '" + pCategoria + "')");
                strSQL.AppendLine(" ORDER BY NR_ORDEM ASC");

                objConn = new MySqlConnection(gConnectionString);

                objDr = dbObterRegistros(objConn, strSQL.ToString(), null);

                if (objDr != null)
                {
                    while (objDr.Read())
                    {
                        objDocumento = new INFODocumento();

                        if (objDr["ID_DOCUMENTO"] != DBNull.Value)
                        {
                            objDocumento.IdDocumentos = (double)objDr["ID_DOCUMENTO"];
                        }

                        if (objDr["NM_DOCUMENTO"] != DBNull.Value)
                        {
                            objDocumento.NomeDocumento = (string)objDr["NM_DOCUMENTO"];
                        }
                        else
                        {
                            objDocumento.NomeDocumento = null;
                        }

                        if (objDr["DS_CATEGORIADOCUMENTO"] != DBNull.Value)
                        {
                            objDocumento.Categoriadocumento= (string)objDr["DS_CATEGORIADOCUMENTO"];
                        }
                        else
                        {
                            objDocumento.Categoriadocumento = null;
                        }

                        if (objDr["NR_ORDEM"] != DBNull.Value)
                        {
                            objDocumento.Ordemdocumento= (int)objDr["NR_ORDEM"];
                        }
                       

                        if (ListaDocumento == null)
                        {
                            ListaDocumento = new List<INFODocumento>();
                        }

                        ListaDocumento.Add(objDocumento);
                    }
                }

                return ListaDocumento;
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


        public List<INFODocumento> dbObterListaDocumento(double pIdentificador)
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlDataReader objDr = null;
            INFODocumento objDocumento = null;
            List<INFODocumento> ListaDocumento = null;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine("SELECT ID_DOCUMENTO, NM_DOCUMENTO, DS_CATEGORIADOCUMENTO, NR_ORDEM ");
                strSQL.AppendLine(" FROM documento  ");
                strSQL.AppendLine(" WHERE ID_TIPODOCUMENTO = " + pIdentificador.ToString());
                //strSQL.AppendLine(" AND (DS_CATEGORIADOCUMENTO = 'S' OR DS_CATEGORIADOCUMENTO = '" + pCategoria + "')");
                strSQL.AppendLine(" ORDER BY NR_ORDEM ASC");

                objConn = new MySqlConnection(gConnectionString);

                objDr = dbObterRegistros(objConn, strSQL.ToString(), null);

                if (objDr != null)
                {
                    while (objDr.Read())
                    {
                        objDocumento = new INFODocumento();

                        if (objDr["ID_DOCUMENTO"] != DBNull.Value)
                        {
                            objDocumento.IdDocumentos = (double)objDr["ID_DOCUMENTO"];
                        }

                        if (objDr["NM_DOCUMENTO"] != DBNull.Value)
                        {
                            objDocumento.NomeDocumento = (string)objDr["NM_DOCUMENTO"];
                        }
                        else
                        {
                            objDocumento.NomeDocumento = null;
                        }

                        if (objDr["DS_CATEGORIADOCUMENTO"] != DBNull.Value)
                        {
                            objDocumento.Categoriadocumento = (string)objDr["DS_CATEGORIADOCUMENTO"];
                        }
                        else
                        {
                            objDocumento.Categoriadocumento = null;
                        }

                        if (objDr["NR_ORDEM"] != DBNull.Value)
                        {
                            objDocumento.Ordemdocumento = (int)objDr["NR_ORDEM"];
                        }


                        if (ListaDocumento == null)
                        {
                            ListaDocumento = new List<INFODocumento>();
                        }

                        ListaDocumento.Add(objDocumento);
                    }
                }

                return ListaDocumento;
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
        

        //Verifica se existe o mesmo documento ja cadastrado para o Tipo de documento e tipo de processo

        public Boolean dbjaExisteODocumentoCadstrado(INFODocumento documento)
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlCommand cmd = null;
            MySqlDataReader objDr = null;
            //INFODocumento objDocumento = null;
            Boolean r = false;
                 
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine("SELECT COUNT(1) AS CONT ");
                strSQL.AppendLine(" FROM documento  ");
                strSQL.AppendLine(" WHERE ID_TIPODOCUMENTO = ?id_tipodocumento  ") ;
                //trSQL.AppendLine(" AND DS_CATEGORIADOCUMENTO = ?ds_categoria");
                strSQL.AppendLine(" AND NM_DOCUMENTO = ?nm_documento");
           

                objConn = new MySqlConnection(gConnectionString);
                objConn.Open();
                cmd = new MySqlCommand(strSQL.ToString(), objConn);

                cmd.Parameters.Add("?id_tipodocumento", MySqlDbType.Double).Value = documento.ObjTipoDocumento.IdTipoDocumento;
               // cmd.Parameters.Add("?ds_categoria", MySqlDbType.VarChar).Value = documento.Categoriadocumento;
                cmd.Parameters.Add("?nm_documento", MySqlDbType.VarChar).Value = documento.NomeDocumento;

                objDr = cmd.ExecuteReader();


                //objDr = dbObterRegistros(objConn, strSQL.ToString(), null);

                if (objDr != null)
                {
                    while (objDr.Read())
                    {
                        r = ((long)objDr["CONT"] > 0 ) ? true : false ;
                  
                    }
                }

                return r;
                
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


        //Verifica se o documento ja está com o seu ordenador cadastrado [evitar Duplicidade no ordenador]

        public Boolean dbjaExisteoOrdenadorCadastrado(INFODocumento documento)
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlCommand cmd = null;
            MySqlDataReader objDr = null;
            //INFODocumento objDocumento = null;
            Boolean r = false;

            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine("SELECT COUNT(1) AS CONT ");
                strSQL.AppendLine(" FROM documento  ");
                strSQL.AppendLine(" WHERE ID_TIPODOCUMENTO = ?id_tipodocumento  ");
                //strSQL.AppendLine(" AND DS_CATEGORIADOCUMENTO = ?ds_categoria");
                strSQL.AppendLine(" AND NR_ORDEM = ?nr_ordem");


                objConn = new MySqlConnection(gConnectionString);
                objConn.Open();
                cmd = new MySqlCommand(strSQL.ToString(), objConn);

                cmd.Parameters.Add("?id_tipodocumento", MySqlDbType.Double).Value = documento.ObjTipoDocumento.IdTipoDocumento;
               //cmd.Parameters.Add("?ds_categoria", MySqlDbType.VarChar).Value = objDocumento.Categoriadocumento;
                cmd.Parameters.Add("?nr_ordem", MySqlDbType.Int32).Value = documento.Ordemdocumento;

                objDr = cmd.ExecuteReader();


                //objDr = dbObterRegistros(objConn, strSQL.ToString(), null);

                if (objDr != null)
                {
                    while (objDr.Read())
                    {
                        r = ((long)objDr["CONT"] > 0) ? true : false;

                    }
                }

                return r;

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


        //Insersão de Registro na tabela Documento
        public bool dbInserirDocumento(INFODocumento objDocumento)
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlCommand objCmd = null;

            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine(" INSERT INTO documento (ID_TIPODOCUMENTO, NM_DOCUMENTO, DS_CATEGORIADOCUMENTO, NR_ORDEM  )").
                       AppendLine(" VALUES ( ?id_tipodocumento, ?nm_documento, ?ds_categoriadocumento, ?nr_ordem  ) ");


                objConn = new MySqlConnection(gConnectionString);
                objConn.Open();
                objCmd = new MySqlCommand(strSQL.ToString(), objConn);

                objCmd.Parameters.Add("?id_tipodocumento", MySqlDbType.Double).Value = objDocumento.ObjTipoDocumento.IdTipoDocumento;
                objCmd.Parameters.Add("?nm_documento", MySqlDbType.VarChar).Value = objDocumento.NomeDocumento;
                objCmd.Parameters.Add("?ds_categoriadocumento", MySqlDbType.VarChar).Value = objDocumento.Categoriadocumento;
                objCmd.Parameters.Add("?nr_ordem", MySqlDbType.Int32).Value = objDocumento.Ordemdocumento;


                return (objCmd.ExecuteNonQuery() > 0) ? true : false;

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

                if (objConn.State == System.Data.ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                    objConn = null;
                }

                strSQL = null;
            }
        }


        //Alteração de Registro na tabela Documento
        public bool dbAlterarDocumento(INFODocumento objDocumento)
        {
            StringBuilder strSQL = null;
            MySqlConnection objConn = null;
            MySqlCommand objCmd = null;

            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine(" UPDATE documento SET " )
                      .AppendLine(" ID_TIPODOCUMENTO = ?id_tipodocumento ,")
                      .AppendLine(" NM_DOCUMENTO = ?nm_documento, " )
                      .AppendLine(" DS_CATEGORIADOCUMENTO = ?ds_categoriadocumento,")
                      .AppendLine(" NR_ORDEM =?nr_ordem  ")
                      .AppendLine("WHERE ID_DOCUMENTO = ?id_documento");
                 


                objConn = new MySqlConnection(gConnectionString);
                objConn.Open();
                objCmd = new MySqlCommand(strSQL.ToString(), objConn);

                objCmd.Parameters.Add("?id_tipodocumento", MySqlDbType.Double).Value = objDocumento.ObjTipoDocumento.IdTipoDocumento;
                objCmd.Parameters.Add("?nm_documento", MySqlDbType.VarChar).Value = objDocumento.NomeDocumento;
                objCmd.Parameters.Add("?ds_categoriadocumento", MySqlDbType.VarChar).Value = objDocumento.Categoriadocumento;
                objCmd.Parameters.Add("?nr_ordem", MySqlDbType.Int32).Value = objDocumento.Ordemdocumento;
                objCmd.Parameters.Add("?id_documento", MySqlDbType.Double).Value = objDocumento.IdDocumentos;


                return (objCmd.ExecuteNonQuery() > 0) ? true : false;

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
