using DDD.SharedKernel.DomainModelLayer.Implementations;
using DDD.SharedKernel.DomainModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.TravelAgency.Core.DomainModelLayer.Models
{
    public class Customer : Entity, IAggregateRoot
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public DateOnly BirthDate { get; protected set; }


        protected Customer() { } // na potrzeby serializacji

        //public Customer 



    }
}
