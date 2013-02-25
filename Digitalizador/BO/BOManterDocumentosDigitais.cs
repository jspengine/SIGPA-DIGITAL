using System;
using System.Collections.Generic;
using System.Text;

using SIGPA.DAO;
using SIGPA.INFO;
using SIGPA.Service;

namespace SIGPA.BO
{
    public class BOManterDocumentosDigitais:BOGeneral
    {

        /// <summary>
        /// Obtem uma lista de dos documentos digitais a partir da referencia e do identificador do documento
        /// </summary>
        /// <param name="pNref"></param>
        /// <param name="pIdDocumento"></param>
        /// <returns></returns>
        public List<INFODocumentoDigital> boObterDocumentosDigitais(string pNref, double pIdDocumento){
            DAODocumentoDigital objDalDocumentoDigital = null;
            try
            {
                objDalDocumentoDigital = new DAODocumentoDigital();
                return objDalDocumentoDigital.dbObterDocumentosDigitais(pNref, pIdDocumento);

            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        /// <summary>
        /// Exclui lógicamente o documento do banco de dados
        /// </summary>
        /// <param name="pObjInfoDocumentoDigital"></param>
        /// <returns></returns>
        public bool boExcluirDocumentosDigitais(INFODocumentoDigital pObjInfoDocumentoDigital) {
            DAODocumentoDigital objDaoDocumentoDigital = null;
            DAOHistorico objDaoHistorico = null;
            bool returnValue = false;
            try
            {
                boAbrirTrasacao();

                //Excluir documento lógicamente do banco de dados
                objDaoDocumentoDigital = new DAODocumentoDigital();
                if (objDaoDocumentoDigital.dbExcluirDocumento(pObjInfoDocumentoDigital, pTrans)){
                    //Registrar histórico para exclusão    
                    objDaoHistorico = new DAOHistorico();
                    if (objDaoHistorico.dbInserirHistorico(boMontarHistorico("EXCLUSÃO DO DOCUMENTO: "+ pObjInfoDocumentoDigital.NomeArquivo + 
                                                       " NO DIRETORIO: " + pObjInfoDocumentoDigital.NomeDiretorioArquivo + ".",
                                                       pObjInfoDocumentoDigital.IdDocumentoDigital), 
                                                       pTrans)){
                        //Excluir o arquivo Fisicamente do Disco
                        string filename = pObjInfoDocumentoDigital.NomeDiretorioArquivo + pObjInfoDocumentoDigital.NomeArquivo;
                        if (System.IO.File.Exists(filename))
                        {
                            System.IO.File.Delete(filename);
                        }
                        boCommit();
                        returnValue = true;

                    }
                }//else boRollBack();       
            }
            catch (Exception ex)
            {
                boRollBack();
                throw ex;
            }
            finally{
                objDaoDocumentoDigital = null;
                objDaoHistorico = null;
            }
            return returnValue;
        }

        /// <summary>
        /// Exclui da base de dados os dados cadastrais
        /// </summary>
        /// <param name="dadoscadastrais"></param>
        /// <returns></returns>
        public bool boExcluirDadosCadastrais(INFODadosCadastrais dadoscadastrais)
        {
            DAODadosCadastrais daoDadosCadastrais = null;
            DAOHistorico objDaoHistorico = null;
            bool returnValue = false;
            try
            {
                boAbrirTrasacao();

                //Excluir documento lógicamente do banco de dados
                daoDadosCadastrais = new DAODadosCadastrais();
                if (daoDadosCadastrais.dbExcluirDadosCadastrais(dadoscadastrais, pTrans))
                {
                    //Registrar histórico para exclusão    
                    objDaoHistorico = new DAOHistorico();
                    if (objDaoHistorico.dbInserirHistorico(boMontarHistorico("EXCLUSÃO DO DOCUMENTO: " + dadoscadastrais.Nome_arquivo +
                                                       " NO DIRETORIO: " + dadoscadastrais.Nome_diretorio_arquivo + ".",
                                                       dadoscadastrais.Id_dadoscadastrais),
                                                       pTrans))
                    {
                        //Excluir o arquivo Fisicamente do Disco
                        string filename = dadoscadastrais.Nome_diretorio_arquivo + dadoscadastrais.Nome_arquivo;
                        if (System.IO.File.Exists(filename))
                        {
                            System.IO.File.Delete(filename);
                        }
                        boCommit();
                        returnValue = true;

                    }
                }//else boRollBack();       
            }
            catch (Exception ex)
            {
                boRollBack();
                throw ex;
            }
            finally
            {
                daoDadosCadastrais = null;
                objDaoHistorico = null;
            }
            return returnValue;
        }


        /// <summary>
        /// Realizo a alteração do documento digitalizado
        /// </summary>
        /// <param name="pObjInfoDocumentoDigital"></param>
        /// <param name="strPathTmp"></param>
        /// <returns></returns>
        public bool boAtualizarDocumentosDigitais(INFODocumentoDigital pObjInfoDocumentoDigital, string strPathTmp)
        {
            DAODocumentoDigital objDaoDocumentoDigital = null;
            DAOHistorico objDaoHistorico = null;
            bool returnValue = false;
            try
            {
                boAbrirTrasacao();

                //Excluir documento lógicamente do banco de dados
                objDaoDocumentoDigital = new DAODocumentoDigital();
                if (objDaoDocumentoDigital.dbAlterarDocumento(pObjInfoDocumentoDigital, pTrans))
                {
                    //Registrar histórico para exclusão    
                    objDaoHistorico = new DAOHistorico();
                    if (objDaoHistorico.dbInserirHistorico(boMontarHistorico("ALTERAÇÃO DO DOCUMENTO: " + pObjInfoDocumentoDigital.NomeArquivo +
                                                       " NO DIRETORIO: " + pObjInfoDocumentoDigital.NomeDiretorioArquivo + ".",
                                                       pObjInfoDocumentoDigital.IdDocumentoDigital),
                                                       pTrans))
                    {
                        //Altera o arquivo Fisicamente do Disco
                        string strFile = pObjInfoDocumentoDigital.NomeDiretorioArquivo + pObjInfoDocumentoDigital.NomeArquivo;
                        if (System.IO.File.Exists(strFile)) System.IO.File.Delete(strFile);

                        string PdfTemp = strPathTmp + pObjInfoDocumentoDigital.NomeArquivo;
                        System.IO.File.Move(PdfTemp , strFile );

                        
                        //Chamar o componente para digitalização

                        boCommit();
                        returnValue = true;
                    }
                }
                else boRollBack();
            }
            catch (Exception ex)
            {
                boRollBack();
                throw ex;
            }
            finally
            {
                objDaoDocumentoDigital = null;
                objDaoHistorico = null;
            }
            return returnValue;
        }


        /// <summary>
        /// monto o objeto de histórico da operação realizada
        /// </summary>
        /// <param name="pDescricaoOperacao"></param>
        /// <param name="pIdDocumentoDigital"></param>
        /// <returns></returns>
        private INFOHistorico boMontarHistorico( string pDescricaoOperacao, double pIdDocumentoDigital) {
            INFOHistorico objHistorico = new INFOHistorico();

            objHistorico.DescricaoOperacao = pDescricaoOperacao;
            objHistorico.NomeUsuarioResponsavel = Global.USER;
            objHistorico.ObjDocumentoDigital = new INFODocumentoDigital();
            objHistorico.ObjDocumentoDigital.IdDocumentoDigital = pIdDocumentoDigital;

            return objHistorico;

        }


        /// <summary>
        /// Obtem uma lista de dados cadastrais que ja foram digitalizados a partir do id do cliente e id do documento
        /// </summary>
        /// <param name="idcliente"></param>
        /// <param name="iddocumento"></param>
        /// <returns></returns>
        public List<INFODadosCadastrais> obterDocumentosDadosCadastraisDigitalizados(double idcliente, double iddocumento)
        {
            DAODadosCadastrais daoDadosCadastrais = null;
            try
            {
                daoDadosCadastrais = new DAODadosCadastrais();
                return daoDadosCadastrais.dbObterListaDocumentoDadosCadastraisdoCliente(idcliente, iddocumento);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
