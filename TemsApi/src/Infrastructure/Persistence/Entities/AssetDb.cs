using Domain.Entities;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Persistence.Entities
{
    public class AssetDb
    {
        [BsonId]
        public Guid Id { get; set; }
        public string ClientId { get; set; }
        public string TemsId { get; set; }
        public string UploadedBy { get; set; }
        public DateTime UploadedAt { get; set; }
        public DateTime PurchasedAt { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Guid TypeId { get; set; }
        public Price Price { get; set; }
        public AssetDefinition Definition { get; set; }
    }
}
