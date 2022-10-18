using MongoDBTestProject.Model;

namespace MongoDBTestProject.Service
{
    /* SERVICE CLASS - Fuel Stations */
    public interface IFuelStationService
    {
        /* Fuel Station Related Service methods */

        // List of fuel stations for the queue users references.
        List<FuelStation> GetFuelStations();
        // Single fuel station details for the Station Owner.
        FuelStation GetFuelStation(String id);
        FuelStation CreateFuelStation(FuelStation station);
        // Update fuel station queue starting time and ending time.
        void UpdateFuelStation(String stationId, FuelStation station);
        void RemoveFuelStation(String id);
        void UpdateStartTimeAndEndTime(String id, FuelStation station);



        /* Fuel Queue Request Related Service methods */
        void UpdateApprovalStatusFuelRequest(String approaval, String id);
        List<FuelQueueRequest> GetFuelQueueRequests();
        FuelQueueRequest CreateFuelRequest(FuelQueueRequest request);
        FuelQueue CreateQueue(FuelQueue queue);

        // Insert Queue

        // Get all Queue 

        // Remove from Queue

        // Specific get Queue

        // Queue History Add

        // Status 



    }
}
