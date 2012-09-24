using System;
using System.Collections.Generic;
using System.Text;
using SIGPA.Service;
using SIGPA.DAO;
using SIGPA.INFO;

namespace SIGPA.BO
{
    public class BOManterParametros
    {
        private Log gObjLog = null;
        public BOManterParametros() {
            gObjLog = new Log("MANTER PARAMETROS");
            gObjLog.FormatoArquivo = FormatoArquivoLog.NOME_DDMMAAAA;
            gObjLog.FormatoDiretorio = FormatoDiretorioLog.MES_ANO;
        }

        public  INFOParametros boObterParametros(){
            DALParametros objDalParametros = null;
            try
            {
                objDalParametros = new DALParametros();
                return objDalParametros.dbObterParametros();

            }
            catch (Exception ex)
            {
                gObjLog.Inserir("Erro: " +  ex.ToString(), TipoLog.ERRO);
                throw ex;
            }
        }
        public Boolean boAtualizarParametros(INFOParametros pObjParametros) {
            DALParametros objDalParametros = null;
            try
            {
                objDalParametros = new DALParametros();

                return objDalParametros.dbAtualizarParametros(pObjParametros);
            }
            catch (Exception ex)
            {
                gObjLog.Inserir("Erro: " + ex.ToString(), TipoLog.ERRO);
                throw ex;
            }
        }

    }
}
