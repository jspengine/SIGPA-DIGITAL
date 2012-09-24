using System;
using System.Collections.Generic;
using System.Text;
using SIGPA.DAO;
using SIGPA.Service;
using SIGPA.BO.wsSigpaDigitalizador;
using System.Configuration;
using SIGPA.INFO;


namespace SIGPA.BO
{
    public class BORealizarLogin
    {

        public INFOUsuario boRealizarLogin(string pUser, string pSenha)
        {
           WsConsultarProcesso wsConsulta = null;
           INFOUsuario objUsuario = null;
           wsINFOUsuario objWsInfoUsuario = null;
            try
            {
                wsConsulta = new WsConsultarProcesso();
               
                wsConsulta.Url = System.Configuration.ConfigurationManager.AppSettings["URLWSSIGPA"].ToString();
                //wsConsulta.Timeout = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["TIMEOUT"]);

                objWsInfoUsuario = wsConsulta.wsRealizarLogin(pUser, pSenha);

                if (objWsInfoUsuario != null)
                {
                    Global.USER = objWsInfoUsuario.NomeUsuario;
                    Global.PERFIL = objWsInfoUsuario.PerfilUsuario;
                    
                    objUsuario = new INFOUsuario();
                    objUsuario.NomeUsuario = objWsInfoUsuario.NomeUsuario;
                    objUsuario.PerfilUsuario = objWsInfoUsuario.PerfilUsuario;
                }
                 
                return objUsuario;
                
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
    }
}
