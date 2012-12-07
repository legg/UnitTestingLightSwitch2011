using System;
using System.Collections.Generic;
using UnitTestingLightSwitch2011.Entity;

namespace UnitTestingLightSwitch2011.Data.Entity
{
    public class Order : IOrder
    {
        public int ID { get; set; }

        public ICustomer Customer { get; set; }

        public DateTime Date { get; set; }

        public virtual IEnumerable<IOrderLine> OrderLines { get; set; }
    }
}
