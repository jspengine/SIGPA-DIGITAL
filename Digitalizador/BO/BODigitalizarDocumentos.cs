using System;
using System.Collections.Generic;
using System.Text;
using SIGPA.DAO;
using SIGPA.INFO;
using SIGPA.BO.wsSigpaDigitalizador;
using SIGPA.Service;


namespace SIGPA.BO
{

    public class BODigitalizarDocumentos:BOGeneral
    {
        public BODigitalizarDocumentos() { 

        
        }

        public bool boDigitalizarDocumentos(string pPathFileTmp, 
                                            string pDirName, 
                                            string pFileName, 
                                            double idDocumento, 
                                            double idProcesso)
        {
            String pDirFile = string.Empty;
            DAODocumentoDigital objDaoDocumentoDigital = null;
            INFODocumentoDigital objInfoDocumentoDigital = null;
            DALParametros objParametros = null;
            INFOParametros objInfoParametros = null;
            DAOHistorico objDaoHistorico = null;
            INFOHistorico objInfoHistorico = null;
            long idDocumentoDigital;
            bool returnvalue =false;
            try
            {
                boAbrirTrasacao();
                
                //Salvo o Path do arquivo na base de dados
                objInfoDocumentoDigital = new INFODocumentoDigital();
                objInfoDocumentoDigital.NomeArquivo = pFileName;
                objInfoDocumentoDigital.NomeDiretorioArquivo = pDirName;
                objInfoDocumentoDigital.IdDocumento = idDocumento;
                objInfoDocumentoDigital.IdProcesso = idProcesso;
                
                objDaoDocumentoDigital = new DAODocumentoDigital();

                idDocumentoDigital = objDaoDocumentoDigital.dbInserirDocumentos(objInfoDocumentoDigital, pTrans);
                //Descrevo a operação para guardar o histórico

                objInfoHistorico = new INFOHistorico();
                objInfoHistorico.DescricaoOperacao = "DIGITALIZAÇÃO DO DOCUMENTO: "+ pFileName.ToUpper() +" NO DIRETÓRIO: " + pDirName.ToUpper();
                objInfoHistorico.NomeUsuarioResponsavel = Global.USER;
                objInfoHistorico.ObjDocumentoDigital = new INFODocumentoDigital();
                objInfoHistorico.ObjDocumentoDigital.IdDocumentoDigital = idDocumentoDigital;

                objDaoHistorico = new DAOHistorico();
                if (objDaoHistorico.dbInserirHistorico(objInfoHistorico, pTrans))
                {
                    objParametros = new DALParametros();
                    objInfoParametros = new INFOParametros();

                    //Atualizo o contador em parametros
                    objInfoParametros.NumeroContador = objParametros.dbObterParametros().NumeroContador;
                    if (objParametros.dbAtualizarContador(objInfoParametros, pTrans))
                    {
                        //Move de PDF file of the Directory Tmp for your destination.
                        pDirFile = pDirName + pFileName;

                        if (System.IO.File.Exists(pDirFile)) System.IO.File.Delete(pDirFile);
                        
                        System.IO.File.Move(pPathFileTmp, pDirFile);
                        //SaveToDisk(pImage, pDirFile);
                        boCommit();
                        returnvalue = true;
                    }
                    //else boRollBack(); returnvalue = false;
                }
               // else boRollBack(); returnvalue = false;

                return returnvalue;

            }
            catch (Exception ex)
            {
                boRollBack();
                throw ex;
            }
            finally {
                objDaoDocumentoDigital = null;
                objInfoDocumentoDigital = null;
                objParametros = null;
                objInfoParametros = null;
                objDaoHistorico = null;
                objInfoHistorico = null;
            }
            
        }

