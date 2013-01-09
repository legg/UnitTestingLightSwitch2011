UnitTestingLightSwitch2011
==========================

Proof of concept C# project to Unit Test (or migrate from) LightSwitch


Project
-------

Named LightSwitch 2011, however, you can upgrade this example application to version 2 LightSwitch 2012.

In a nutshell the GoF bridge pattern is used to abstract entities from collections and collections from LightSwitch entities and screens.

The concept used to abstract the code from LightSwitch is similar to and motivated by the UI pattern Model View Presenter (MVP). If you have used MVP with ASP.NET Web Forms you will understand how this example works. (see http://msdn.microsoft.com/en-us/magazine/ff955232.aspx)

Some relevant links with some idea:
http://dotnetwhatnot.pixata.co.uk/2011/07/28/UnitTestingALightswitchApplication.aspx
http://stackoverflow.com/questions/8335685/unit-testing-in-lightswitch
http://social.msdn.microsoft.com/Forums/en-US/lightswitchgeneral/thread/16d40b45-5ede-4c94-a71e-242b65c274c1
http://social.msdn.microsoft.com/Forums/en-US/lightswitchgeneral/thread/9f1f3d08-8d88-47bd-8417-fde31ffd8e30


Implementation notes for your own project
-----------------------------------------

The example application consists of 4 projects. Inside the LightSwitch GUI basic project in File View there are 3 projects (5 if you show all files). 3 of these GUI projects target Silverlight 4 and 2 projects target .NET 4. This is important to know for the following steps.

The Domain project Business and Entity target Silverlight 4. A Silverlight 4 project can be referenced by a .NET 4 project.  Therefore all LightSwitch projects can reference project Entity.

Follow these steps to get your project up and running given your application has a similar structure.

1. Reference the Entity project from all of the LightSwitch Gui projects.
2. Add your custom code to the LightSwitch UserCode directories.
3. Interface your partial entity classes.
4. Interface all partial entity classes in your object model otherwise it won't compile.
5. Abstract and cast collections using IEnumerable.Cast<T>.


1. Reference the Entity project from all of the LightSwitch Gui projects. The Entity project only contains your entity interfaces that can be used across all projects; these are the entities that you want to mock for unit testing. These entities may only be used by your LightSwitch projects, but are available to all.

2. Add your custom code to the LightSwitch UserCode directories. Those directories are located in 3 LightSwitch projects Client, Common and Server. These projects are responsible for the Screen code, Entity code and Data Source code, respectively. In this example there is no custom Data Source code in the Server project. In this example there is unit testing of Screen code and Entity code. The custom code is located in the UserCode directory of each project add this code next.

3. Interface your partial entity classes. Custom Entity code in the Common project is used for custom validation. The problem you will face when testing your custom validation code is not being able to create an instance of the entity.  To help entities in LightSwitch are partial. Therefore, you can inferface the partial entity with one of your Entity project interfaces.  

4. Interface all partial entity classes in your object model otherwise it won't compile. Your object model should be self contained in your Entity project. For instance, focus on the Customer class in the UserCode directory of the the Common project. Customer has a collection of Orders, however the ICustomer interface requires an IEnumerable<IOrder> collection, therefore, Order has to implement IOrder.

5. Abstract and cast collections using IEnumerable.Cast<T>. The LightSwitch entity, for instance, Customer has a property called Orders, which is of type EntityCollection<Order>, again you cannot create an instance. However, it does inherit IEnumerable<T>, as such, your interface requires an IEnumerable<IOrder> collection. Therefore, up cast collections of IEnumerable using the IEnumerable.Cast<T> extension.

You now have business logic code independent from LightSwitch with no dependencies. Have fun testing.
