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
        [BsonElement("userId")]
        public String UserId { get; set; } = String.Empty;
        [BsonElement("startDateTime")]
        public String StartingDateTime { get; set; } = String.Empty;
        [BsonElement("endDateTime")]
        public String EndDateTime { get; set; } = String.Empty;
        [BsonElement("fuelAmount")]
        public String FuelAmount { get; set; } = String.Empty;


    }
}
