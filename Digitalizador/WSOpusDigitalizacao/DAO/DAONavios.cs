using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using WSOpusDigitalizacao.INFO;
using System.Data.OleDb;
using System.Text;

namespace WSOpusDigitalizacao.DAO
{

    /// <summary>
    /// Esta classe é responsável por se comunicar a diversas fontes de dados para obter informações               especificas desta entidade.
    /// </summary>
    public class DAONavios
    {
        private static string strConnection = null;
        public DAONavios()
        {
            strConnection = ConfigurationManager.ConnectionStrings["SIGPA"].ConnectionString.ToString();
        }


        /// <summary>
        /// Este método é responsável por obter uma lista com os ultimos navios atracados
        /// </summary>
        /// <param name="qtdRegistrosARetornar">Indica a Quantidade de Registros a ser retornado na lista</param>
        /// <param name="qtdDiasAmonitorarParaOFuturo">
        /// Indica em quantos dias para acima e abaixo a partir da data de hoje os registros deverão ser 
        /// exibidos tendo como base a data da previsão de chegada. Exemplo: Se este parametro 
        /// receber como argumento 5 será somado cinco dias para frente e e cinco dias para trás eserão exibidos todos os 
        /// registros com previsão de chegada entre essas 2 datas. 
        ///</param>
        /// <returns>Lista com os navios que serão atracados </returns>
        public List<wsINFONavios> obterUltimosNaviosAtracados(int qtdRegistrosARetornar, 
                                                              int qtdDiasAmonitorarParaOFuturo  )
        {
            StringBuilder strSQL = null;
            OleDbConnection objConn = null;
            OleDbCommand objCmd = null;
            OleDbDataReader objDr = null;
            wsINFONavios navios = null;
            List<wsINFONavios> listanavios = null;
            try
            {
                strSQL = new StringBuilder();

                strSQL.AppendLine(" SELECT top " + qtdRegistrosARetornar + " N.navio as embarque,T.nome_terminal as terminal, N.dt_previsao_chegada as prev_chegada , N.dt_chegada  as chegada ");
                strSQL.AppendLine(" FROM navios N, terminal T ");
                strSQL.AppendLine(" WHERE  N.pk_id_terminal = T.id_terminal ");
                strSQL.AppendLine(" AND TRIM(N.pk_id_terminal) <>''") 
                    .AppendLine(" AND N.dt_previsao_chegada Is Not Null  ")
                    .AppendLine(" AND N.dt_previsao_chegada BETWEEN DateSerial(Year(Date()),Month(Date()),Day(Date()) + " + qtdDiasAmonitorarParaOFuturo.ToString() + " )") 
                    .AppendLine(" AND DateSerial(Year(Date()), Month(Date()) , Day(Date()) - " + qtdDiasAmonitorarParaOFuturo.ToString() + " )");
                strSQL.AppendLine(" ORDER BY N.dt_previsao_chegada DESC ");

                objConn = new OleDbConnection(strConnection);
                objConn.Open();
                objCmd = new OleDbCommand(strSQL.ToString(), objConn);
               

                objDr = objCmd.ExecuteReader();

                if (objDr != null)
                {
                    while (objDr.Read())
                    {
                        navios = new wsINFONavios();

                        if (objDr["embarque"] != DBNull.Value)
                        {
                            navios.Navio_embarque = (string)objDr["embarque"];
                        }

                        if (objDr["terminal"] != DBNull.Value)
                        {
                            navios.Terminal_chegada = objDr["terminal"].ToString();
                        }


                        if (objDr["prev_chegada"] != DBNull.Value)
                        {
                            navios.Data_previsao_chegada_navio = ((DateTime)objDr["prev_chegada"]).ToString("dd/MM/yyyy");
                        }


                        if (objDr["chegada"] != DBNull.Value)
                        {
                            navios.Data_chegada_navio = ((DateTime)objDr["chegada"]).ToString("dd/MM/yyyy");
                        }

                        if (listanavios == null) listanavios = new List<wsINFONavios>();

                        listanavios.Add(navios);
                    }
                }

                return listanavios;
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