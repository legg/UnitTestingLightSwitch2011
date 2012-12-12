using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace UnitTestingLightSwitch2011.Entity
{
    /// <summary>
    /// A customer can have many orders
    /// </summary>
    public interface ICustomer
    {
        int Id { get; set; }
        string Name { get; set; }
        IEnumerable<IOrder> Orders { get; }
    }
}
