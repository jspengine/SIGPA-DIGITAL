using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace SIGPA.Service
{

    public enum FormatoArquivoLog
    {
        NOME = 1,
        NOME_DDMMAAAA = 2,
        NOME_DDMMAAAA_HHMMSS = 3,
        DDMMAAAA_NOME = 4,
        DDMMAAAA_HHMMSS_NOME = 5,
        AAAAMMDD_NOME = 6,
        AAAAMMDD_HHMMSS_NOME = 7
    }

    public enum FormatoDiretorioLog
    {
        SEM_DIRETORIO = 1,
        MES_ANO = 2,
        ANO_MES = 3,
        ANO_DIR_MES = 4
    }

    public enum TipoLog
    {
        AVISO = 1,
        ERRO = 2
    }

    public class Log
    {
        private string gStrNome;
        private string gStrCaminhoArquivoCompleto;
        private FormatoArquivoLog gEnumFormatoArquivo;
        private FormatoDiretorioLog gEnumFormatoDiretorio;
        private Exception gObjExcecao;

        public Log(string pStrNome)
        {
            gStrNome = pStrNome;

            //Padrao
            gEnumFormatoArquivo = FormatoArquivoLog.NOME_DDMMAAAA;
            gEnumFormatoDiretorio = FormatoDiretorioLog.MES_ANO;
        }

        ~Log()
        {

        }

        //Properties

        public string Nome
        {
            get { return gStrNome; }
        }

        public FormatoArquivoLog FormatoArquivo
        {
            get { return gEnumFormatoArquivo; }
            set { gEnumFormatoArquivo = value; }
        }

        public FormatoDiretorioLog FormatoDiretorio
        {
            get { return gEnumFormatoDiretorio; }
            set { gEnumFormatoDiretorio = value; }
        }

        public Exception Excecao
        {
            get { return gObjExcecao; }
        }

        public Boolean Inserir(string pStrMensagem, TipoLog pEnumTipo)
        {
            string mensagem = pStrMensagem;
            string linha = String.Empty;
            string caminhoArquivo = String.Empty;
            string nomeArquivo = String.Empty;
            StreamWriter sw = null;

            try
            {
                if (mensagem == null)
                {
                    mensagem = string.Empty;
                }
                //OBTÉM O CAMINHO DO ARQUIVO
                caminhoArquivo = ObterCaminhoDoArquivoDeLog();
                
                //TESTANDO PARA VER SE O DIRETÓRIO EXISTE
                if (! Directory.Exists(caminhoArquivo))
                {
                    Directory.CreateDirectory(caminhoArquivo);
                }

                //OBTÉM O NOME DO ARQUIVO
                nomeArquivo = ObterNomeDoArquivoDeLog();
                //Define o caminho completo do arquivo de log pela primeira vez
                if (String.IsNullOrEmpty(gStrCaminhoArquivoCompleto))
                {
                    gStrCaminhoArquivoCompleto = caminhoArquivo + "\\" + nomeArquivo;
                }

                switch (pEnumTipo)
                {
                    case TipoLog.AVISO:
                        linha = "[AVISO] [" + System.Environment.UserName + " - " + System.Environment.MachineName + "]";
                        break;
                    case TipoLog.ERRO:
                        linha = "[ERRO]  [" + System.Environment.UserName + " - " + System.Environment.MachineName + "]";
                        break;
                    default: break;
                }
                linha = linha + " " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                linha = linha + " --> " + mensagem;

                //ESCREVE O ARQUIVO
                sw = new StreamWriter(gStrCaminhoArquivoCompleto, true);
                sw.WriteLine(linha);
                sw.Close();

                return true;

            }
            catch (Exception ex)
            {
                gObjExcecao = ex;
                return false;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                    sw.Dispose();
                    sw = null;
                }
            }
        }

        public Boolean InserirQuebraDeLinha()
        {
            StreamWriter sw = null;
            string caminhoArquivo = string.Empty;
            string nomeArquivo = string.Empty;

            try
            {
                //OBTÉM O CAMINHO DO ARQUIVO
                caminhoArquivo = ObterCaminhoDoArquivoDeLog();

                //OBTÉM O NOME DO ARQUIVO
                nomeArquivo = ObterNomeDoArquivoDeLog();

                //Define o caminho completo do arquivo de log pela primeira vez
                if (String.IsNullOrEmpty(gStrCaminhoArquivoCompleto))
                {
                    gStrCaminhoArquivoCompleto = caminhoArquivo + "\\" + nomeArquivo;
                }

                //CRIA O DIRETÓRIO
                if (!Directory.Exists(caminhoArquivo))
                {
                    Directory.CreateDirectory(caminhoArquivo);
                }

                sw = new StreamWriter(gStrCaminhoArquivoCompleto, true);
                sw.Write(sw.NewLine);
                sw.Close();

                return true;

            }
            catch (Exception ex)
            {
                gObjExcecao = ex;

                return false;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                    sw.Dispose();
                    sw = null;
                }
            }
        }

        public void DeletarArquivoLog(){
           if (! string.IsNullOrEmpty(gStrCaminhoArquivoCompleto))
	        {
               if (File.Exists(gStrCaminhoArquivoCompleto))
	            {
		            File.Delete(gStrCaminhoArquivoCompleto );
	            }
	        }           
        }

        private string ObterCaminhoDoArquivoDeLog()
        {
            Assembly lObjAssembly = null;
            String[] caminhoAssembly;
            String caminhoArquivo = String.Empty;

            lObjAssembly = Assembly.GetEntryAssembly();

            if (lObjAssembly != null)
            {
                if (!string.IsNullOrEmpty(lObjAssembly.Location))
                {
                    caminhoAssembly = Assembly.GetEntryAssembly().Location.Split("\\".ToCharArray()); //.Split(new Char[1] { "\\" });
                    caminhoArquivo = Assembly.GetEntryAssembly().Location.Remove(Assembly.GetEntryAssembly().Location.Length - caminhoAssembly[caminhoAssembly.Length -1 ].Length -1 );
                }
            }

            switch (gEnumFormatoDiretorio)
            {
                case FormatoDiretorioLog.SEM_DIRETORIO:
                    caminhoArquivo = caminhoArquivo + "\\Log";
                    break;
                case FormatoDiretorioLog.MES_ANO:
                    caminhoArquivo = caminhoArquivo + "\\Log\\" + ObterNomeDoMes(DateTime.Now.Month) + "_" + DateTime.Now.Year.ToString();
                    break;
                case FormatoDiretorioLog.ANO_MES:
                    caminhoArquivo = caminhoArquivo + "\\Log\\" + DateTime.Now.Year.ToString() + "_" + ObterNomeDoMes(DateTime.Now.Month);
                    break;
                case FormatoDiretorioLog.ANO_DIR_MES:
                    caminhoArquivo = caminhoArquivo + "\\Log\\" + DateTime.Now.Year.ToString() + "\\" + ObterNomeDoMes(DateTime.Now.Month);
                    break;
                default:
                    break;
            }

            return caminhoArquivo;
        }

        private string ObterNomeDoArquivoDeLog(){
            string nomeArquivo = String.Empty;

               switch (gEnumFormatoArquivo)
	                {
		                case FormatoArquivoLog.NOME:
                            nomeArquivo = gStrNome + ".log";
                         break;
                        case FormatoArquivoLog.NOME_DDMMAAAA:
                            nomeArquivo = gStrNome + "_" + DateTime.Now.ToString("ddMMyyyy") + ".log";
                         break;
                        case FormatoArquivoLog.NOME_DDMMAAAA_HHMMSS:
                            nomeArquivo = gStrNome + "_" + DateTime.Now.ToString("ddMMyyyy") + "_" + DateTime.Now.ToString("HHmmss") + ".log";
                         break;
                        case FormatoArquivoLog.DDMMAAAA_NOME:
                            nomeArquivo = DateTime.Now.ToString("ddMMyyyy") + "_" + gStrNome + ".log";
                         break;
                        case FormatoArquivoLog.DDMMAAAA_HHMMSS_NOME:
                            nomeArquivo = DateTime.Now.ToString("ddMMyyyy") + "_" + DateTime.Now.ToString("HHmmss") + "_" + gStrNome + ".log";
                         break;
                        case FormatoArquivoLog.AAAAMMDD_NOME:
                            nomeArquivo = DateTime.Now.ToString("yyyyMMdd") + "_" + gStrNome + ".log";
                         break;
                        case FormatoArquivoLog.AAAAMMDD_HHMMSS_NOME:
                            nomeArquivo = DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + "_" + gStrNome + ".log";
                         break;
                        default:
                         break;
	                }
            return nomeArquivo;
        }

        private string ObterNomeDoMes(int pIntMes) {
            string[] lObjArrayMes = new string[12]{"Janeiro", 
                                                   "Fevereiro", 
                                                   "Marco", 
                                                   "Abril", 
                                                   "Maio", 
                                                   "Junho", 
                                                   "Julho", 
                                                   "Agosto", 
                                                   "Setembro", 
                                                   "Outubro", 
                                                   "Novembro", 
                                                   "Dezembro"};
            return lObjArrayMes[pIntMes];
        }

        public string LerConteudoArquivoLog(){
            String lStrConteudo = String.Empty;
            StreamReader lObjSR= null;

            try{
                if (File.Exists(gStrCaminhoArquivoCompleto))
                {
                    lObjSR = new StreamReader(gStrCaminhoArquivoCompleto);
                    lStrConteudo = lObjSR.ReadToEnd();
                    lObjSR.Close();
                }

                return lStrConteudo;
            
            }
            catch (Exception ex)
            {
                gObjExcecao = ex;

                return String.Empty;
            }
            finally{
                if (lObjSR != null)
                    {
                        lObjSR.Close();
                        lObjSR.Dispose();
                        lObjSR = null;
                    }
            }
        }

        public Boolean CopiarConteudoLog(Log pObjLog ) {
          string  lObjStrConteudo = string.Empty;
          StreamWriter lObjSW = null;

            try 
	        {	   
                lObjStrConteudo = pObjLog.LerConteudoArquivoLog();

                //Define o caminho completo do arquivo de log pela primeira vez
                if (String.IsNullOrEmpty(gStrCaminhoArquivoCompleto)){
                    gStrCaminhoArquivoCompleto = ObterCaminhoDoArquivoDeLog() + "\\" + ObterNomeDoArquivoDeLog();
                }

                lObjSW = new StreamWriter(gStrCaminhoArquivoCompleto, true);
                lObjSW.Write(lObjStrConteudo);
                lObjSW.Close();

                return true ;    
        		
	        }
	        catch (Exception ex)
	        {
        		gObjExcecao = ex;
                return false;
	        }
            finally{
                if (lObjSW != null)
                    {
                        lObjSW.Close();
                        lObjSW.Dispose();
                        lObjSW = null;
                    }
            }

        }
        ////////namespace e classe
    }
}
