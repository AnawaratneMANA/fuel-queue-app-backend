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
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _fuelStation = database.GetCollection<FuelStation>(settings.FuelStationCollectionName);
        }
        // Create a new FuelStation
        public FuelStation CreateFuelStation(FuelStation station)
        {
            _fuelStation.InsertOne(station);
            return station;
        }
        // Get a single Fuel Station
        public FuelStation GetFuelStation(string id)
        {
            // TESTING 
            FuelStation fuel = new FuelStation();
            return fuel;
        }
        // Get a List of Fuel Stations
        public List<FuelStation> GetFuelStations()
        {
            throw new NotImplementedException();
        }
        // Remove a fuel station (APP-ADMIN)
        public void RemoveFuelStation(string id)
        {
            throw new NotImplementedException();
        }
        // Update a existing Fuel Station
        public void UpdateFuelStation(string stationId, FuelStation station)
        {
            throw new NotImplementedException();
        }
    }
}
