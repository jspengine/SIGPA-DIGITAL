using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using WSOpusDigitalizacao.DAO;
using WSOpusDigitalizacao.INFO;
using System.Web.Script.Services;
using System.Web.Script.Serialization;

namespace WSOpusDigitalizacao
{
    /// <summary>
    /// Summary description for wsPainelOperacional
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsPainelOperacional : System.Web.Services.WebService
    {


        /// <summary>
        /// Este método retorna uma lista com todas os navios que estarão ou estão sendo atracados. 
        /// </summary>
        /// <returns>
        /// Retorna um objeto javascript (JSON) com os navios atracados, conforme parametros configurados pelo administrador
        /// </returns>
        [ScriptMethod(ResponseFormat=ResponseFormat.Json)]
        [WebMethod(Description="Obtem os ultimos 10 navios atracados ")]
        public string obterNaviosAtracados() {

            DAONavios daoNavio = null;
           

            try
            {
                daoNavio = new DAONavios();

                int qtdDiasAmonitorar = int.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("qtdDiasAMonitorar"));
                int qtdRegistrosAExibirem = int.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("qtdRegistrosAExibirem"));

                JavaScriptSerializer js = new JavaScriptSerializer();
                return js.Serialize(daoNavio.obterUltimosNaviosAtracados(qtdRegistrosAExibirem, qtdDiasAmonitorar));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Mostra uma lista com os objetos Javascript com os informativos a serem mostrados
        /// site [http://www.desenvolvimento.gov.br/portalmdic/sitio/rss.php?area=5]
        /// </summary>
        /// <returns>Uma lista no formato (JSON) com ultimos posts rss </returns>
        [ScriptMethod(ResponseFormat=ResponseFormat.Json)]
        [WebMethod (Description="Mostra uma lista com os objetos Javascript com os informativos a serem mostrados " +
            "site [http://www.desenvolvimento.gov.br/portalmdic/sitio/rss.php?area=5]")]
        
        public string obterRSSParaOMonitor(){

            XmlDocument xmldocumentRSS = null;
            XmlNodeList listaNos = null;
            System.Collections.Generic.List<wsINFOInformativos> listaInformativos = 
                                new System.Collections.Generic.List<wsINFOInformativos>();
            wsINFOInformativos informativos = null;
            try
            {
                //Adcionando as postagens de noticias.
                string feedUrl = System.Configuration.ConfigurationManager.AppSettings.Get("feedUrl");
                int qtdPostsRSSAMostrar = int.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("qtdPostsRSSAMostrar"));

                xmldocumentRSS = new XmlDocument();
                xmldocumentRSS.Load(feedUrl);

                listaNos = xmldocumentRSS.SelectNodes("rss/channel/item");

                for (int i = 0; i < qtdPostsRSSAMostrar; i++)
                {
                    informativos = new wsINFOInformativos();
                    informativos.Categoriainformativo = "Informativo (RSS)";
                    informativos.Resenha = listaNos[i].ChildNodes[0].InnerText.ToUpper();
                    informativos.Datapublicacao = "Data de Publicação: " + Util.Util.dateFormatPTBR((listaNos[i].ChildNodes[1].InnerText));

                    listaInformativos.Add(informativos);
                }


            }
            catch (Exception ex)
            {
                informativos = new wsINFOInformativos();

                informativos.Categoriainformativo = "Erro";
                informativos.Resenha = "Aconteceu um ERRO: " + ex.Message;
                informativos.Datapublicacao = DateTime.Now.ToString("dd/MM/yyyy");
                listaInformativos.Add(informativos);
            }
            finally {
                xmldocumentRSS = null;
                listaNos = null;
                
            }

             JavaScriptSerializer js = new JavaScriptSerializer();

             return js.Serialize(listaInformativos);

        }

        
        /// <summary>
        /// Obtem uma lista de aniversariantes do mes 
        /// </summary>
        /// <returns>Lista de aniversariantes no formato [JSON]</returns>
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod(Description = "Obtem a lista de aniversariantes do mes a cada 5 dias", CacheDuration = 60 * 60 * 24 * 5)]
       
        public string obterAniversariantes() {

            System.Collections.Generic.List<wsINFOInformativos> listaInformativos =
                                new System.Collections.Generic.List<wsINFOInformativos>();
            wsINFOInformativos informativos = null;

            try
            {
                //Adicionando os aniversariantes do mes +++++++++++++++++++++++++++++++++++++++++++++++++++//
                DAOUsuario dao = new DAOUsuario();
                List<wsINFOUsuario> listaaniversariante = dao.obterAniversariantes();

                foreach (var aniversaraiantes in listaaniversariante)
                {
                    if (DateTime.Now.Month == aniversaraiantes.DataAniversario.Month)
                    {
                        informativos = new wsINFOInformativos();
                        informativos.Categoriainformativo = "Aniversariantes do Mês";
                        informativos.Resenha = aniversaraiantes.NomeUsuario.ToUpper();
                        informativos.Datapublicacao = "Data Aniversário: " + aniversaraiantes.DataAniversario.ToString("dd/MM/yyyy");

                        listaInformativos.Add(informativos);
                    }

                }
                //Fim aniversariantes +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

            }
            catch (Exception ex)
            {
                informativos = new wsINFOInformativos();

                informativos.Categoriainformativo = "Erro";
                informativos.Resenha = "Aconteceu um ERRO: " + ex.Message;
                informativos.Datapublicacao = DateTime.Now.ToString("dd/MM/yyyy");
                listaInformativos.Add(informativos);
            }

            JavaScriptSerializer js = new JavaScriptSerializer();

            return js.Serialize(listaInformativos);
        }


        /// <summary>
        /// Obtem uma lista de comunicados habilitados disponíveis
        /// </summary>
        /// <returns>Lista de comunicados [JSON]</returns>
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod(Description = "Obtem a lista de comunicados habilitados")]

        public string obterComunicados()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();

            return js.Serialize(new DAOComunicado().obterComunicado()); 
              
        }


        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod(Description = "Obtenho as ultimas cotações cadastradas na base de dados")]

        public string obterCotacao() {
            
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();

                return js.Serialize(new DAOCotacao().obterCotacao()); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
