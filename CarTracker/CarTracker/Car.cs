using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTracker
{
    class Car
    {
        private string _carModel;

        public string CarModel
        {
            get { return _carModel; }
            set { _carModel = value; }
        }
        private string _carManufacturer;

        public string CarManufacturer
        {
            get { return _carManufacturer; }
            set { _carManufacturer = value; }
        }
        private int _carManufaturerDate;

        public int CarManufaturerDate
        {
            get { return _carManufaturerDate; }
            set { _carManufaturerDate = value; }
        }
        private int _vehicleNumber;

        public int VehicleNumber
        {
            get { return _vehicleNumber; }
            set { _vehicleNumber = value; }
        }
        private double _carWorth;

        public double CarWorth
        {
            get { return _carWorth; }
            set { _carWorth = value; }
        }


    }
}
