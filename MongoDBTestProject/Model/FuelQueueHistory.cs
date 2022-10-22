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
        public DateTime StartingDateTime { get; set; }
        [BsonElement("endDateTime")]
        public DateTime EndDateTime { get; set; }

    }
}
