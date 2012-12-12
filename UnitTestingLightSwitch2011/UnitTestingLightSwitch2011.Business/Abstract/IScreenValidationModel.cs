using System.Collections.Generic;
using UnitTestingLightSwitch2011.Entity;

namespace UnitTestingLightSwitch2011.Business.Abstract
{
    /// <summary>
    /// Represents the data accessible on the lightswitch screen object for the purpose of our validation example.
    /// In lightswitch you will have to Cast<IOrder> the VisualCollection<Order>.
    /// </summary>
    public interface IScreenValidationModel
    {
        IEnumerable<IOrder> Orders { get; }
    }
}
