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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string carModel;
                string carManufacturer;
                string manufacturerYear;
                int intConverter;
                int vehicleNumber;
                double doubleConverter;
                double carPrice;
                //check carModel value
                if (txtCarModel.Text == null)
                {
                    MessageBox.Show("Please enter the Car Model");
                    txtCarModel.Focus();
                }
                else
                {
                    carModel = txtCarModel.Text;
                }
                //check carManufacturer value
                if (txtCarManufacturer.Text == null)
                {
                    MessageBox.Show("Please enter the Car Manufacturer");
                    txtCarManufacturer.Focus();
                }
                else
                {
                    carManufacturer = txtCarManufacturer.Text;
                }
                //check manufacturerYear
                if (txtManufacturingYear == null)
                {
                    MessageBox.Show("Please enter the Manufacturing Date");
                    txtManufacturingYear.Focus();
                }
                else
                {
                    manufacturerYear = txtManufacturingYear;
                }
                //parse value for vehicle number
                if (int.TryParse(txtVehicleNumber.Text, out intConverter))
                {
                    vehicleNumber = intConverter;
                }
                else
                {
                    MessageBox.Show("Please enter a valid vehicle number");
                    txtVehicleNumber.Text = String.Empty;
                    txtVehicleNumber.Focus();
                    return;
                }

                //parse value for car price
                if (double.TryParse(txtCarPrice.Text, out doubleConverter))
                {
                    carPrice = doubleConverter;
                }
                else
                {
                    MessageBox.Show("Please enter a valid car price");
                    txtCarPrice.Text = String.Empty;
                    txtCarPrice.Focus();
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
