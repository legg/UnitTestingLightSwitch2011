using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using UnitTestingLightSwitch2011.Entity;

namespace LightSwitchApplication
{
    public partial class Product : IProduct
    {
        IEnumerable<IOrder> IProduct.Orders
        {
            get { return Orders.Cast<IOrder>(); }
        }
    }
}
