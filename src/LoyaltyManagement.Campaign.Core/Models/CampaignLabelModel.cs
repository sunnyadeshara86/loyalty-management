namespace LoyaltyManagement.Campaign.Core.Models
{
    public class CampaignLabelModel
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
