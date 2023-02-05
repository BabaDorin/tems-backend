using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Persistence.Entities
{
    public class AssetDefinitionDb
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string TypeId { get; set; }
        public string ClientId { get; set; }
        public string Name { get; set; }
    }
}
