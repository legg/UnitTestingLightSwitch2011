using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitTestingLightSwitch2011.Data.Entity;

namespace UnitTestingLightSwitch2011.Repository.Abstract
{
    public interface IShoppingRepository
    {
        IQueryable<Customer> Customers();
        IQueryable<Order> Orders();
        IQueryable<OrderLine> OrderLines();
        IQueryable<Product> Products();
    }
}
