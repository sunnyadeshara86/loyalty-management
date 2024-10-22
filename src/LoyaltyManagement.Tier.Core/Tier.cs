namespace LoyaltyManagement.Tier.Core
{
    public class Tier
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool HasPhoto { get; set; }
        public int StoreId { get; set; }
        public int SortOrder { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
    }
}
