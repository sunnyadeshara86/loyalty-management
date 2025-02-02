﻿namespace LoyaltyManagement.Campaign.Core.Models
{
    public class CampaignModel
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Trigger { get; set; } = string.Empty;
        public DateTime ActivityStartsAt { get; set; }
        public DateTime ActivityEndsAt { get; set; }
        public int DisplayOrder { get; set; }
        public string LimitsPointsIntervalType { get; set; } = string.Empty;
        public int LimitsPointsIntervalValue { get; set; }
        public decimal LimitsPointsValue { get; set; }
        public string LimitsPointsPerMemberIntervalType { get; set; } = string.Empty;
        public int LimitsPointsPerMemberIntervalValue { get; set; }
        public decimal LimitsPointsPerMemberValue { get; set; }
        public string LimitsExecutionsPerMemberIntervalType { get; set; } = string.Empty;
        public int LimitsExecutionsPerMemberIntervalValue { get; set; }
        public decimal LimitsExecutionsPerMemberValue { get; set; }
        public decimal LimitUsagesPointsCurrentValue { get; set; }
        public decimal LimitUsagesPointsLimitValue { get; set; }
        public decimal LimitUsagesPointsRemaining { get; set; }
        public string LimitUsagesPointsIntervalType { get; set; } = string.Empty;
        public string VisibilityTarget { get; set; } = string.Empty;
        public int LimitUsagesPointsIntervalValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

        public List<CampaignRuleModel> CampaignRules { get; set; } = new();
        public List<CampaignLabelModel> CampaignLabels { get; set; } = new();
        public List<CampaignTranslationModel> CampaignTranslations { get; set; } = new();
        public List<CampaignVisibilityTierModel> CampaignVisibilityTiers { get; set; } = new();
        public List<CampaignVisibilitySegmentModel> CampaignVisibilitySegments { get; set; } = new();
    }
}
