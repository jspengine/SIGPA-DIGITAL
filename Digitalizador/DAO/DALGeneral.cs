using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SIGPA.DAO
{
    public class DALGeneral
    {
       protected string gConnectionString = string.Empty;

        public DALGeneral(){
            gConnectionString = ConfigurationManager.ConnectionStrings["SIGPA_DIGITAL"].ConnectionString ; 
        }

        protected MySqlDataReader dbObterRegistros (MySqlConnection pobjConn, string pstrSQL, MySqlTransaction pobjTrans ){
           MySqlCommand lobjCommand = null;

            try 
	        {
	            if (pobjTrans == null){
                    if ( pobjConn == null ){
                        pobjConn = new MySqlConnection(gConnectionString);
                    }

                    if (pobjConn.State != System.Data.ConnectionState.Open)
                    {
                        pobjConn.Open();
                    }
                }

                lobjCommand = new MySqlCommand();
                lobjCommand.CommandType = System.Data.CommandType.Text;

                if (pobjTrans == null)
                {
                    lobjCommand.Connection = pobjConn;
                }
                else{
                    lobjCommand.Transaction = pobjTrans;
                    lobjCommand.Connection = pobjTrans.Connection;
                }
                lobjCommand.CommandText = pstrSQL;
               
                return lobjCommand.ExecuteReader();
        		
	        }
	        catch (Exception ex)
	        {    		
		        throw ex;
	        }
            finally{
                if (lobjCommand != null){
                    lobjCommand.Dispose();
                    lobjCommand = null;
                }
            }

        }
         
        protected int dbExecutarQuery(string pstrSQL, MySqlTransaction pobjTrans ){
            MySqlConnection lobjConn = null;
            MySqlCommand lobjCommand = null;

            try 
	        {	
                if (pobjTrans == null)
                {
                    lobjConn = new MySqlConnection(gConnectionString);
                    lobjConn.Open();
                }
                  lobjCommand = new MySqlCommand();
                  lobjCommand.CommandType = System.Data.CommandType.Text;		
                
                if (pobjTrans == null)
                {
                    lobjCommand.Connection = lobjConn;
                }
                else{
                    lobjCommand.Transaction = pobjTrans;
                    lobjCommand.Connection = pobjTrans.Connection;
                }
                lobjCommand.CommandText = pstrSQL;

                return lobjCommand.ExecuteNonQuery();
	        }
	        catch (Exception ex)
            {
            		
		           throw ex;
	        }
            finally{
                if (lobjConn != null){
                    if (lobjConn.State == System.Data.ConnectionState.Open){
                        lobjConn.Close();
                    }
                    lobjConn.Dispose();
                    lobjConn = null;
                }
                
               
                
                if ( lobjCommand != null){
                        lobjCommand.Dispose();
                        lobjCommand = null;
                }
             }
                
         }



    }       
}
