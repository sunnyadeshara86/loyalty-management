namespace LoyaltyManagement.Campaign.Core.Models
{
    public class CampaignRule
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public List<CampaignRuleCondition> CampaignRuleConditions { get; set; } = new();
        public List<CampaignRuleEffect> CampaignRuleEffects { get; set; } = new();
    }
}
