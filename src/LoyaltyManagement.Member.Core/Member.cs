﻿namespace LoyaltyManagement.Member.Core
{
    public class Member
    {
        public int Id { get; set; }
        public int ReferralId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime RegisteredAt { get; set; }
        public int ChannelId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public DateTime? LastLevelRecalculation { get; set; }
        public string Street { get; set; } = string.Empty;
        public string Address1 { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public int AccountId { get; set; }
        public int ActivePoints { get; set; }
        public int TransferredPoints { get; set; }
        public int LockedPoints { get; set; }
        public int ExpiredPoints { get; set; }
        public int SpentPoints { get; set; }
        public int EarnedPoints { get; set; }
        public int BlockedPoints { get; set; }
        public string LoyaltyCardNumber { get; set; } = string.Empty;
        public int TransactionsCount { get; set; }
        public int ReturnTransactionsCount { get; set; }
        public decimal TransactionsAmount { get; set; }
        public decimal ReturnTransactionsAmount { get; set; }
        public decimal TransactionsAmountWithoutDeliveryCosts { get; set; }
        public decimal AmountExcludedForLevel { get; set; }
        public decimal AverageTransactionAmount { get; set; }
        public decimal AverageReturnTransactionAmount { get; set; }
        public DateTime LastTransactionDate { get; set; }
        public DateTime FirstTransactionDate { get; set; }
        public DateTime LevelAchievementDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Agreement1 { get; set; }
        public bool Agreement2 { get; set; }
        public bool Agreement3 { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public bool Anonymized { get; set; }
        public string ReferralToken { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public int StoreId { get; set; }
        public int TierId { get; set; }
        public bool IsActive { get; set; }

        public List<MemberSegment> Segments { get; set; } = new();
    }
}
