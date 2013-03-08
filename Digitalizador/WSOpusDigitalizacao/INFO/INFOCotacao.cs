using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSOpusDigitalizacao.INFO
{
    public class INFOCotacao
    {
        private string data;

        public string  Data
        {
            get { return data; }
            set { data = value; }
        }
        private string valor_euz;

        public string Valor_euz
        {
            get { return valor_euz; }
            set { valor_euz = value; }
        }
        private string valor_cnm;

        public string Valor_cnm
        {
            get { return valor_cnm; }
            set { valor_cnm = value; }
        }
        private string valor_usd;

        public string Valor_usd
        {
            get { return valor_usd; }
            set { valor_usd = value; }
        }


        
    }
}