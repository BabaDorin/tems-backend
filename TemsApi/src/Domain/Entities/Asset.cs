namespace Domain.Entities
{
    public class Asset
    {
<<<<<<< Updated upstream
        public Guid Id { get; set; } = Guid.NewGuid();
=======
        public Guid Id { get; set; }
>>>>>>> Stashed changes
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