        /* Guardando as informações dos documentos de dados cadastrais do cliente digitalidados na base de dados
         * Este procedimento é necessário porque os dados cadastrais do cliente são 
         * informações do cliente e não informações do processo
         */
        public bool boDigitalizarDadosCadastrais(
                                    string pPathFileTmp,
                                    string pDirName,
                                    string pFileName,
                                    double idDocumento,
                                    double idCliente)
        {
            String pDirFile = string.Empty;
            DAODadosCadastrais daoDadosCadstrais = null;
            INFODadosCadastrais dadoscadastrais = null;
            DALParametros objParametros = null;
            INFOParametros objInfoParametros = null;
            DAOHistorico objDaoHistorico = null;
            INFOHistorico objInfoHistorico = null;
            long idDocumentoDigital;
            bool returnvalue = false;
            try
            {
                boAbrirTrasacao();

                //Salvo o Path do arquivo na base de dados na Tabela dados Cadastrais


                dadoscadastrais = new INFODadosCadastrais();
                dadoscadastrais.Nome_arquivo = pFileName;
                dadoscadastrais.Nome_diretorio_arquivo = pDirName;
                dadoscadastrais.Id_documento = idDocumento;
                dadoscadastrais.Id_cliente = idCliente;

                daoDadosCadstrais = new DAODadosCadastrais();

                //idDocumentoDigital = objDaoDocumentoDigital.dbInserirDocumentos(dadoscadastrais, pTrans);
                idDocumentoDigital = daoDadosCadstrais.dbInserirDadosCadastrais(dadoscadastrais, pTrans);
                //Descrevo a operação para guardar o histórico

                objInfoHistorico = new INFOHistorico();
                objInfoHistorico.DescricaoOperacao = "DIGITALIZAÇÃO DO DOCUMENTO DE DADOS CADASTRAIS: " + pFileName.ToUpper() + " NO DIRETÓRIO: " + pDirName.ToUpper();
                objInfoHistorico.NomeUsuarioResponsavel = Global.USER;
                objInfoHistorico.ObjDocumentoDigital = new INFODocumentoDigital();
                objInfoHistorico.ObjDocumentoDigital.IdDocumentoDigital = idDocumentoDigital;

                objDaoHistorico = new DAOHistorico();
                if (objDaoHistorico.dbInserirHistorico(objInfoHistorico, pTrans))
                {
                    objParametros = new DALParametros();
                    objInfoParametros = new INFOParametros();

                    //Atualizo o contador em parametros
                    objInfoParametros.NumeroContador = objParametros.dbObterParametros().NumeroContador;
                    if (objParametros.dbAtualizarContador(objInfoParametros, pTrans))
                    {
                        //Move de PDF file of the Directory Tmp for your destination.
                        pDirFile = pDirName + pFileName;

                        if (System.IO.File.Exists(pDirFile)) System.IO.File.Delete(pDirFile);

                        System.IO.File.Move(pPathFileTmp, pDirFile);
                        //SaveToDisk(pImage, pDirFile);
                        boCommit();
                        returnvalue = true;
                    }
                    //else boRollBack(); returnvalue = false;
                }
                // else boRollBack(); returnvalue = false;

                return returnvalue;

            }
            catch (Exception ex)
            {
                boRollBack();
                throw ex;
            }
            finally
            {
                daoDadosCadstrais = null;
                dadoscadastrais = null;
                objParametros = null;
                objInfoParametros = null;
                objDaoHistorico = null;
                objInfoHistorico = null;
            }

        }


