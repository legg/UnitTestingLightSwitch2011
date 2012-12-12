using System;
namespace LightSwitchApplication.UserCode
{
    interface IProduct
    {
        bool Available { get; set; }
        string Description { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        Microsoft.LightSwitch.Framework.EntityCollection<LightSwitchApplication.Order> Orders { get; }
    }
}
