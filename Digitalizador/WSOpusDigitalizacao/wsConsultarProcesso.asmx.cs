using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using WSOpusDigitalizacao.DAO;
using WSOpusDigitalizacao.INFO;

namespace WSOpusDigitalizacao
{
    /// <summary>
    /// Summary description for WsConsultarProcesso
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WsConsultarProcesso : System.Web.Services.WebService
    {

        [WebMethod]
        public wsINFOUsuario wsRealizarLogin(string pUser, string pSenha)
        {
            DAOUsuario objDaoUsuario = null;
            try
            {
                objDaoUsuario = new DAOUsuario() ;

                return objDaoUsuario.dbObterUsuario(pUser, pSenha);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        [WebMethod]
        public wsINFOCliente wsConsultarProcesso(string pNumeroProcesso)
        {
            DAOCliente objDalCliente = null;
            try
            {
                objDalCliente = new DAOCliente();

                return objDalCliente.dbObterCliente(pNumeroProcesso);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


      
        /// <summary>
        /// Este método retorna uma lista com todas os navios que estarão ou estão sendo atracados. 
        /// </summary>
        /// <returns>
        /// Retorna um objeto javascript (JSON) com os navios atracados, conforme parametros configurados pelo administrador
        /// </returns>
        [ScriptMethod(ResponseFormat=ResponseFormat.Json)]
        [WebMethod]
        public string obterNaviosAtracados() {

            DAONavios daoNavio = null;
           

            try
            {
                daoNavio = new DAONavios();

                int qtdDiasAmonitorar = int.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("qtdDiasAMonitorar"));
                int qtdRegistrosAExibirem = int.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("qtdRegistrosAExibirem"));

                JavaScriptSerializer js = new JavaScriptSerializer();
                return js.Serialize(daoNavio.obterUltimosNaviosAtracados(qtdDiasAmonitorar, qtdRegistrosAExibirem));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

    }
}
