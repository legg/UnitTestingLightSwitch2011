using System;
using System.ComponentModel.DataAnnotations;

namespace UnitTestingLightSwitch2011.Entity
{
    /// <summary>
    /// Every order is associated with one customer and one product
    /// </summary>
    public interface IOrder
    {
        int Id { get; set; }
        DateTime OrderDate { get; set; }
        ICustomer Customer { get; set; }
        IProduct Product { get; set; }
    }
}
