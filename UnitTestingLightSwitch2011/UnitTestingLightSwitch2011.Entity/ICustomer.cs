using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace UnitTestingLightSwitch2011.Entity
{
    public interface ICustomer
    {
        [Key]
        [DataMember]
        int ID { get; set; }
        [DataMember]
        string Name { get; set; }
        [DataMember]
        string Email { get; set; }
        [DataMember]
        IEnumerable<IOrder> Orders { get; set; }
    }
}
