namespace LoyaltyManagement.Report.Core.Models
{
    public class BillableReport
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int BillableMembers { get; set; }
        public int BillableTransactions { get; set; }

        public List<BillableReportPerMonth> BillableMembersPerMonth { get; set; } = new();
    }
}
