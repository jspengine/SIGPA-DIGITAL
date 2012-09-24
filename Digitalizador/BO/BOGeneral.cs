using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SIGPA.BO
{
    public class BOGeneral
    {
        static MySqlConnection objConn;
        public static MySqlTransaction pTrans;
        private static string gConnectionString = string.Empty;

        public BOGeneral(){
            gConnectionString = ConfigurationManager.ConnectionStrings["SIGPA_DIGITAL"].ConnectionString ; 

            //if (objConn ==null){
            //    objConn = new MySqlConnection(gConnectionString);
            //    objConn = new MySqlConnection();
            //    objConn.Open();
            //}
        }

        public static void boAbrirTrasacao(){
            try 
	        {	        
        		if (pTrans == null){
                    objConn = new MySqlConnection(gConnectionString);
                    objConn.Open();
                    pTrans = objConn.BeginTransaction();
                }
	        }
	        catch (Exception ex)
	        {
		        throw ex;
	        }   
        }

        public static void boRollBack(){
            try 
	        {	        
        	    if (pTrans != null){
                    pTrans.Rollback();
                }	
	        }
	        catch (Exception ex)
	        {
		        throw ex;
	        }
            finally{
                if (objConn !=null){
                    if (objConn.State != System.Data.ConnectionState.Closed){
                        objConn.Close();
                    }
                    objConn.Dispose();
                }           
                objConn = null;

                if (pTrans != null){
                    pTrans.Dispose();
                }
                pTrans = null;

            }
        }

        public static void boCommit()
        {
            try
            {
                if (pTrans != null)
                {
                    pTrans.Commit();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (objConn != null)
                {
                    if (objConn.State != System.Data.ConnectionState.Closed)
                    {
                        objConn.Close();
                    }
                    objConn.Dispose();
                }
                objConn = null;

                if (pTrans != null)
                {
                    pTrans.Dispose();
                }
                pTrans = null;

            }
        }      

    }
}
