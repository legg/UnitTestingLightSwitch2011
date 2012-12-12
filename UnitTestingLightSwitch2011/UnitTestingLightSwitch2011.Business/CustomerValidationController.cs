using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnitTestingLightSwitch2011.Entity;

namespace UnitTestingLightSwitch2011.Business
{
    /// <summary>
    /// Business logic extracted from lightswitch entity code. 
    /// NB. There are no lightswitch dependencies in this class or project. 
    /// </summary>
    public class CustomerValidationController
    {
        private ICustomer _model;

        public CustomerValidationController(ICustomer model)
        {
            _model = model;
        }
        /// <summary>
        /// A customer name has to be at least 3 character and contain no numbers.
        /// </summary>
        /// <param name="errorMessages">Error messages to be returned to the user</param>
        /// <returns>True if orders are valid</returns>
        public bool ValidateCustomer(out IEnumerable<string> errorMessages)
        {
            /* This code is extracted from the lightswitch entity code */
            var errors = new List<string>();

            if (_model.Name != null)
            {
                if (_model.Name.Length < 3)
                    errors.Add("Names cannot be less than 3 characters");

                var reg = Regex.Match(_model.Name, @"[0-9]");
                if (reg.Success)
                    errors.Add("Names cannot contain numbers");
            }

            errorMessages = errors;

            return (errors.Count == 0);
        }
    }
}
