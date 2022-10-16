using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace MongoDBTestProject.Model
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; } = String.Empty;
        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;
        [BsonElement("age")]
        public string Age { get; set; } = String.Empty;
        [BsonElement("usertype")]
        public string UserType { get; set; } = String.Empty;
        [BsonElement("hashedpassword")]
        public string HashedPassword { get; set; } = String.Empty;
        [BsonElement("email")]
        public string Email { get; set; } = String.Empty;
        [BsonElement("vehicletype")]
        public string VehicleType { get; set; } = String.Empty;

    }
}
