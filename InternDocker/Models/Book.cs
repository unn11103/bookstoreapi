using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace InternDocker.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {get;set;}

        [BsonElement("Name")]
        public string bookName{get;set;}
        public decimal Price{get;set;}
        public string Category{get;set;}
        public string Author{get;set;}

    }
}

