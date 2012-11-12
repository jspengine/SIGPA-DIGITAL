using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIGPA.INFO
{
    public class INFOCategoriaProcesso
    {
        private int id_categoria;
        private String nm_categoria;
        private String ds_sigla;

        public int Id_categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }
        

        public String Nm_categoria
        {
            get { return nm_categoria; }
            set { nm_categoria = value; }
        }
        

        public String Ds_sigla
        {
            get { return ds_sigla; }
            set { ds_sigla = value; }
        }


    }
}
