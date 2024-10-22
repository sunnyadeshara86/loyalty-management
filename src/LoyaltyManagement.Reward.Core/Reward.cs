namespace LoyaltyManagement.Reward.Core
{
    public class Reward
    {
        public int Id { get; set; }
        public int RewardCategoryId { get; set; }
        public int StoreId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public decimal Tax { get; set; }
        public decimal Price { get; set; }
        public decimal TaxPriceValue { get; set; }
        public string Target { get; set; } = string.Empty;
        public bool ActivityAllTime { get; set; }
        public DateTime ActivityFrom { get; set; }
        public DateTime ActivityTo { get; set; }
        public bool VisibilityAllTime { get; set; }
        public DateTime VisibilityFrom { get; set; }
        public DateTime VisibilityTo { get; set; }
        public bool Featured { get; set; }
        public bool Public { get; set; }
        public decimal CostInPoints { get; set; }
        public int SourceWalletId { get; set; }
        public int UsageLimitPerUser { get; set; }
        public int UsageLimitGeneral { get; set; }
        public bool FulfilmentTracking { get; set; }
        public bool IsActive { get; set; }

        public List<RewardCategoryReward> RewardCategories { get; set; } = new();
        public List<RewardTranslation> RewardTranslations { get; set; } = new();
        public List<RewardLevel> RewardLevels { get; set; } = new();
        public List<RewardSegment> RewardSegments { get; set; } = new();
        public List<RewardLabel> RewardLabels { get; set; } = new();
    }
}
