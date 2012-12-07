using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
namespace UnitTestingLightSwitch2011.Entity
{
    public interface IOrderLine
    {
        [Key]
        [DataMember]
        int ID { get; set; }
        [DataMember]
        int Quantity { get; set; }
        [DataMember]
        bool Complete { get; set; }
        [DataMember]
        IProduct Product { get; set; }
    }
}
