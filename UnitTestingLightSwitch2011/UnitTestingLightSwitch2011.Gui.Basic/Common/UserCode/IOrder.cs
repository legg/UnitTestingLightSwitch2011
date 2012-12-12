using System;
namespace LightSwitchApplication.UserCode
{
    interface IOrder
    {
        LightSwitchApplication.Customer Customer { get; set; }
        int Id { get; set; }
        DateTime OrderDate { get; set; }
        LightSwitchApplication.Product Product { get; set; }
    }
}
