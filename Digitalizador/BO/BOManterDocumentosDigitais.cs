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

        private INFOHistorico boMontarHistorico( string pDescricaoOperacao, double pIdDocumentoDigital) {
            INFOHistorico objHistorico = new INFOHistorico();

            objHistorico.DescricaoOperacao = pDescricaoOperacao;
            objHistorico.NomeUsuarioResponsavel = Global.USER;
            objHistorico.ObjDocumentoDigital = new INFODocumentoDigital();
            objHistorico.ObjDocumentoDigital.IdDocumentoDigital = pIdDocumentoDigital;

            return objHistorico;

        }
    }
}
