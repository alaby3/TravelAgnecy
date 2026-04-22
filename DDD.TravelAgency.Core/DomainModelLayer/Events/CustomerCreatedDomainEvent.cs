using DDD.SharedKernel.DomainModelLayer;
using System;

namespace DDD.TravelAgency.Core.DomainModelLayer.Events
{
    public class CustomerCreatedDomainEvent : IDomainEvent
    {
        public long Created { get; protected set; }

        public long CustomerId { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Email { get; protected set; }

        public CustomerCreatedDomainEvent(long customerId, string firstName, string lastName, string email)
        {
            Created = DateTime.UtcNow.Ticks;
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}