        public INFOCliente boSincronizarBaseSIGPA(string pStrNref)
        {
            DAOProcesso objDaoProcesso = null;
            DAOCliente objDaoCliente = null;
            
            INFOCliente objCliente = null;
            INFOCliente objClienteSigpa = null;
            INFOProcesso objProcesso = null;

            wsINFOCliente objWsCliente = null;
            

            try
            {
                objDaoProcesso = new DAOProcesso();
                //Sincroniza os dados entre o SIGPA e o SIGPA_DIGITAL

                //Pesquiso o processo na base local

                //Processo Existe na base local
                objProcesso = objDaoProcesso.dbObterProcesso(pStrNref);
                if (objProcesso != null )
                {
                    //Achei o Processo então ele existe no SIGPA_DIGITAL 
                    //Mostro os dados na tela
                    objCliente = objProcesso.ObjCliente;
                    objCliente.ObjProcesso = new List<INFOProcesso>();
                    objCliente.ObjProcesso.Add(objProcesso);
                    return objCliente;
                }
                else {
                    //Processo não existe na base Local 
                    //vou buscar o processo no web service

                    WsConsultarProcesso objWs = new WsConsultarProcesso();
                    objWs.Url = System.Configuration.ConfigurationManager.AppSettings["URLWSSIGPA"].ToString();

                    if (Service.Ultil.verifyWebService() == false ) {

                        throw new Exception("Talvez o WEBSERVICE de Integração com o SIGPA esteja off line, por favor contate o adminstrador do sistema");     
                    }

                    objWsCliente = objWs.wsConsultarProcesso(pStrNref);

                    if (objWsCliente != null)
                    {
                        objCliente = new INFOCliente();
                        objProcesso = new INFOProcesso();

                        objCliente.IdClienteSigpa = objWsCliente.IdCliente;
                        objCliente.NomeCliente = objWsCliente.NomeCliente;
                        objCliente.NomeClienteMapa = objWsCliente.NomeMapa;
                        objCliente.NumeroCnpj = objWsCliente.NumeroCNPJ;
                        objCliente.NumeroCpf = objWsCliente.NumeroCPF;

                        objProcesso.IdProcessoSigpa = objWsCliente.IdProcessoSigpa;
                        objProcesso.NumeroReferencia = pStrNref;

                        //Gravo o id_cliente, nome do cliente, nome mapa, e cnpj/cpf além do processo na base do SIGPA_DIGITAL
                        objDaoCliente = new DAOCliente();
                        //Abro a transação com o banco de dados
                        boAbrirTrasacao();
                       
                        //Tenho que verificar se o cliente ja está cadastro para não cadastra-lo novamente
                        objClienteSigpa = objDaoCliente.dbObterClientePorIDSigpa(objCliente.IdClienteSigpa);

                        if (objClienteSigpa == null)
                        {
                            if (objDaoCliente.dbInserirCliente(objCliente, pTrans))
                            {
                                //Insiro também o processo

                                //objCliente.IdCliente = objDaoCliente.dbObterCliente();
                                objProcesso.ObjCliente = new INFOCliente();
                                objProcesso.ObjCliente.IdCliente = objDaoCliente.dbObterUltimoID(pTrans);
                                if (objDaoProcesso.dbInserirProcesso(objProcesso, pTrans))
                                {
                                    boCommit();
                                }
                            }
                        }
                        else {
                            //Insiro somente o processo
                            objProcesso.ObjCliente = new INFOCliente();
                            objProcesso.ObjCliente.IdCliente = objClienteSigpa.IdCliente ;
                            if (objDaoProcesso.dbInserirProcesso(objProcesso, pTrans))
                            {
                                boCommit();
                            }              
                        }
                    }
                    //Não existe processo 
                    //Envio mensagem para o usuário informando que o processo não está cadastrado no SIGPA                
                    return objCliente;
                        
                }
                //Fim da sincronização
            }
            catch (Exception ex)
            {
                boRollBack();
                throw ex ;
            }
            
            
        }

