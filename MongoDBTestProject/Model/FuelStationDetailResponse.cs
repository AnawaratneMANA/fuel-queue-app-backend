namespace MongoDBTestProject.Model
{
    public class FuelStationDetailResponse
    {
        public string Id { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int NoOfPumps { get; set; }
        public string Availability { get; set; } = string.Empty;
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public string FuelType { get; set; } = string.Empty;
        public int vehicleCount { get; set; }
    }
}
