using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTracker.Data
{
    public class ClsDBOperations
    {
        string connectionString = "Server=ARCHIT;Database=Sample;Trusted_Connection=True";
        SqlConnection sqlConn = null;

        public bool createConnection()
        {
            if (sqlConn == null)
            {
                sqlConn = new SqlConnection();
                sqlConn.ConnectionString = connectionString;
            }

            sqlConn.Open();
            return true;
        }

        public bool closeConnection()
        {
            if (sqlConn != null)
            {
                sqlConn.Close();
            }
            return true;
        }

        public int ExecuteNonQuery (string pQueryStatement)
        {
            try 
            {
                createConnection();
                SqlCommand sqlCommand = new SqlCommand ();
                sqlCommand.CommandText = pQueryStatement;
                return sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                closeConnection();
            }
        }
        public DataSet ExecuteQuery(string pQueryStatement)
        {
            try
            {
                createConnection();
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(pQueryStatement, sqlConn);
                adp.Fill(ds);
                return ds;
            }
            finally
            {
                closeConnection();
            }

        }
    }
}
