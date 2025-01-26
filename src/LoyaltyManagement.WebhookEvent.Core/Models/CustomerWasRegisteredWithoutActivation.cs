﻿using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class CustomerWasRegisteredWithoutActivation : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public CustomerWasRegisteredWithoutActivation()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}
