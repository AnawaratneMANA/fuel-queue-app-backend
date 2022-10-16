using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Xml.Linq;
using System.Numerics;

namespace MongoDBTestProject.Model
{
    /* MODEL CLASS - Fuel Station */
    public class FuelStation
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; } = String.Empty;
        [BsonElement("location")]
        public String Location { get; set; } = String.Empty;
        [BsonElement("noPumps")]
        public int NoOfPumps { get; set; }
        [BsonElement("availability")]
        public String Availability { get; set; } = String.Empty;
        [BsonElement("startingTime")]
        public DateTime StartingTime { get; set; }
        [BsonElement("endingTime")]
        public DateTime EndingTime { get; set; }
        [BsonElement("fuelType")]
        public String FuelType { get; set; } = String.Empty;

    }
}
