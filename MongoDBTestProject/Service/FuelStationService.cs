using MongoDB.Driver;
using MongoDBTestProject.Model;
using static System.Collections.Specialized.BitVector32;

namespace MongoDBTestProject.Service
{
    public class FuelStationService : IFuelStationService

    {
        private readonly IMongoCollection<FuelStation> _fuelStation;
        private readonly IMongoCollection<FuelQueueRequest> _fuelRequest;
        private readonly IMongoCollection<FuelQueueHistory> _fuelHistory;
        private readonly IMongoCollection<FuelQueue> _fuelQueue;

        // Init DB Connections
        public FuelStationService(IStudentDatabaseSettings settings, IMongoClient mongoClient)
        {
            // TODO: Add FuelQueue and FuelQueueHistory collections

            /* Using a single service for all Queue, History, and Fuel Station related 
             Model classes */

            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _fuelStation = database.GetCollection<FuelStation>(settings.FuelStationCollectionName);
            _fuelRequest = database.GetCollection<FuelQueueRequest>(settings.FuelQueueRequestCollectionName);
            _fuelQueue = database.GetCollection<FuelQueue>(settings.FuelQueueCollectionName);
            _fuelHistory = database.GetCollection<FuelQueueHistory>(settings.FuelQueueHistoryCollectionName);

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
            /* Find the existing document, update only the Starting time and Ending time.*/
            FuelQueueRequest existingRequest = GetFuelReqeust(id);
            existingRequest.ApprovalStatus = approaval;
            _fuelRequest.ReplaceOne(request => request.Id == existingRequest.Id, existingRequest);
        }

        public List<FuelQueueRequest> GetFuelQueueRequests()
        {
            return _fuelRequest.Find(station => true).ToList();
        }

        // Get a List of Fuel Stations
        public FuelQueueRequest GetFuelReqeust(String id)
        {
            return _fuelRequest.Find(station => station.Id == id).FirstOrDefault();
        }

        public FuelQueueRequest CreateFuelRequest(FuelQueueRequest request)
        {
            _fuelRequest.InsertOne(request);
            return request;
        }

        public FuelQueue CreateQueue(FuelQueue queue)
        {
            _fuelQueue.InsertOne(queue);
            return queue;
        }

        public List<FuelQueue> GetAllQueue()
        {
            return _fuelQueue.Find(station => true).ToList();
        }

        public FuelQueue GetQueueone(string id)
        {
            return _fuelQueue.Find(station => station.Id == id).FirstOrDefault();
        }

        public void UpdateQueueStatus(string approaval, string id)
        {
            FuelQueue existingRequest = GetQueueone(id);
            existingRequest.Status = approaval;
            _fuelQueue.ReplaceOne(request => request.Id == existingRequest.Id, existingRequest);
        }
    }
}
