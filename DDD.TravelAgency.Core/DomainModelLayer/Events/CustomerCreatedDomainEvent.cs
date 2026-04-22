using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.SharedKernel.DomainModelLayer.Implementations;
using DDD.TravelAgency.Core.DomainModelLayer;

namespace DDD.TravelAgency.Core.DomainModelLayer.Events
{
    public class CustomerCreatedDomainEvent
    {

        public long PlayerID { get; protected set; }
        public string FirstName { get; protected set;}
        public string Email { get; protected set;}


        public string LastName { get; protected set;}   


        public CustomerCreatedDomainEvent(long playerID, string firstName, string email, string lastName)
        {
            PlayerID = playerID;
            FirstName = firstName;
            Email = email;
            LastName = lastName;
        }
    }
}