        public List<INFOTipoDocumento> boObterListaTipoDocumento() {

            DAOTipoDocumento objDalTipoDocumento = null;
            try
            {
                objDalTipoDocumento = new DAOTipoDocumento();

                return objDalTipoDocumento.dbObterListaTipoDocumento();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<INFODocumento> boObterListaDocumento(double pIdentificador, string pCategoria)
        {

            DAODocumento objDocumento = null;
            try
            {
                objDocumento = new DAODocumento();

                return objDocumento.dbObterListaDocumento(pIdentificador, pCategoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void boMontarDiretorioDadosCadastrais(string pTipoDocumento,
                                                     string pDocumento,
                                                     INFOCliente pObjCliente,
                                                     out string pNameFile,
                                                     out string pNameDir)
        {
            DALParametros objDalParametros = null;
            INFOParametros objParametros = null;
            string NomeArquivo = string.Empty;
            string NomeDiretorio = string.Empty;
            StringBuilder SBDiretorio = null;

            try
            {
                objDalParametros = new DALParametros();
                objParametros = objDalParametros.dbObterParametros();

                if (objParametros == null) throw new Exception("Parâmetros devem ser cadastrados !");

                //Nome do arquivo deverá ser montado com a seguinte nomeclatura
                //nome do documento + contador
                NomeArquivo = pDocumento.ToUpper() + objParametros.NumeroContador.ToString() + ".pdf";

                //Nome do diretório será montado com a seguinte nomeclatura
                //Nome do Diretório cadasrado em parametros / Nome Cliente Mapa / TipoDocumento / Documento

                SBDiretorio = new StringBuilder();

                SBDiretorio.Append(objParametros.NomeDiretorioDocumentos + "\\");
                
                SBDiretorio.Append(pObjCliente.NomeClienteMapa.Replace(".", "").Replace("-", "").Replace(" ", "").Trim().ToUpper() + "\\");
                
                SBDiretorio.Append(pTipoDocumento.Trim().Replace("/", "").ToUpper() + "\\");
                SBDiretorio.Append(pDocumento.Trim().Replace("/", "").ToUpper() + "\\");

                NomeDiretorio = justLegalChars(SBDiretorio.ToString());

                // Se o diretório não existir então eu crio o diretório
                if (!System.IO.Directory.Exists(NomeDiretorio))
                {
                    System.IO.Directory.CreateDirectory(NomeDiretorio);
                }


               
                pNameFile = justLegalChars(NomeArquivo);
                pNameDir = NomeDiretorio;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally {
                SBDiretorio = null;
            }
            
        }


        public void boMontarNomeArquivoeDiretorio(string pNRef, 
                                                  string pTipoDocumento, 
                                                  string pDocumento, 
                                                  INFOCliente pObjCliente, 
                                                  out string pNameFile,
                                                  out string pNameDir) {
            DALParametros objDalParametros = null;
            INFOParametros objParametros = null;
            string NomeArquivo = string.Empty;
            string NomeDiretorio = string.Empty;
            StringBuilder SBDiretorio = null;
            try
            {
                objDalParametros = new DALParametros();
                objParametros = objDalParametros.dbObterParametros();

                if (objParametros == null) throw new Exception("Parâmetros devem ser cadastrados !");

                //Nome do arquivo deverá ser montado com a seguinte nomeclatura
                //Numero Referencia + contador
                NomeArquivo = pNRef.Replace("-", "").Replace("/", "").ToUpper() + objParametros.NumeroContador.ToString() + ".pdf";
                //Nome do diretório será montado com a seguinte nomeclatura
                //Nome do Diretório cadasrado em parametros / Nome Cliente Mapa / TipoDocumento / Numero Processo / Documento  

                SBDiretorio = new StringBuilder();

                SBDiretorio.Append(objParametros.NomeDiretorioDocumentos + "\\");
                SBDiretorio.Append(pObjCliente.NomeClienteMapa.Replace(".", "").Replace("-","").Replace(" ","").Trim().ToUpper() + "\\");
                SBDiretorio.Append(pNRef.Replace("-", "").Replace("/", "").ToUpper() + "\\");
                SBDiretorio.Append(pTipoDocumento.Trim().Replace("/","").ToUpper() + "\\");
               
                SBDiretorio.Append(pDocumento.Trim().Replace("/","").ToUpper() + "\\");

                NomeDiretorio = SBDiretorio.Replace(" ", "").Replace("(","").Replace(")","").Replace("Á", "A").Replace("Ç", "C").Replace("Ã", "A").Replace("Í","I").Replace("É", "E").ToString().Trim();

                // Se o diretório não existir então eu crio o diretório
                if (!System.IO.Directory.Exists(NomeDiretorio))
                {
                    System.IO.Directory.CreateDirectory(NomeDiretorio);
                }

                pNameFile = NomeArquivo;
                pNameDir = NomeDiretorio;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                SBDiretorio = null;
            }
        }

        private String justLegalChars(String s)
        {
            return s.Replace(" ", "").
                     Replace("(","").
                     Replace(")","").
                     Replace("Á", "A").
                     Replace("Ç", "C").
                     Replace("Ã", "A").
                     Replace("Í","I").
                     Replace("É", "E").
                     ToString().Trim();
        }


    }
   
}
