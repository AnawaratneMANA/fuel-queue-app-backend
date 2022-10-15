﻿using MongoDB.Bson;
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
    }
}
