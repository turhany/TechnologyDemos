using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoSample
{
    public class Employee
    {
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("surname")]
        public string Surname { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
    }
}
