using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTracker
{
    class Car
    {
        private static Car carObj = null;

        public static Car GetInstance()
        {
            if (carObj == null)
            {
                carObj = new Car();
            }
            return carObj;
        }

        private Dictionary<int, Car> carDictionary = new Dictionary<int, Car>();
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

        public void addCar(string carModel, string carManufacturer, int manufacturerYear, int vehicleNumber, double carPrice)
        {
            Car carObj = new Car();
            carObj.CarModel = carModel;
            carObj.CarManufacturer = carManufacturer;
            carObj.CarManufaturerDate = manufacturerYear;
            carObj.VehicleNumber = vehicleNumber;
            carObj.CarWorth = carPrice;
            carDictionary.Add(vehicleNumber, carObj);

        }

        public Car contains(int value)
        {
            if (carDictionary.ContainsKey(value))
            {
                return carDictionary[value];
            }
            else
            {
                return null;
            }
        }



    }
}
