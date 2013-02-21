using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TechTalk.SpecFlow;
using UnitTestingLightSwitch2011.Business;
using UnitTestingLightSwitch2011.Entity;
using UnitTestingLightSwitch2011.Specification.ScenarioContextWrapper;

namespace UnitTestingLightSwitch2011.Specification.Steps
{
    [Binding]
    public class CustomerValidationSteps
    {
        [Given(@"a name is (.*) or more chars with no numbers")]
        public void GivenANameIsOrMoreCharsWithNoNumbers(int p0)
        {
            // arrange
            var mock = new Mock<ICustomer>();
            mock.SetupGet(c => c.Name).Returns("Max");

            CustomerValidationContext.Target = new CustomerValidationController(mock.Object);
        }
        
        [When(@"we go to create a customer")]
        public void WhenWeGoToCreateACustomer()
        {
            IEnumerable<string> errorMessages;

            // act
            CustomerValidationContext.Result = CustomerValidationContext.Target.ValidateCustomer(out errorMessages);
        }
        
        [Then(@"customer is created")]
        public void ThenCustomerIsCreated()
        {
            // assert
            Assert.IsTrue(CustomerValidationContext.Result);
        }
    }
}
