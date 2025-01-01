namespace LoyaltyManagement.Wallet.Core.Models
{
    public class Wallet
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string UnitSingularName { get; set; } = string.Empty;
        public string UnitPluralName { get; set; } = string.Empty;
        public string UnitDaysExpiryAfter { get; set; } = string.Empty;
        public int UnitDaysActiveCount { get; set; }
        public int UnitYearsActiveCount { get; set; }
        public int UnitDaysLocked { get; set; }
        public bool AllTimeNotLocked { get; set; }
        public bool AllowNegativeBalance { get; set; }
        public DateTime UnitExpiryDate { get; set; }
        public string LimitsPointsIntervalType { get; set; } = string.Empty;
        public int LimitsPointsIntervalValue { get; set; }
        public decimal LimitsPointsValue { get; set; }
        public string PointsPerMemberIntervalType { get; set; } = string.Empty;
        public int PointsPerMemberIntervalValue { get; set; }
        public decimal PointsPerMemberValue { get; set; }
        public bool IsActive { get; set; }

        public List<WalletTranslation> WalletTranslations { get; set; } = new();
    }
}
