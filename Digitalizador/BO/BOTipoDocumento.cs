using System;
using System.Collections.Generic;
using System.Text;
using SIGPA.Service;
using SIGPA.DAO;
using SIGPA.INFO;

namespace SIGPA.BO
{
    public class BOTipoDocumento
    {

        public List<INFOTipoDocumento> boObterTipoDocumento()
        {
            
            DAOTipoDocumento objDaoTipoDocumento = null;
            try
            {
                objDaoTipoDocumento = new DAOTipoDocumento();
                return objDaoTipoDocumento.dbObterListaTipoDocumento();

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public Boolean boInserirTipoDocumento(INFOTipoDocumento pObjTipoDocumento)
        {
            DAOTipoDocumento objDaoTipoDocumento = null;
            objDaoTipoDocumento = new DAOTipoDocumento();
            int i;
            try
            {
                List<INFOTipoDocumento> lstDaoObj = null;
                lstDaoObj = objDaoTipoDocumento.dbObterListaTipoDocumento();
               
                for (i = 0; i < lstDaoObj.Count; i++ ){
                   
                     string aux = lstDaoObj[i].NomeTipoDocumento.ToUpper();
                     if (aux == pObjTipoDocumento.NomeTipoDocumento.ToUpper())
                     {
                         return false;
                     }

               }

                return objDaoTipoDocumento.dbInserirTipoDocumento(pObjTipoDocumento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean boAtualizarTipoDocumento(INFOTipoDocumento pObjTipoDocumento)
        {
            DAOTipoDocumento objDaoTipoDocumento = null;
            objDaoTipoDocumento = new DAOTipoDocumento();
            int i;
            try
            {
                List<INFOTipoDocumento> lstDaoObj = null;
                lstDaoObj = objDaoTipoDocumento.dbObterListaTipoDocumento();

                for (i = 0; i < lstDaoObj.Count; i++)
                {

                    string aux = lstDaoObj[i].NomeTipoDocumento.ToUpper();
                    if (aux == pObjTipoDocumento.NomeTipoDocumento.ToUpper())
                    {
                        return false;
                    }

                }

                return objDaoTipoDocumento.dbAlterarTipoDocumento(pObjTipoDocumento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
      

    }
}
