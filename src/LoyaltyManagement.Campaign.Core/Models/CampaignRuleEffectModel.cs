namespace LoyaltyManagement.Campaign.Core.Models
{
    public class CampaignRuleEffectModel
    {
        public int Id { get; set; }
        public int CampaignRuleId { get; set; }
        public string Effect { get; set; } = string.Empty;
        public string PointsRule { get; set; } = string.Empty;
    }
}
