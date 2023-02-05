using Domain.Enums;

namespace Infrastructure.Persistence.Entities
{
    public class PriceDb
    {
        public double Amount { get; set; }
        public Currency Currency { get; set; }
    }
}
