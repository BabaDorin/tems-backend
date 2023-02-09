using Domain.Entities;
using Infrastructure.Persistence.Entities;

namespace Infrastructure;

public class Mapper
{
    public static AssetDb MapToDb(Asset asset)
    {
        AssetDb assetDb = new()
        {
            Id = asset.Id,
            ClientId = asset.ClientId,
            TemsId = asset.TemsId,
            UploadedBy = asset.UploadedBy,
            UploadedAt = asset.UploadedAt,
            PurchasedAt = asset.PurchasedAt,
            Description = asset.Description,
            Type = asset.Type,
            TypeId = asset.TypeId,
            Price = MapToDb(asset.Price),
            Definition = MapToDb(asset.Definition),
        };

        return assetDb;
    }
    public static AssetDefinitionDb MapToDb(AssetDefinition definition)
    {
        AssetDefinitionDb definitionDb = new()
        {
            Id = definition.Id,
            Type = definition.Type,
            TypeId = definition.TypeId,
            ClientId = definition.ClientId,
            Name = definition.Name
        };

        return definitionDb;
    }
    public static AssetTypeDb MapToDb(AssetType type)
    {
        AssetTypeDb typeDb = new()
        {
            Id = type.Id,
            ClientId = type.ClientId,
            Name = type.Name,
            Attributes = type.Attributes.Select(a => MapToDb(a)).ToList(),
        };

        return typeDb;
    }


    private static PriceDb MapToDb(Price price)
    {
        PriceDb priceDb = new()
        {
            Amount = price.Amount,
            Currency = price.Currency
        };

        return priceDb;
    }
    public static AttributeMetadataDb MapToDb(AttributeMetadata attributeMetadata)
    {
        AttributeMetadataDb attributeMetadataDb = new()
        {
            Name = attributeMetadata.Name,
            DataType = attributeMetadata.DataType,
            IsRequired = attributeMetadata.IsRequired
        };


        return attributeMetadataDb;
    }
    public static AssetType MapToEntity(AssetTypeDb type)
    {
        return new AssetType
        {
            Id = type.Id,
            ClientId = type.ClientId,
            Name = type.Name,
            Attributes = type.Attributes.Select(a => MapToEntity(a)).ToList(),
        };
    }

    public static AttributeMetadata MapToEntity(AttributeMetadataDb attributeMetadata)
    {
        return new AttributeMetadata
        {
            Name = attributeMetadata.Name,
            DataType = attributeMetadata.DataType,
            IsRequired = attributeMetadata.IsRequired
        };
    }
}

