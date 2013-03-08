using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSOpusDigitalizacao.INFO
{
    public class wsINFOInformativos
    {
        private string categoriainformativo;
        private string datapublicacao;
        private string resenha;

        public string Resenha
        {
            get { return resenha; }
            set { resenha = value; }
        }

        public string Categoriainformativo
        {
            get { return categoriainformativo; }
            set { categoriainformativo = value; }
        }
       

        public string Datapublicacao
        {
            get { return datapublicacao; }
            set { datapublicacao = value; }
        }


    }
}