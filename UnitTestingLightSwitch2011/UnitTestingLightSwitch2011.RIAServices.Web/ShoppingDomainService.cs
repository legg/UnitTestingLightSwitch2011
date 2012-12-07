namespace UnitTestingLightSwitch2011.RIAServices.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using UnitTestingLightSwitch2011.Entity;
    using UnitTestingLightSwitch2011.Repository.Abstract;
    using UnitTestingLightSwitch2011.Data.Entity;

    // TODO: Create methods containing your application logic.
    [EnableClientAccess()]
    public class ShoppingDomainService : DomainService, IShoppingRepository
    {
        private IShoppingRepository _repository;

        public ShoppingDomainService()
        {
            _repository = new ShoppingDomainService();
        }

        [Query(IsDefault = true)]
        public IQueryable<Customer> Customers()
        {
            return _repository.Customers();
        }

        public IQueryable<Order> Orders()
        {
            return _repository.Orders();
        }

        public IQueryable<OrderLine> OrderLines()
        {
            return _repository.OrderLines();
        }

        public IQueryable<Product> Products()
        {
            return _repository.Products();
        }
    }
}


