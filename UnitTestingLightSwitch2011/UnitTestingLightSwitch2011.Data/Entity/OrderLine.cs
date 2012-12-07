using UnitTestingLightSwitch2011.Entity;

namespace UnitTestingLightSwitch2011.Data.Entity
{
    public class OrderLine : IOrderLine
    {
        public int ID { get; set; }

        public int Quantity { get; set; }

        public bool Complete { get; set; }

        public virtual IProduct Product { get; set; }


    }
}
