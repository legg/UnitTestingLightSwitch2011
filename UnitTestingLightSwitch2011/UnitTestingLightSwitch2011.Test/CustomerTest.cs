using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestingLightSwitch2011.Business;
using UnitTestingLightSwitch2011.Entity;

namespace UnitTestingLightSwitch2011.Test
{
    /// <summary>
    /// Unit Test for LightSwitch.
    /// NB. There are no dependencies on LightSwitch in this class or project.
    /// </summary>
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void Given_a_name_is_3_or_more_chars_and_does_not_contain_numbers_then_a_customer_can_be_created()
        {
            // arrange
            var mock = new Mock<ICustomer>();
            mock.SetupGet(c => c.Name).Returns("Max");

            var target = new CustomerValidationController(mock.Object);
            IEnumerable<string> errorMessages;

            // act
            var result = target.ValidateCustomer(out errorMessages);

            // assert
            Assert.IsTrue(result);
        }
    }
}
