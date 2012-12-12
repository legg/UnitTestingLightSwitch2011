using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using UnitTestingLightSwitch2011.Entity;
namespace LightSwitchApplication
{
    public partial class Order : IOrder
    {

        ICustomer IOrder.Customer
        {
            get
            {
                return this.Customer;
            }
            set
            {
                this.Customer = (Customer)value;
            }
        }

        IProduct IOrder.Product
        {
            get
            {
                return this.Product;
            }
            set
            {
                this.Product = (Product)value;
            }
        }
    }
}
