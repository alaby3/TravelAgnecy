using DDD.SharedKernel.DomainModelLayer;
using System;

namespace DDD.TravelAgency.Core.DomainModelLayer.Events
{
    public class BookingCreatedDomainEvent : IDomainEvent
    {
        public long Created { get; protected set; }

        public long BookingId { get; protected set; }
        public long CustomerId { get; protected set; }
        public long TripId { get; protected set; }

        public BookingCreatedDomainEvent(long bookingId, long customerId, long tripId)
        {
            Created = DateTime.UtcNow.Ticks;
            BookingId = bookingId;
            CustomerId = customerId;
            TripId = tripId;
        }
    }
}