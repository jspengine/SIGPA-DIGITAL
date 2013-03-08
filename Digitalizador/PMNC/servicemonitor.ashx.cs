using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PMNC.MonitoramentoPainel;

namespace PMNC
{
    /// <summary>
    /// Summary description for servicemonitor
    /// </summary>
    public class servicemonitor : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            int actionrequest = int.Parse(context.Request["optype"]);
            try
            {

                switch (actionrequest)
                {
                    case 1:
                        context.Response.Write(obterRss());
                        break;
                    case 2:
                        context.Response.Write(obterAniversariantes());
                        break;
                    case 3:
                        context.Response.Write(obterComunicados());
                        break;
                    case 4:
                        context.Response.Write(obterNavios());
                        break;
                    case 5:
                        context.Response.Write(obterCotacao());
                        break;
                    default:
                        break;
                }



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        /// <summary>
        /// Obtem a lista de Posts Rss a partir do WebService
        /// </summary>
        /// <returns>Lista de Post [JSON Format]</returns>
        private string obterRss()
        {

            wsPainelOperacional wsConsultar = null;
            try
            {
                wsConsultar = new wsPainelOperacional();
                //wsConsultar.Url = System.Configuration.ConfigurationManager.AppSettings.Get("URLWebServiceMonitor").ToString()
                return wsConsultar.obterRSSParaOMonitor();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Obtem a lista de Aniversariantes do mês
        /// </summary>
        /// <returns>Uma lista de Objetos [JSON] com Aniversariantes do mes</returns>
        private string obterAniversariantes() {
            wsPainelOperacional wsConsultar = null;
            try
            {
                wsConsultar = new wsPainelOperacional();
                
                return wsConsultar.obterAniversariantes();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// Obtem os comunicados habilitados 
        /// </summary>
        /// <returns>lista de Objetos comunicados em formato[JSON]</returns>
        private string obterComunicados() {
            wsPainelOperacional ws = null;
            try
            {
                ws = new wsPainelOperacional();
                return ws.obterComunicados();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Obtem os 10 navios que estão próximos de chegar
        /// </summary>
        /// <returns>Lista de Navios a chegar no formato [JSON]</returns>
        private string obterNavios() {
            wsPainelOperacional ws = null;
            try
            {
                ws = new wsPainelOperacional();
                return ws.obterNaviosAtracados();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private string obterCotacao()
        {
            wsPainelOperacional ws = null;
            try
            {
                ws = new wsPainelOperacional();
                return ws.obterCotacao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}