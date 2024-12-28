namespace LoyaltyManagement.Reward.Core
{
    public class RewardCategoryTranslation
    {
        public int Id { get; set; }
        public int RewardCategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
    }
}
