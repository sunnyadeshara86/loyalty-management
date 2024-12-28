namespace LoyaltyManagement.Reward.Core
{
    public class RewardLabel
    {
        public int Id { get; set; }
        public int RewardId { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
