using DDD.SharedKernel.DomainModelLayer;
using System;

namespace DDD.TravelAgency.Core.DomainModelLayer.Events
{
    public class BookingCancelledDomainEvent : IDomainEvent
    {
        public long Created { get; protected set; }

        public long BookingId { get; protected set; }

        public BookingCancelledDomainEvent(long bookingId)
        {
            Created = DateTime.UtcNow.Ticks;
            BookingId = bookingId;
        }
    }
}