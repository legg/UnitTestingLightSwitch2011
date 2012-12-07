using System.Collections.Generic;
using UnitTestingLightSwitch2011.Entity;

namespace UnitTestingLightSwitch2011.Data.Entity
{
    public class Customer : ICustomer
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public virtual IEnumerable<IOrder> Orders { get; set; }
    }
}
