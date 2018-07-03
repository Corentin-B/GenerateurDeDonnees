using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1.Model
{
    public class Connection
    {
        OracleConnection con { get; set; }
        bool connect = false; 
        public Connection()
        {
            try
            {
            con =  new OracleConnection("server:projet-data.c5iadtb7wbsy.eu-west-1.rds.amazonaws.com/orcl; User ID = corentin; Password = mypwd");
            con.Open();
            connect = true; 
            }
            catch(Exception e)
            {
                connect = false; 
            }
           



        }


        public OracleConnection getConnection{
            get{
                if (connect)
                {
                    return con;
                }
                else
                {
                    try
                    {
                        con = new OracleConnection("server:projet-data.c5iadtb7wbsy.eu-west-1.rds.amazonaws.com/orcl; User ID = corentin; Password = mypwd");
                        con.Open();
                        return con; 
                    }
                    catch (Exception e)
                    {
                        return null; 
                    }
                }
            }
            
    }
}


    }