namespace LoyaltyManagement.Language.Core.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string LocaleCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public bool IsDefault { get; set; }
        public bool ApiDefault { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
