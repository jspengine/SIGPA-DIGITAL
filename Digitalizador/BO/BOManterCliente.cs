using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIGPA.DAO;
using SIGPA.INFO;

namespace SIGPA.BO
{
    public class BOManterCliente
    {
        public List<INFO.INFOCliente> obterClientes() {
            DAOCliente dao = null;
            try
            {
                dao = new DAOCliente();


                return dao.dbObterCliente();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
