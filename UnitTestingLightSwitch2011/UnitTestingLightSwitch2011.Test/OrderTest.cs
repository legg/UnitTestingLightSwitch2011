using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestingLightSwitch2011.Business;
using UnitTestingLightSwitch2011.Business.Abstract;
using UnitTestingLightSwitch2011.Entity;

namespace UnitTestingLightSwitch2011.Test
{
    /// <summary>
    /// Unit Test for LightSwitch.
    /// NB. There are no dependencies on LightSwitch in this class or project.
    /// </summary>
    [TestClass]
    public class OrderTest
    {
        private IOrder newMockIOrderWithCustomerAndAvailableProduct()
        {
            var customerMock = new Mock<ICustomer>();
            var availableProductMock = new Mock<IProduct>();
            availableProductMock.SetupGet(p => p.Available).Returns(true);

            var mock = new Mock<IOrder>();
            mock.SetupGet(o => o.Customer).Returns(customerMock.Object);
            mock.SetupGet(o => o.Product).Returns(availableProductMock.Object);
            return mock.Object;
        }

        [TestMethod]
        public void Given_an_order_has_a_customer_and_has_an_available_product_then_we_can_create_an_order()
        {
            // arrange
            var mock = new Mock<IScreenValidationModel>();

            mock.SetupGet(m => m.Orders).Returns(new[]
                {
                    newMockIOrderWithCustomerAndAvailableProduct()
                }
            );

            var target = new OrderScreenValidationController(mock.Object);

            // act 
            IEnumerable<string> errorMessages;
            var result = target.ValidateOrders(out errorMessages);

            // assert
            Assert.IsTrue(result);
        }
    }
}
