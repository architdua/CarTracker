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
    public partial class CarFinder : Form
    {
        public CarFinder()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int vehicleNumber;
                int intConverter;
                if (int.TryParse(txtRequestVehicleNumber.Text, out intConverter))
                {
                    vehicleNumber = intConverter;
                }
                else
                {
                    MessageBox.Show("Please enter an integer value for the Vehicle Number");
                    return;
                }
                Car carObj = Car.GetInstance().contains(vehicleNumber);

                if (carObj != null)
                {
                    txtDisplayCarModel.Text = carObj.CarModel;
                    txtDisplayCarManufacturer.Text = carObj.CarManufacturer;
                    txtDisplayManufacturingYear.Text = carObj.CarManufaturerDate.ToString();
                    txtDisplayCarPrice.Text = carObj.CarWorth.ToString();
                }
                else
                {
                    MessageBox.Show("There is no car in the system with that Vehicle Number");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
