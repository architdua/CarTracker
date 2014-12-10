using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTracker.Database
{
    public partial class frmDatabase : Form
    {
        public frmDatabase()
        {
            InitializeComponent();
        }
        string connectionString = "Server=ARCHIT;Database=Sample;Trusted_Connection=True";
        int locationID = -1;
        private void getDataFromDB()
        {
            SqlConnection sqlConn = null;
            try
            {
                sqlConn = new SqlConnection();
                sqlConn.ConnectionString = connectionString;

                //Open SQL Connection
                sqlConn.Open();

                string stringCommand = "SELECT * FROM LOCATIONS";

                //Insert Values into Dataset (a stack of tables)

                DataSet locationsDS = new DataSet();
                SqlDataAdapter sqlDA = new SqlDataAdapter(stringCommand, sqlConn);
                sqlDA.Fill(locationsDS);

                //Assign datasource to data grid view
                dataGridView1.DataSource = locationsDS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConn != null)
                {
                    // Close SQL Connection
                    sqlConn.Close();
                }
            }

        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            // refresh Data from DB
            getDataFromDB();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            addLocation(txtLocationName.Text, txtParkingSpots.Text, txtLocationCity.Text);

            // refresh Data from DB
            getDataFromDB();
        }
        private void addLocation(string locationName, string parkingSpots, string locationCity)
        {
            SqlConnection sqlConn = null;
            try
            {
                sqlConn = new SqlConnection();
                sqlConn.ConnectionString = connectionString;
                
                //Open SQL Connection
                sqlConn.Open();
                string stringCommand = "INSERT INTO LOCATIONS([Location Name],[Parking Spots],[Location City])" +
                    "Values('" + locationName + "' ,'" + parkingSpots + "' ,'" + locationCity + "')";

                SqlCommand sqlCommand = sqlConn.CreateCommand();
                sqlCommand.CommandText = stringCommand;

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close SQL Connection
                sqlConn.Close();
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
            updateLocation(txtLocationName.Text, txtParkingSpots.Text, txtLocationCity.Text);
            // refresh Data from DB
            getDataFromDB();

        }
        private void updateLocation(string locationName, string parkingSpots, string locationCity)
        {
            SqlConnection sqlConn = null;
            try
            {
                sqlConn = new SqlConnection();
                sqlConn.ConnectionString = connectionString;
                //Open SQL Connection
                sqlConn.Open();
                if (locationID > 0)
                {
                    string stringCommand = "UPDATE LOCATIONS"  +
                        " SET [Location Name] = '" + locationName + "'" + "," + "[Parking Spots] = '" + parkingSpots + "'" + "," +
                            "[Location City] = '" + locationCity + "'" +
                        " WHERE [location ID] = " + locationID;
                    SqlCommand sqlCommand = sqlConn.CreateCommand();
                    sqlCommand.CommandText = stringCommand;

                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Please select a query");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close SQL Connection
                sqlConn.Close();
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
            SqlConnection sqlConn = null;
            try
            {
                sqlConn = new SqlConnection();
                sqlConn.ConnectionString = connectionString;
                //Open SQL Connection
                sqlConn.Open();
                if (locationID > 0)
                {
                    string stringCommand = "DELETE FROM LOCATIONS" +
                        " WHERE [Location ID] = " + locationID;
                    SqlCommand sqlCommand = sqlConn.CreateCommand();
                    sqlCommand.CommandText = stringCommand;

                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Please select a query");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close SQL Connection
                sqlConn.Close();
                clearTextFields();
            }
        }
    }
}
