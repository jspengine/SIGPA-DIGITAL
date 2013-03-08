using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using WSOpusDigitalizacao.DAO;
using WSOpusDigitalizacao.INFO;
using System.Collections.Generic;

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

        [WebMethod(Description = "Realiza o login no SIGPA")]
        public wsINFOUsuario wsRealizarLogin(string pUser, string pSenha)
        {
            DAOUsuario objDaoUsuario = null;
            try
            {
                objDaoUsuario = new DAOUsuario();

                return objDaoUsuario.dbObterUsuario(pUser, pSenha);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [WebMethod(Description = "Consulta os processos a partir no número de referência")]
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


    }
   
}
