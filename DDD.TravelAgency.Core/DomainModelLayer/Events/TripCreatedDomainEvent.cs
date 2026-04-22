using DDD.SharedKernel.DomainModelLayer;
using System;

namespace DDD.TravelAgency.Core.DomainModelLayer.Events
{
    public class TripCreatedDomainEvent : IDomainEvent
    {
        public long Created { get; protected set; }

        public long TripId { get; protected set; }
        public string Name { get; protected set; }

        public TripCreatedDomainEvent(long tripId, string name)
        {
            Created = DateTime.UtcNow.Ticks;
            TripId = tripId;
            Name = name;
        }
    }
}