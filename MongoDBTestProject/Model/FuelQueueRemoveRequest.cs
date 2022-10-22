namespace MongoDBTestProject.Model
{
    public class FuelQueueRemoveRequest
    {
        public DateTime EndDateTime { get; set; }
        public String FuelAmount { get; set; } = String.Empty;
    }
}
