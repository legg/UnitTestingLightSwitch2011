using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace UnitTestingLightSwitch2011.Entity
{
    public interface IOrder
    {
        [Key]
        int ID { get; set; }
        [DataMember]
        ICustomer Customer { get; set; }
        [DataMember]
        DateTime Date { get; set; }
        [DataMember]
        IEnumerable<IOrderLine> OrderLines { get; set; }
    }
}
