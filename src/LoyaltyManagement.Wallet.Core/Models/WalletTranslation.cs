namespace LoyaltyManagement.Wallet.Core.Models
{
    public class WalletTranslation
    {
        public int Id { get; set; }
        public int WalletId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Locale { get; set; } = string.Empty;
    }
}
