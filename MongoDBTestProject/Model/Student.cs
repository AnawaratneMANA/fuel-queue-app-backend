using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace MongoDBTestProject.Model
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; } = String.Empty;
        [BsonElement("name")]
        public String Name { get; set; } = String.Empty;
        [BsonElement("graduated")]
        public bool IsGraduated { get; set; }

    }
}
