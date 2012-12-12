using System.Collections.Generic;
using UnitTestingLightSwitch2011.Business.Abstract;

namespace UnitTestingLightSwitch2011.Business
{
    /// <summary>
    /// Business logic extracted from lightswitch screen code. 
    /// NB. There are no lightswitch dependencies in this class or project. 
    /// </summary>
    public class OrderScreenValidationController
    {
        private IScreenValidationModel _model;

        public OrderScreenValidationController(IScreenValidationModel model)
        {
            _model = model;
        }
        /// <summary>
        /// An order requires a customer and an available product.
        /// </summary>
        /// <param name="errorMessages">Error messages to be returned to the user</param>
        /// <returns>True if orders are valid</returns>
        public bool ValidateOrders(out IEnumerable<string> errorMessages)
        {
            /* This code is extracted from the lightswitch screen code */
            var errors = new List<string>();

            foreach (var o in _model.Orders)
            {
                if (o.Customer == null)
                    errors.Add("An order requires a customer.");

                if (o.Customer == null)
                    errors.Add("An order requires a product.");

                if (o.Product != null && !o.Product.Available)
                    errors.Add(o.Product.Name + " are not available to order.");
            }

            errorMessages = errors;

            return (errors.Count == 0);
        }
    }
}
