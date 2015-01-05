using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using CarTracker.Data;
namespace CarTracker.Domain
{
    public class ClsLocationDetails
    {
        CarTracker.Data.ClsDBOperations objDBOperations = new ClsDBOperations();
        public Dictionary<string, string> login(string username, string password)
        {
            string storedProcedure = "usp_login";
            Dictionary<string, string> inputParameters = new Dictionary<string, string>();
            inputParameters.Add("@loginName", username);
            inputParameters.Add("@password", password);
            Dictionary<string, string> outputParameters = new Dictionary<string, string>();
            outputParameters.Add("@result", "nvarchar");
            return objDBOperations.ExecuteStoredProcedure(storedProcedure, inputParameters, outputParameters);
        }
        public DataSet getDataFromDB()
        {
            string stringCmd = "SELECT * FROM LOCATIONS";
            return objDBOperations.executeQuery(stringCmd);
        }

        public Dictionary<string, string> addLocation(string locationName, int parkingSpots, string locationCity)
        {
            string storedProcedure = "usp_add_location";
            Dictionary<string, string> inputParameters = new Dictionary<string, string>();
            inputParameters.Add("@LocationName", locationName);
            inputParameters.Add("@ParkingSpots", parkingSpots.ToString());
            inputParameters.Add("@LocationCity", locationCity);
            Dictionary<string, string> outputParameters = new Dictionary<string, string>();
            outputParameters.Add("@Result", "nvarchar");
            return objDBOperations.ExecuteStoredProcedure(storedProcedure, inputParameters, outputParameters);
        }

        public void updateLocation(string locationName, int parkingSpots, string locationCity, int locationID)
        {
            string storedProcedure = "usp_update_location";
            Dictionary<string, string> inputParameters = new Dictionary<string, string>();
            inputParameters.Add("@LocationID", locationID.ToString());
            inputParameters.Add("@LocationName", locationName);
            inputParameters.Add("@ParkingSpots", parkingSpots.ToString());
            inputParameters.Add("@LocationCity", locationCity);
            Dictionary<string, string> outputParameters = new Dictionary<string, string>();
            objDBOperations.ExecuteStoredProcedure(storedProcedure, inputParameters, outputParameters);
        }

        public void deleteLocation(int locationID)
        {
            string storedProcedure = "usp_delete_location";
            Dictionary<string, string> inputParameters = new Dictionary<string, string>();
            inputParameters.Add("@LocationID", locationID.ToString());
            Dictionary<string, string> outputParameters = new Dictionary<string, string>();
            objDBOperations.ExecuteStoredProcedure(storedProcedure, inputParameters, outputParameters);
          
        }
        public Dictionary<string, string> getValues(string locationName)
        {
            string storedProcedure = "usp_get_location";
            Dictionary<string, string> inputParameters = new Dictionary<string, string>();
            inputParameters.Add("@LocationName", locationName);
            Dictionary<string, string> outputParameters = new Dictionary<string, string>();
            outputParameters.Add("@ReturnResult", "nvarchar");
            outputParameters.Add("@ReturnLocationCity", "nvarchar");
            outputParameters.Add("ReturnParkingSpots", "int");
            return objDBOperations.ExecuteStoredProcedure(storedProcedure, inputParameters, outputParameters);
        }
    }
}
