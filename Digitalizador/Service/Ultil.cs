using System;
using System.Collections.Generic;
//using System.Text;
using System.ComponentModel;
using System.Reflection;
using System.Net;

namespace SIGPA.Service
{
    public class Ultil
    {
         /// <summary>
        /// Obtém a descrição de um determinado Enumerador.
        /// </summary>
        /// <param name="valor">Enumerador que terá a descrição obtida.</param>
        /// <returns>String com a descrição do Enumerador.</returns>
        public static string ObterDescricao(Enum valor)
        {
            FieldInfo fieldInfo = valor.GetType().GetField(valor.ToString());
            DescriptionAttribute[] atributos = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return atributos.Length > 0 ? atributos[0].Description ?? "Nulo" : valor.ToString();
        }

        /// <summary>
        /// Retorna uma lista com os valores de um determinado enumerador.
        /// </summary>
        /// <param name="tipo">Enumerador que terá os valores listados.</param>
        /// <returns>Lista com os valores do Enumerador.</returns>
        public static System.Collections.IList Listar(Type tipo)
        {
            System.Collections.ArrayList lista = new System.Collections.ArrayList();
            int ValorDoEnumerador = 0;
            Enum DescricaoEnumerador = null;

            if (tipo != null)
            {
                Array enumValores = Enum.GetValues(tipo);

                for (int i = 0; i < enumValores.Length; i++)
                {
                    ValorDoEnumerador = (int)enumValores.GetValue(i);
                    DescricaoEnumerador = (Enum)enumValores.GetValue(i);

                    lista.Add(new KeyValuePair<int, string>(ValorDoEnumerador, ObterDescricao(DescricaoEnumerador)));
                }
            }

            return lista;
        }
    ///<sumamary>
    ///verify if the webservice is available 
    ///</summary>
    
        public static bool verifyWebService() {
            bool value = false;
            HttpWebRequest objRequest = null;

            try
            {
                objRequest = (HttpWebRequest)WebRequest.Create(System.Configuration.ConfigurationManager.AppSettings["URLWSSIGPA"].ToString());
                objRequest.AllowAutoRedirect = false;
                objRequest.Timeout = 10000;
                objRequest.GetResponse();
                value = objRequest.HaveResponse;
            }
            catch 
            {
                value = false;
            }
            finally {
                if (objRequest != null) objRequest.Abort(); objRequest = null; 
            }
            return value;
        }
    }


}
