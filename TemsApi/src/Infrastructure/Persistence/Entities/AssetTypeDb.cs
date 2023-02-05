using Domain.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Persistence.Entities
{
    public class AssetTypeDb
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        public string ClientId { get; set; }
        public string Name { get; set; }
        public List<AttributeMetadataDb> Attributes { get; set; }
    }
}
