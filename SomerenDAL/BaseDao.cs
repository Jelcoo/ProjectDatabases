using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SomerenDAL
{
    public abstract class BaseDao
    {
        private SqlConnection conn;

        public BaseDao()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString);
        }

        protected SqlConnection OpenConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                //Print.ErrorLog(e);
                throw;
            }
            return conn;
        }

        protected void CloseConnection()
        {
            conn.Close();
        }
    }
}