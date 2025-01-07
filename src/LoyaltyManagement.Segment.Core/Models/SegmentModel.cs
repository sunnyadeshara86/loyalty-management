namespace LoyaltyManagement.Segment.Core.Models
{
    public class SegmentModel
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CustomersCount { get; set; }
        public decimal AverageTransactionAmount { get; set; }
        public decimal AverageTransactions { get; set; }
        public decimal AverageClv { get; set; }
        public string Currency { get; set; } = string.Empty;
        public DateTime CalculatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

    }
}
