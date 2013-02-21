using TechTalk.SpecFlow;
using UnitTestingLightSwitch2011.Business;

namespace UnitTestingLightSwitch2011.Specification.ScenarioContextWrapper
{
    public static class CustomerValidationContext
    {
        public static CustomerValidationController Target
        {
            get { return (CustomerValidationController) ScenarioContext.Current["CustomerValidationControllerTarget"]; }
            set { ScenarioContext.Current.Add("CustomerValidationControllerTarget", value); }
        }

        public static bool Result
        {
            get { return (bool) ScenarioContext.Current["ValidateCustomerResult"]; }
            set { ScenarioContext.Current.Add("ValidateCustomerResult", value); }
        }
    }
}