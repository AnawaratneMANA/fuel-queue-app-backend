using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDBTestProject.Model
{
    public class FuelQueueHistory
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; } = String.Empty;
        [BsonElement("stationId")]
        public String StationId { get; set; } = String.Empty;
        [BsonElement("noOfVehicle")]
        // This is the total number of vehicles in the Queue. (Do not get removed).
        public int NoOfVehicles { get; set; }
    }
}
