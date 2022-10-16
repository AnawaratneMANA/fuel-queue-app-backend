using MongoDBTestProject.Model;

namespace MongoDBTestProject.Service
{
    /* SERVICE CLASS - Fuel Stations */
    public interface IFuelStationService
    {
        // List of fuel stations for the queue users references.
        List<FuelStation> GetFuelStations();
        // Single fuel station details for the Station Owner.
        FuelStation GetFuelStation(String id);
        FuelStation CreateFuelStation(FuelStation station);
        // Update fuel station queue starting time and ending time.
        void UpdateFuelStation(String stationId, FuelStation station);
        void RemoveFuelStation(String id);
    }
}
