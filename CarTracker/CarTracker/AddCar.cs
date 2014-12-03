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
        private Dictionary<int, Car> carDictionary = new Dictionary<int, Car>();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string carModel;
                string carManufacturer;
                int manufacturerYear;
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
              
                //check carManufacturer value
                if (txtCarManufacturer.Text == null)
                {
                    MessageBox.Show("Please enter the Car Manufacturer");
                    txtCarManufacturer.Focus();
                }
                
                //parse manufacturerYear
                if (int.TryParse(txtManufacturingYear.Text, out intConverter))
                {
                    manufacturerYear = intConverter;
                }
                else
                {
                    MessageBox.Show("Please enter the Manufacturing Date");
                    txtManufacturingYear.Text = String.Empty;
                    txtManufacturingYear.Focus();
                    return;
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

                Car.GetInstance().addCar(txtCarModel.Text, txtCarManufacturer.Text, manufacturerYear, vehicleNumber, carPrice);
                clear();
                MessageBox.Show("Car added to System with vehicle number: " + vehicleNumber);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void clear()
        {
            txtCarModel.Text = String.Empty;
            txtCarManufacturer.Text = String.Empty;
            txtCarPrice.Text = String.Empty;
            txtVehicleNumber.Text = String.Empty;
            txtManufacturingYear.Text = String.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
