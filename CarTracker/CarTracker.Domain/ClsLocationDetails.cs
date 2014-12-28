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
            return objDBOperations.ExecuteQuery(stringCmd);
        }
    }
}
