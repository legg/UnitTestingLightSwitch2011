using System.Collections.Generic;
using UnitTestingLightSwitch2011.Entity;

namespace UnitTestingLightSwitch2011.Data.Entity
{
    public class Product : IProduct
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<IOrderLine> OrderLines { get; set; }
    }
}
