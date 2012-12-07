using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace UnitTestingLightSwitch2011.Entity
{
    public interface IProduct
    {
        [Key]
        [DataMember]
        int ID { get; set; }
        [DataMember]
        string Name { get; set; }
        [DataMember]
        string Description { get; set; }
        [DataMember]
        IEnumerable<IOrderLine> OrderLines { get; set; }
    }
}
