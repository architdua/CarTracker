﻿using System;
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

        public string ExecuteStoredProcedure(string pStoredProcedure, Dictionary<string, string> pInputParameters, Dictionary<string, int> pOutputParameters)
        {
            try
            {
                createConnection();
                SqlCommand sqlCommand = sqlConn.CreateCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = pStoredProcedure; 

                foreach(KeyValuePair<string, string> entry in pInputParameters)
                {
                    sqlCommand.Parameters.AddWithValue(entry.Key, entry.Value);
                }
                foreach (KeyValuePair<string, int> entry in pOutputParameters)
                {
                    sqlCommand.Parameters.Add(entry.Key, SqlDbType.NVarChar, entry.Value).Direction = ParameterDirection.Output;
                }
                sqlCommand.ExecuteNonQuery();
                if (pOutputParameters.Count > 0)
                {
                    if (sqlCommand.Parameters["@Result"].Value.ToString().Length > 0)
                    {
                       return sqlCommand.Parameters["@Result"].Value.ToString();
                    }
                }
                
                return null; 
            }
            finally
            {
                closeConnection();
            }
        }
    }
}
