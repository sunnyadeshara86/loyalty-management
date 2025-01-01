namespace LoyaltyManagement.Campaign.Core.Models
{
    public class CampaignRuleCondition
    {
        public int Id { get; set; }
        public int CampaignRuleId { get; set; }
        public string Operator { get; set; } = string.Empty;
        public string Attribute { get; set; } = string.Empty;

        public List<CampaignRuleConditionData> CampaignRuleConditionData { get; set; } = new();
    }
}
