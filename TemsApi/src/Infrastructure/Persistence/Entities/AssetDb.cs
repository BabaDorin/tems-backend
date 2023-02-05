using Domain.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Persistence.Entities
{
    public class AssetDb
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        public string ClientId { get; set; }
        public string TemsId { get; set; }
        [BsonRepresentation(BsonType.DateTime)]
        public string UploadedBy { get; set; }
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime UploadedAt { get; set; }
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime PurchasedAt { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid TypeId { get; set; }
        public PriceDb Price { get; set; }
        public AssetDefinitionDb Definition { get; set; }
    }
}
