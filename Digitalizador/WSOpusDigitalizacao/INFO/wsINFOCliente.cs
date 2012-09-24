using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace WSOpusDigitalizacao.INFO
{
    public class wsINFOCliente
    {
        private int idCliente;  
        private string nomeCliente;
        private string numeroCPF;
        private string numeroCNPJ;
        private string nomeMapa;
        private int idProcessoSigpa;

        public int IdProcessoSigpa
        {
            get { return idProcessoSigpa; }
            set { idProcessoSigpa = value; }
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string NomeMapa
        {
            get { return nomeMapa; }
            set { nomeMapa = value; }
        }

        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }  

        public string NumeroCPF
        {
            get { return numeroCPF; }
            set { numeroCPF = value; }
        }

        public string NumeroCNPJ
        {
            get { return numeroCNPJ; }
            set { numeroCNPJ = value; }
        }


    }
}
