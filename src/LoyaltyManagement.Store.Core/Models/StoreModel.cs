namespace LoyaltyManagement.Store.Core.Models
{
    public class StoreModel
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
