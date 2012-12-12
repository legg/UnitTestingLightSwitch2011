using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnitTestingLightSwitch2011.Entity
{
    /// <summary>
    /// A product can be place on many orders provided they are available
    /// </summary>
    public interface IProduct
    {
        int Id { get; set; }
        bool Available { get; set; }
        string Description { get; set; }
        string Name { get; set; }
        IEnumerable<IOrder> Orders { get; }
    }
}
