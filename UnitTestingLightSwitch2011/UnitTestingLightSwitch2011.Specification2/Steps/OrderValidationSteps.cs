using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TechTalk.SpecFlow;
using UnitTestingLightSwitch2011.Business;
using UnitTestingLightSwitch2011.Business.Abstract;
using UnitTestingLightSwitch2011.Entity;

namespace UnitTestingLightSwitch2011.Specification.Steps
{
    [Binding]
    public class OrderValidationSteps
    {
        [Given(@"a valid customer")]
        public void GivenAValidCustomer()
        {
            ScenarioContext.Current.Add("Valid_Customer", new Mock<ICustomer>());
        }

        [Given(@"an available product")]
        public void GivenAnAvailableProduct()
        {
            var availableProductMock = new Mock<IProduct>();
            availableProductMock.SetupGet(p => p.Available).Returns(true);

            ScenarioContext.Current.Add("Available_Product", availableProductMock);
        }

        [Given(@"an order created from customer and product")]
        public void GivenAnOrderCreatedFromCustomerAndProduct()
        {
            var customer = ((Mock<ICustomer>) ScenarioContext.Current["Valid_Customer"]).Object;
            var product = ((Mock<IProduct>)ScenarioContext.Current["Available_Product"]).Object;

            var order = new Mock<IOrder>();
            order.SetupGet(o => o.Customer).Returns(customer);
            order.SetupGet(o => o.Product).Returns(product);

            var orderModel = new Mock<IScreenValidationModel>();
            orderModel.SetupGet(m => m.Orders).Returns(new[] { order.Object });
            ScenarioContext.Current.Add("Order_Model", orderModel);
        }

        [When(@"the order is validated")]
        public void WhenTheOrderIsValidated()
        {
            var orderModel = ((Mock<IScreenValidationModel>) 
                ScenarioContext.Current["Order_Model"]).Object;

            var target = new OrderScreenValidationController(orderModel);

            IEnumerable<string> errorMessages;
            var result = target.ValidateOrders(out errorMessages);
            ScenarioContext.Current.Add("IsValid", result);
        }

        [Then(@"the order is valid")]
        public void ThenTheOrderIsValid()
        {
            Assert.IsTrue((bool)ScenarioContext.Current["IsValid"]);
        }
    }
}
