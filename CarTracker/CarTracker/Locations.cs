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
            locationsDataTable.Columns.Add("# of Parking Spots", typeof(int));
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
                }
                DataRow newRow = locationsDataTable.NewRow();
                newRow["Location Name"] = txtLocationName.Text;
                newRow["# of Parking Spots"] = txtParkingSpots.Text;
                newRow["Location City"] = txtLocationCity.Text;

                locationsDataTable.Rows.Add(newRow);

                dataGridView1.DataSource = locationsDataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        

      
    }
}
