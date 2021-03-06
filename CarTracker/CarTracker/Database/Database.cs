﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarTracker.Domain;
using System.Collections;

namespace CarTracker.Database
{
    public partial class frmDatabase : Form
    {
        public frmDatabase()
        {
            InitializeComponent();
        }
        string connectionString = "Server=ARCHIT;Database=Sample;Trusted_Connection=True";
        private CarTracker.Domain.ClsLocationDetails objDBStudentDetails = new ClsLocationDetails();
        int locationID = -1;

        
        private void getDataFromDB()
        {
            try
            {
                dataGridView1.DataSource = objDBStudentDetails.getDataFromDB().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            // refresh Data from DB
            getDataFromDB();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int intConverter; 
            int parkingSpots;
            
            if (txtLocationName.Text == String.Empty)
            {
                MessageBox.Show("Please enter a value for the Location Name");
                txtLocationName.Focus();
                return;
            }
            if (txtLocationCity.Text == String.Empty)
            {
                MessageBox.Show("Please enter a value for the Location City");
                txtLocationCity.Focus();
                return;
            }
            if (int.TryParse(txtParkingSpots.Text, out intConverter))
            {
                parkingSpots = intConverter;
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the number of parking spots for the location");
                txtParkingSpots.Text = String.Empty;
                txtParkingSpots.Focus();
                return;
            }

            addLocation(txtLocationName.Text, parkingSpots, txtLocationCity.Text);

            // refresh Data from DB
            getDataFromDB();
        }
        private void addLocation(string locationName, int parkingSpots, string locationCity)
        {
            try
            {
                Dictionary<string, string> output = objDBStudentDetails.addLocation(locationName, parkingSpots, locationCity);
                if (output.Count > 0)
                {
                    foreach (KeyValuePair<string, string> entry in output)
                    {
                        if (entry.Key == "@Result")
                        {
                            MessageBox.Show(entry.Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                clearTextFields();
            }
        }
       
        private void clearTextFields()
        {
            txtLocationName.Text = String.Empty;
            txtParkingSpots.Text = String.Empty;
            txtLocationCity.Text = String.Empty;
            locationID = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtLocationName.Text = row.Cells["clmLocationName"].Value.ToString();
            txtParkingSpots.Text = row.Cells["clmParkingSpots"].Value.ToString();
            txtLocationCity.Text = row.Cells["clmLocationCity"].Value.ToString();
            locationID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["clmLocationID"].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int intConverter;
            int parkingSpots;

            if (txtLocationName.Text == String.Empty)
            {
                MessageBox.Show("Please enter a value for the Location Name");
                txtLocationName.Focus();
                return;
            }
            if (txtLocationCity.Text == String.Empty)
            {
                MessageBox.Show("Please enter a value for the Location City");
                txtLocationCity.Focus();
                return;
            }
            if (int.TryParse(txtParkingSpots.Text, out intConverter))
            {
                parkingSpots = intConverter;
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the number of parking spots for the location");
                txtParkingSpots.Text = String.Empty;
                txtParkingSpots.Focus();
                return;
            }
            updateLocation(txtLocationName.Text, parkingSpots, txtLocationCity.Text);
            // refresh Data from DB
            getDataFromDB();

        }
        private void updateLocation(string locationName, int parkingSpots, string locationCity)
        {
            try
            {
                if (locationID > 0)
                {
                    objDBStudentDetails.updateLocation(locationName, parkingSpots, locationCity, locationID);
                }
                else
                {
                    MessageBox.Show("Please select a location");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                clearTextFields();
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteLocation();
            // refresh Data from DB
            getDataFromDB();
        }

        private void deleteLocation()
        {
            try
            {
                objDBStudentDetails.deleteLocation(locationID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                clearTextFields();
            }
        }
        
        private void btnGetValues_Click(object sender, EventArgs e)
        {
            if (txtLocationName.Text == String.Empty)
            {
                MessageBox.Show("Please enter a value for the Location Name");
                txtLocationName.Focus();
                return;
            }
            getValues(txtLocationName.Text);
        }
        private void getValues(string locationName)
        {
            try
            {
                Dictionary<string, string> output = objDBStudentDetails.getValues(locationName);
                foreach (KeyValuePair<string, string> entry in output)
                {
                    if (entry.Key == "@ReturnResult")
                    {
                        MessageBox.Show(entry.Value);
                        clearTextFields();
                    }
                    if (entry.Key == "@ReturnLocationCity")
                    {
                        txtLocationCity.Text = entry.Value;
                    }
                    if (entry.Key == "@ReturnParkingSpots")
                    {
                        txtParkingSpots.Text = entry.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //private void getValues(string locationName)
        //{
        //    SqlConnection sqlConn = null;
        //    try
        //    {
        //        sqlConn = new SqlConnection();
        //        sqlConn.ConnectionString = connectionString;
        //        //Open SQL Connection
        //        sqlConn.Open();
                
        //        SqlCommand sqlCommand = sqlConn.CreateCommand();
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.CommandText = "usp_get_location";

        //        //Add Parameters for stored procedure
        //        sqlCommand.Parameters.AddWithValue(@"LocationName", locationName);
        //        sqlCommand.Parameters.Add("@ReturnResult", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
        //        sqlCommand.Parameters.Add("@ReturnLocationCity", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
        //        sqlCommand.Parameters.Add("@ReturnParkingSpots", SqlDbType.Int).Direction = ParameterDirection.Output;

        //        sqlCommand.ExecuteNonQuery();

        //        if (sqlCommand.Parameters["@ReturnResult"].Value.ToString().Length > 0)
        //        {
        //           MessageBox.Show(sqlCommand.Parameters["@ReturnResult"].Value.ToString());
        //           return;
        //        }
        //       // MessageBox.Show(sqlCommand.Parameters["@ReturnParkingSpots"].Value.ToString());
        //        //MessageBox.Show(sqlCommand.Parameters["@ReturnLocationCity"].Value.ToString());
        //        txtParkingSpots.Text = sqlCommand.Parameters["@ReturnParkingSpots"].Value.ToString();
        //        txtLocationCity.Text = sqlCommand.Parameters["@ReturnLocationCity"].Value.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        // Close SQL Connection
        //        sqlConn.Close();
        //    }
        //}
        //private void getDataFromDB()
        //{
        //    SqlConnection sqlConn = null;
        //    try
        //    {
        //        sqlConn = new SqlConnection();
        //        sqlConn.ConnectionString = connectionString;

        //        //Open SQL Connection
        //        sqlConn.Open();

        //        string stringCommand = "SELECT * FROM LOCATIONS";

        //        //Insert Values into Dataset (a stack of tables)

        //        DataSet locationsDS = new DataSet();
        //        SqlDataAdapter sqlDA = new SqlDataAdapter(stringCommand, sqlConn);
        //        sqlDA.Fill(locationsDS);

        //        //Assign datasource to data grid view
        //        dataGridView1.DataSource = locationsDS.Tables[0];
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        if (sqlConn != null)
        //        {
        //            // Close SQL Connection
        //            sqlConn.Close();
        //        }
        //    }

        //}
        //private void addLocation(string locationName, int parkingSpots, string locationCity)
        //{
        //    SqlConnection sqlConn = null;
        //    try
        //    {
        //        sqlConn = new SqlConnection();
        //        sqlConn.ConnectionString = connectionString;

        //        //Open SQL Connection
        //        sqlConn.Open();

        //        //Commented to implement stored procedure
        //        //string stringCommand = "INSERT INTO LOCATIONS([Location Name],[Parking Spots],[Location City])" +
        //           // "Values('" + locationName + "' ,'" + parkingSpots + "' ,'" + locationCity + "')";

        //       // SqlCommand sqlCommand = sqlConn.CreateCommand();
        //       // sqlCommand.CommandText = stringCommand;

        //        // implement stored procedure
        //        SqlCommand sqlCommand = sqlConn.CreateCommand();
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.CommandText = "usp_add_location";

        //        //add parameters with values
        //        sqlCommand.Parameters.AddWithValue("@LocationName", txtLocationName.Text);
        //        sqlCommand.Parameters.AddWithValue("@ParkingSpots", txtParkingSpots.Text);
        //        sqlCommand.Parameters.AddWithValue("@LocationCity", txtLocationCity.Text);

        //        //add output parameters
        //        sqlCommand.Parameters.Add("@Result", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;

        //        sqlCommand.ExecuteNonQuery();
        //        //get result from stored procedure
        //        if (sqlCommand.Parameters["@Result"].Value.ToString().Length > 0)
        //        {
        //            MessageBox.Show(sqlCommand.Parameters["@Result"].Value.ToString());
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        // Close SQL Connection
        //        sqlConn.Close();
        //        clearTextFields();
        //    }

        //}
        //private void updateLocation(string locationName, int parkingSpots, string locationCity)
        //{
        //    SqlConnection sqlConn = null;
        //    try
        //    {
        //        sqlConn = new SqlConnection();
        //        sqlConn.ConnectionString = connectionString;
        //        //Open SQL Connection
        //        sqlConn.Open();
        //        if (locationID > 0)
        //        {
        //            //Update to include stored procedure
        //            //string stringCommand = "UPDATE LOCATIONS"  +
        //               // " SET [Location Name] = '" + locationName + "'" + "," + "[Parking Spots] = '" + parkingSpots + "'" + "," +
        //               //     "[Location City] = '" + locationCity + "'" +
        //             //   " WHERE [location ID] = " + locationID;
        //           // SqlCommand sqlCommand = sqlConn.CreateCommand();
        //          //  sqlCommand.CommandText = stringCommand;
        //            SqlCommand sqlCommand = sqlConn.CreateCommand();
        //            sqlCommand.CommandType = CommandType.StoredProcedure;
        //            sqlCommand.CommandText = "usp_update_location";

        //            //add parameters with values
        //            sqlCommand.Parameters.AddWithValue("LocationID", locationID);
        //            sqlCommand.Parameters.AddWithValue("LocationName", txtLocationName.Text);
        //            sqlCommand.Parameters.AddWithValue("ParkingSpots", txtParkingSpots.Text);
        //            sqlCommand.Parameters.AddWithValue("LocationCity", txtLocationCity.Text);


        //            sqlCommand.ExecuteNonQuery();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please select a query");
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        // Close SQL Connection
        //        sqlConn.Close();
        //        clearTextFields();
        //    }
        //}
        //private void deleteLocation()
        //{
        //    SqlConnection sqlConn = null;
        //    try
        //    {
        //        sqlConn = new SqlConnection();
        //        sqlConn.ConnectionString = connectionString;
        //        //Open SQL Connection
        //        sqlConn.Open();
        //        if (locationID > 0)
        //        {
        //            //Update for stored procedure
        //            //string stringCommand = "DELETE FROM LOCATIONS" +
        //            //    " WHERE [Location ID] = " + locationID;
        //            //SqlCommand sqlCommand = sqlConn.CreateCommand();
        //            //sqlCommand.CommandText = stringCommand;

        //            SqlCommand sqlCommand = sqlConn.CreateCommand();
        //            sqlCommand.CommandType = CommandType.StoredProcedure;
        //            sqlCommand.CommandText = "usp_delete_location";

        //            //Add Parameters for stored procedure
        //            sqlCommand.Parameters.AddWithValue(@"LocationID", locationID);

        //            sqlCommand.ExecuteNonQuery();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please select a query");
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        // Close SQL Connection
        //        sqlConn.Close();
        //        clearTextFields();
        //    }
        //}
    }
}
