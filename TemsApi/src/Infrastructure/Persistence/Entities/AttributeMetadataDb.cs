using Domain.Enums;

namespace Infrastructure.Persistence.Entities
{
   public class AttributeMetadataDb
    {
        public string Name { get; set; }
        public DataType DataType { get; set; }
        public bool IsRequired { get; set; }
    }
}
