using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch;
using UnitTestingLightSwitch2011.Entity;
using UnitTestingLightSwitch2011.Business;

namespace LightSwitchApplication
{
    public partial class Customer : ICustomer
    {
        partial void Name_Validate(EntityValidationResultsBuilder results)
        {
            /*
             * This is where the business logic would have gone
             * Compare this code to the code in CustomerValidationController.ValidateCustomer
             * 
            if (Name != null)
            {
                if (Name.Length < 3)
                    results.AddPropertyError("Names cannot be less than 3 characters");

                var reg = Regex.Match(Name, @"[0-9]");
                if (reg.Success)
                    results.AddPropertyError("Names cannot contain numbers");
            }
             */
            var controller = new CustomerValidationController(this);

            IEnumerable<string> errorMessages;

            if (!controller.ValidateCustomer(out errorMessages))
            {
                foreach (var error in errorMessages)
                {
                    results.AddPropertyError(error);
                }
            }
        }

        IEnumerable<IOrder> ICustomer.Orders
        {
            get { return Orders.Cast<IOrder>(); }
        }
    }
}
