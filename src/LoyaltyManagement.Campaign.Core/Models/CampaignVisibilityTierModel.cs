namespace LoyaltyManagement.Campaign.Core.Models
{
    public class CampaignVisibilityTierModel
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public int TierId { get; set; }
    }
}
