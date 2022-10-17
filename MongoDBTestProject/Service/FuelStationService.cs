using MongoDB.Driver;
using MongoDBTestProject.Model;

namespace MongoDBTestProject.Service
{
    public class FuelStationService : IFuelStationService

    {
        private readonly IMongoCollection<FuelStation> _fuelStation;

        // Init DB Connections
        public FuelStationService(IStudentDatabaseSettings settings, IMongoClient mongoClient)
        {
            // TODO: Add FuelQueue and FuelQueueHistory collections

            /* Using a single service for all Queue, History, and Fuel Station related 
             Model classes */

            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _fuelStation = database.GetCollection<FuelStation>(settings.FuelStationCollectionName);
        }

        /*
          Fuel Station - Service Methods 
         */


        // Create a new FuelStation
        public FuelStation CreateFuelStation(FuelStation station)
        {
            _fuelStation.InsertOne(station);
            return station;
        }
        // Get a single Fuel Station
        public FuelStation GetFuelStation(string id)
        {
            return _fuelStation.Find(station => station.Id == id).FirstOrDefault();
        }
        // Get a List of Fuel Stations
        public List<FuelStation> GetFuelStations()
        {
            return _fuelStation.Find(station => true).ToList();
        }
        // Remove a fuel station (APP-ADMIN)
        public void RemoveFuelStation(string id)
        {
            _fuelStation.DeleteOne(station => station.Id == id);
        }

        // Update a existing Fuel Station
        public void UpdateFuelStation(string stationId, FuelStation station)
        {
            _fuelStation.ReplaceOne(station => station.Id == stationId, station);
        }

        // Specific update endpoint for update service starting time and end time.
        public void UpdateStartTimeAndEndTime(string stationId, FuelStation station)
        {
            /* Find the existing document, update only the Starting time and Ending time.*/
            FuelStation existingStation =  GetFuelStation(stationId);
            existingStation.StartingTime = station.StartingTime;
            existingStation.EndingTime = station.EndingTime;
            _fuelStation.ReplaceOne(station => station.Id == existingStation.Id, existingStation);
        }



        /*
        FuelQueue, FuelQueueHistory - Service Methods 
       */

        public void UpdateApprovalStatusFuelRequest(string approaval, string id)
        {
            throw new NotImplementedException();
        }



    }
}
