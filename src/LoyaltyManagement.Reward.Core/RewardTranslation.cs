namespace LoyaltyManagement.Reward.Core
{
    public class RewardTranslation
    {
        public int Id { get; set; }
        public int RewardId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
    }
}
