namespace LoyaltyManagement.Report.Core
{
    public class BillableReportPerMonth
    {
        public int Id { get; set; }
        public int BillableReportId { get; set; }
        public DateTime Month { get; set; }
        public int Members { get; set; }
        public int Transactions { get; set; }
    }
}
