using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using UnitTestingLightSwitch2011.Data.Entity;
using UnitTestingLightSwitch2011.Entity;
using UnitTestingLightSwitch2011.Repository.Abstract;
using System.Data.Objects;

namespace UnitTestingLightSwitch2011.Repository
{
    public class ShoppingRepository : IShoppingRepository
    {
        public IQueryable<Customer> Customers()
        {
            return new List<Customer>{
                new Customer(){
                    ID = 1,
                    Name = "Max",
                    Email = "maxlegg@gmail.com",
                    Orders = Orders(),
                }
            }.AsQueryable();
        }

        public IQueryable<Order> Orders()
        {
            return new List<Order>{
                new Order(){
                    ID = 10,
                    Date = DateTime.Now,
                }
            }.AsQueryable();
        }

        public IQueryable<OrderLine> OrderLines()
        {
            return new List<OrderLine>{
                new OrderLine(){
                    ID = 100,
                    Complete = false,
                }
            }.AsQueryable();
        }

        public IQueryable<Product> Products()
        {
            return new List<Product>{
                new Product(){
                    ID = 1000,
                    Name = "Lego",
                    Description = "Star Wars Lego",
                }
            }.AsQueryable();
        }
    }
}
