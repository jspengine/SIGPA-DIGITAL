using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIGPA.INFO;
using SIGPA.DAO;

namespace SIGPA.BO
{
    public class BoManterCadastroDocumentos
    {
        public int cadastrarDocumentos(INFODocumento documento) {

            DAODocumento daoDocumento = null;
            int r = 0;
            try
            {

                // 1 - Verificar se o documento ja está cadastrado
                // 2 - Verificar se o ordenador já está cadastrado
                //Se passou por estas 2 verificações então o documento pode ser cadastrado

                daoDocumento = new DAODocumento();

                if (daoDocumento.dbjaExisteODocumentoCadstrado(documento))
                {
                    r = 1; //Está cadastrado
                }
                else if (daoDocumento.dbjaExisteoOrdenadorCadastrado(documento)){
                    r = 2; // Ordenador ja está cadastrado.
                }
                else if (daoDocumento.dbInserirDocumento(documento)){
                    r = 3; //Documento gravado com sucesso;
                    
                }

                return r;
                
            }
            catch (Exception e)
            {
                throw e;
            }
        
        }

        public int alterarDocumentos(INFODocumento documento)
        {

            DAODocumento daoDocumento = null;
            int r = 0;
            try
            {

             //Altera os documentos na base de dados

                daoDocumento = new DAODocumento();

               if (daoDocumento.dbAlterarDocumento(documento))
                {
                    r = 1; //Documento gravado com sucesso;

                }

                return r;

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public List<INFODocumento> obterListaDocumento(double pIdentificador)
        {

            DAODocumento objDocumento = null;
            try
            {
                objDocumento = new DAODocumento();

                return objDocumento.dbObterListaDocumento(pIdentificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<INFODocumento> obterListaDocumento(double pIdentificador, string categoria)
        {

            DAODocumento objDocumento = null;
            try
            {
                objDocumento = new DAODocumento();

                return objDocumento.dbObterListaDocumento(pIdentificador, categoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<INFOCategoriaProcesso> obterListaCategoriaProcesso()
        {

            DAOCategoriaProcesso daoCategoriaProcesso = null;
            try
            {
                daoCategoriaProcesso = new DAOCategoriaProcesso();

                return daoCategoriaProcesso.dbObterListaCategoriaProcessos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
