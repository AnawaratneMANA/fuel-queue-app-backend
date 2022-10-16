using MongoDBTestProject.Model;

namespace MongoDBTestProject.Service
{
    /* SERVICE CLASS - Fuel Stations */
    public interface IFuelStationService
    {
        List<Student> GetFuelStations();
        FuelStation GetFuelStation(String id);
        FuelStation CreateFuelStation(FuelStation station);
        void UpdateFuelStation(String stationId, FuelStation station);
        void RemoveFuelStation(String id);
    }
}
