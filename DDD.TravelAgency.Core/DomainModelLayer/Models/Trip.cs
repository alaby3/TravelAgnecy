using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using DDD.SharedKernel.DomainModelLayer;
using DDD.SharedKernel.DomainModelLayer.Implementations;

namespace DDD.TravelAgency.Core.DomainModelLayer.Models
{


    public enum TripType
    {
        AllInclusive,
        HalfBoard,
        SelfCatering,
        BedAndBreakfast
    }
    public  class Trip : Entity, IAggregateRoot
    {

        //public long Id { get; set; } 
        public string Name { get; set; }    
        public string Description { get; set; }
        
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public TripType Type { get; set;}
    }
}
