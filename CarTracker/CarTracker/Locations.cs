using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTracker
{
    public partial class Locations : Form
    {
        DataTable locationsDataTable = new DataTable();
        public Locations()
        {
            InitializeComponent();
        }

        private void Locations_Load(object sender, EventArgs e)
        {
            createTable();
        }

        private void createTable()
        {
            //set up first column, set field that user can not change
            DataColumn locationID = new DataColumn();
            locationID.ColumnName = "Location ID";
            locationID.DataType = typeof(int);
            locationID.AutoIncrement = true;
            locationsDataTable.Columns.Add(locationID);

            locationsDataTable.Columns.Add("Location Name", typeof(string));
            locationsDataTable.Columns.Add("Number of Parking Spots", typeof(int));
            locationsDataTable.Columns.Add("Location City", typeof(string));
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int intConverter; 
                int parkingSpots;
                if (int.TryParse(txtParkingSpots.Text, out intConverter))
                {
                    parkingSpots = intConverter;
                }
                else
                {
                    MessageBox.Show(txtParkingSpots.Text + " is not a valid input. Please enter an integer value");
                    txtParkingSpots.Focus();
                    return;
                }
                DataRow newRow = locationsDataTable.NewRow();
                newRow["Location Name"] = txtLocationName.Text;
                newRow["Number of Parking Spots"] = txtParkingSpots.Text;
                newRow["Location City"] = txtLocationCity.Text;

                locationsDataTable.Rows.Add(newRow);
                clear();
                dataGridView1.DataSource = locationsDataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetValues_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow [] selectedRows = locationsDataTable.Select("[Location Name] = '" + txtLocationName.Text + "'");
                if (selectedRows.Length == 0)
                {
                    MessageBox.Show("No record found");
                }
                else
                {
                    foreach (DataRow selectedRow in selectedRows)
                    {
                        txtParkingSpots.Text = selectedRow["Number of Parking Spots"].ToString();
                        txtParkingSpots.Refresh();
                        txtLocationCity.Text = selectedRow["Location City"].ToString();
                        txtLocationCity.Refresh();
                        System.Threading.Thread.Sleep(3000);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] selectedRows = locationsDataTable.Select("[Location ID] = '" + "'");

                if (selectedRows.Length == 0)
                {
                    MessageBox.Show("Record not found");
                }
                else
                {
                    selectedRows[0].Delete();
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] selectDataRows = locationsDataTable.Select("[Location ID] = '" + txtLocationName.Text + "'");
                if (selectDataRows.Length == 0)
                {
                    MessageBox.Show("Record not found");
                }
                else
                {
                    selectDataRows[0]["Number of Parking Spots"] = txtParkingSpots.Text;
                    selectDataRows[0]["LastName"] = txtLocationCity.Text;

                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int locationID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["clmLocationID"].Value);

            DataRow[] selectedRows = locationsDataTable.Select("[Location ID] = '" + locationID + "'");

            if (selectedRows.Length == 0)
            {
                MessageBox.Show("Record selected not found");
            }
            else
            {
                txtLocationCity.Text = selectedRows[0]["Location Name"].ToString();
                txtParkingSpots.Text = selectedRows[0]["Number of Parking Spots"].ToString();
                txtLocationName.Text = selectedRows[0]["Location City"].ToString();
            }
        }

        private void clear()
        {
            txtLocationCity.Text = String.Empty;
            txtLocationName.Text = String.Empty;
            txtLocationName.Text = String.Empty;
        }

        

      
    }
}
