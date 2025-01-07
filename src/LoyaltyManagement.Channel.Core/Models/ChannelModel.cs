namespace LoyaltyManagement.Channel.Core.Models
{
    public class ChannelModel
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Identifier { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
