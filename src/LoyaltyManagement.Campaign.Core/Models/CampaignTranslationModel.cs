﻿namespace LoyaltyManagement.Campaign.Core.Models
{
    public class CampaignTranslationModel
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
    }
}
