using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSOpusDigitalizacao.INFO
{
    public class wsINFONavios
    {
        private string navio_embarque;
        private string terminal_chegada;
        private DateTime data_previsao_chegada_navio;
        private DateTime data_chegada_navio;

        public string Navio_embarque
        {
            get { return navio_embarque; }
            set { navio_embarque = value; }
        }
      
        public string Terminal_chegada
        {
            get { return terminal_chegada; }
            set { terminal_chegada = value; }
        }
        
        public DateTime Data_previsao_chegada_navio
        {
            get { return data_previsao_chegada_navio; }
            set { data_previsao_chegada_navio = value; }
        }
       
        public DateTime Data_chegada_navio
        {
            get { return data_chegada_navio; }
            set { data_chegada_navio = value; }
        }


    }
}