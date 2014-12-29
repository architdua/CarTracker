using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTracker.Data;
using System.Data;

namespace CarTracker.Domain
{
    public class ClsLocationDetails
    {
        CarTracker.Data.ClsDBOperations objDBOperations = new ClsDBOperations();

        public DataSet getDataFromDB()
        {
            string stringCmd = "SELECT * FROM LOCATIONS";
            return objDBOperations.executeQuery(stringCmd);
        }
        public string addLocation(string locationName, int parkingSpots, string locationCity)
        {
            string storedProcedure = "usp_add_location";
            Dictionary<string, string> inputParameters = new Dictionary<string, string>();
            inputParameters.Add("@LocationName", locationName);
            inputParameters.Add("@ParkingSpots", parkingSpots.ToString());
            inputParameters.Add("@LocationCity", locationCity);
            Dictionary<string, int> outputParameters = new Dictionary<string, int>();
            outputParameters.Add("@Result", 100);
            return objDBOperations.ExecuteStoredProcedure(storedProcedure, inputParameters, outputParameters);
        }
    }
}
