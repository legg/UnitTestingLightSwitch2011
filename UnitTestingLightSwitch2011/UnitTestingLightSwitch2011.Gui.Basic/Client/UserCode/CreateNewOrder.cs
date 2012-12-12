using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using UnitTestingLightSwitch2011.Business;
using UnitTestingLightSwitch2011.Business.Abstract;
using UnitTestingLightSwitch2011.Entity;

namespace LightSwitchApplication
{
    public partial class CreateNewOrder : IScreenValidationModel
    {
        partial void Orders_Validate(ScreenValidationResultsBuilder results)
        {
            /* 
             * This is where the business logic would have gone
             * Compare this code to the code in OrderScreenValidationController.ValidateOrders
             * 
            foreach (var o in this.Orders)
            {
                if (o.Customer == null)
                    results.AddPropertyError("An order requires a customer.");

                if (o.Customer == null)
                    results.AddPropertyError("An order requires a product.");

                if (o.Product != null && !o.Product.Available)
                    results.AddPropertyError(o.Product.Name + " is not available to order.");
            }
             */
            var controller = new OrderScreenValidationController(this);

            IEnumerable<string> errorMessages;

            if (!controller.ValidateOrders(out errorMessages))
            {
                foreach (var error in errorMessages)
                {
                    results.AddPropertyError(error);
                }
            }
        }

        IEnumerable<UnitTestingLightSwitch2011.Entity.IOrder> IScreenValidationModel.Orders
        {
            get { return this.Orders.Cast<IOrder>(); }
        }
    }
}