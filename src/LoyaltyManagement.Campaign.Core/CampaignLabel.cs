namespace LoyaltyManagement.Campaign.Core
{
    public class CampaignLabel
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
