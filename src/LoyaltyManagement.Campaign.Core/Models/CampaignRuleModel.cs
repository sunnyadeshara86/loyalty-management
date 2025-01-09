namespace LoyaltyManagement.Campaign.Core.Models
{
    public class CampaignRuleModel
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public List<CampaignRuleConditionModel> CampaignRuleConditions { get; set; } = new();
        public List<CampaignRuleEffectModel> CampaignRuleEffects { get; set; } = new();
    }
}
