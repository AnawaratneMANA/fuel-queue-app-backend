using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDBTestProject.Model
{
    public class FuelQueue
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; } = String.Empty;
        [BsonElement("stationId")]
        public String StationId { get; set; } = String.Empty;
        [BsonElement("noOfVehicle")]
        // This is the total number of vehicles in the Queue.
        public int NoOfVehicles { get; set; }

        // User id 
        // Pump Id 
        // NooOfVehicle -> Vehicle number plate ID
        // Status (Pending, Already)

    }
}
