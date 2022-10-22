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

        [BsonElement("vehicleNumber")]
        public String VehicleNumber { get; set; } = String.Empty;


        [BsonElement("user_id")]
        public String UserId { get; set; } = String.Empty;


        [BsonElement("pump_id")]
        public String PumpId { get; set; } = String.Empty;


        [BsonElement("status")]
        public String Status { get; set; } = String.Empty;

        [BsonElement("startDateTime")]
        public DateTime StartingDateTime { get; set; }


        // User id 
        // Pump Id 
        // NooOfVehicle -> Vehicle number plate ID
        // Status (Pending, Already)

    }
}
