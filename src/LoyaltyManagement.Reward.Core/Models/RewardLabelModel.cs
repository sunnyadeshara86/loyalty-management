namespace LoyaltyManagement.Reward.Core.Models
{
    public class RewardLabelModel
    {
        public int Id { get; set; }
        public int RewardId { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
