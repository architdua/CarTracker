using System;
using System.Collections;
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

        public int executeNonQuery (string pQueryStatement)
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
        public DataSet executeQuery(string pQueryStatement)
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

        public Dictionary<string, string> ExecuteStoredProcedure(string pStoredProcedure, Dictionary<string, string> pInputParameters, Dictionary<string, string> pOutputParameters)
        {
            try
            {
                createConnection();
                SqlCommand sqlCommand = sqlConn.CreateCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = pStoredProcedure;
                Dictionary<string, string> output = new Dictionary<string, string>();
              
                foreach(KeyValuePair<string, string> entry in pInputParameters)
                {
                    sqlCommand.Parameters.AddWithValue(entry.Key, entry.Value);
                }
          
                foreach (KeyValuePair<string, string> entry in pOutputParameters)
                {
                    if (entry.Value == "nvarchar")
                    {
                        sqlCommand.Parameters.Add(entry.Key, SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    }
                    if(entry.Value == "int")
                    {
                        sqlCommand.Parameters.Add(entry.Key, SqlDbType.Int).Direction = ParameterDirection.Output;
                    }
                }
                sqlCommand.ExecuteNonQuery();
                if (pOutputParameters.Count > 0)
                {
                    foreach (KeyValuePair<string, string> entry in pOutputParameters)
                    {
                        if (sqlCommand.Parameters[entry.Key].Value.ToString().Length > 0)
                        {
                            output.Add(entry.Key, sqlCommand.Parameters[entry.Key].Value.ToString());
                        }
                    }

                }

                return output; 
            }
            finally
            {
                closeConnection();
            }
        }
    }
}
