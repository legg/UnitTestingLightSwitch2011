//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    
    [global::System.ServiceModel.DomainServices.Hosting.EnableClientAccess()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataDomainService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DomainService<global::ApplicationData.Implementation.ApplicationDataObjectContext>
    {
    
        public ApplicationDataDomainService() : base()
        {
        }
    
    #region Public Methods
    
    #region Product
    
        public void InsertProduct(global::ApplicationData.Implementation.Product entity)
        {
            if (entity.EntityState != global::System.Data.EntityState.Detached)
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(entity, global::System.Data.EntityState.Added);
            }
            else
            {
                this.ObjectContext.Products.AddObject(entity);
            }
        }
    
        public void UpdateProduct(global::ApplicationData.Implementation.Product currentEntity)
        {
            global::System.ServiceModel.DomainServices.EntityFramework.ObjectContextExtensions.AttachAsModified(this.ObjectContext.Products, currentEntity, this.ChangeSet.GetOriginal(currentEntity));
        }
    
        public void DeleteProduct(global::ApplicationData.Implementation.Product entity)
        {
            if (entity.EntityState == global::System.Data.EntityState.Detached)
            {
                this.ObjectContext.Products.Attach(entity);
            }
    
            this.DeleteEntity(entity);
        }
    #endregion
    
    #region Customer
    
        public void InsertCustomer(global::ApplicationData.Implementation.Customer entity)
        {
            if (entity.EntityState != global::System.Data.EntityState.Detached)
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(entity, global::System.Data.EntityState.Added);
            }
            else
            {
                this.ObjectContext.Customers.AddObject(entity);
            }
        }
    
        public void UpdateCustomer(global::ApplicationData.Implementation.Customer currentEntity)
        {
            global::System.ServiceModel.DomainServices.EntityFramework.ObjectContextExtensions.AttachAsModified(this.ObjectContext.Customers, currentEntity, this.ChangeSet.GetOriginal(currentEntity));
        }
    
        public void DeleteCustomer(global::ApplicationData.Implementation.Customer entity)
        {
            if (entity.EntityState == global::System.Data.EntityState.Detached)
            {
                this.ObjectContext.Customers.Attach(entity);
            }
    
            this.DeleteEntity(entity);
        }
    #endregion
    
    #region Order
    
        public void InsertOrder(global::ApplicationData.Implementation.Order entity)
        {
            if (entity.EntityState != global::System.Data.EntityState.Detached)
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(entity, global::System.Data.EntityState.Added);
            }
            else
            {
                this.ObjectContext.Orders.AddObject(entity);
            }
        }
    
        public void UpdateOrder(global::ApplicationData.Implementation.Order currentEntity)
        {
            global::System.ServiceModel.DomainServices.EntityFramework.ObjectContextExtensions.AttachAsModified(this.ObjectContext.Orders, currentEntity, this.ChangeSet.GetOriginal(currentEntity));
        }
    
        public void DeleteOrder(global::ApplicationData.Implementation.Order entity)
        {
            if (entity.EntityState == global::System.Data.EntityState.Detached)
            {
                this.ObjectContext.Orders.Attach(entity);
            }
    
            this.DeleteEntity(entity);
        }
    #endregion
    
    #region Queries
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Product> Products_Single(string frameworkOperators, global::System.Nullable<int> Id)
        {
            return this.GetQuery<global::ApplicationData.Implementation.Product>("Products_Single", frameworkOperators, Id);
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Product> Products_SingleOrDefault(string frameworkOperators, global::System.Nullable<int> Id)
        {
            return this.GetQuery<global::ApplicationData.Implementation.Product>("Products_SingleOrDefault", frameworkOperators, Id);
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Product> Products_All(string frameworkOperators)
        {
            return this.GetQuery<global::ApplicationData.Implementation.Product>("Products_All", frameworkOperators);
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Customer> Customers_Single(string frameworkOperators, global::System.Nullable<int> Id)
        {
            return this.GetQuery<global::ApplicationData.Implementation.Customer>("Customers_Single", frameworkOperators, Id);
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Customer> Customers_SingleOrDefault(string frameworkOperators, global::System.Nullable<int> Id)
        {
            return this.GetQuery<global::ApplicationData.Implementation.Customer>("Customers_SingleOrDefault", frameworkOperators, Id);
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Customer> Customers_All(string frameworkOperators)
        {
            return this.GetQuery<global::ApplicationData.Implementation.Customer>("Customers_All", frameworkOperators);
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Order> Orders_Single(string frameworkOperators, global::System.Nullable<int> Id)
        {
            return this.GetQuery<global::ApplicationData.Implementation.Order>("Orders_Single", frameworkOperators, Id);
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Order> Orders_SingleOrDefault(string frameworkOperators, global::System.Nullable<int> Id)
        {
            return this.GetQuery<global::ApplicationData.Implementation.Order>("Orders_SingleOrDefault", frameworkOperators, Id);
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Order> Orders_All(string frameworkOperators)
        {
            return this.GetQuery<global::ApplicationData.Implementation.Order>("Orders_All", frameworkOperators);
        }
    
    #endregion
    
        [global::System.ServiceModel.DomainServices.Server.Invoke(HasSideEffects=false)]
        public int __GetEntitySetCanInformation(string entitySetName)
        {
            return base.GetEntitySetCanInformation(entitySetName);
        }
    
        [global::System.ServiceModel.DomainServices.Server.Invoke(HasSideEffects=false)]
        public bool __CanExecuteOperation(string operationName)
        {
            return base.CanExecuteOperation(operationName);
        }
    
    #endregion
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService()
        {
            return new global::LightSwitchApplication.DataWorkspace().ApplicationData;
        }
    
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::ApplicationData.Implementation.ApplicationDataObjectContext>
    {
        public ApplicationDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Product> Products_Single(global::System.Nullable<int> Id)
        {
            global::System.Linq.IQueryable<global::ApplicationData.Implementation.Product> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::ApplicationData.Implementation.Product>("Products_All"),
                (p) => (Id.HasValue && (p.Id == Id)));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Product> Products_SingleOrDefault(global::System.Nullable<int> Id)
        {
            global::System.Linq.IQueryable<global::ApplicationData.Implementation.Product> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::ApplicationData.Implementation.Product>("Products_All"),
                (p) => (Id.HasValue && (p.Id == Id)));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Product> Products_All()
        {
            global::System.Linq.IQueryable<global::ApplicationData.Implementation.Product> query;
            query = base.CreateQuery<global::ApplicationData.Implementation.Product>("[Products]").AsQueryable();
            return query;
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Customer> Customers_Single(global::System.Nullable<int> Id)
        {
            global::System.Linq.IQueryable<global::ApplicationData.Implementation.Customer> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::ApplicationData.Implementation.Customer>("Customers_All"),
                (c) => (Id.HasValue && (c.Id == Id)));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Customer> Customers_SingleOrDefault(global::System.Nullable<int> Id)
        {
            global::System.Linq.IQueryable<global::ApplicationData.Implementation.Customer> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::ApplicationData.Implementation.Customer>("Customers_All"),
                (c) => (Id.HasValue && (c.Id == Id)));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Customer> Customers_All()
        {
            global::System.Linq.IQueryable<global::ApplicationData.Implementation.Customer> query;
            query = base.CreateQuery<global::ApplicationData.Implementation.Customer>("[Customers]").AsQueryable();
            return query;
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Order> Orders_Single(global::System.Nullable<int> Id)
        {
            global::System.Linq.IQueryable<global::ApplicationData.Implementation.Order> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::ApplicationData.Implementation.Order>("Orders_All"),
                (o) => (Id.HasValue && (o.Id == Id)));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Order> Orders_SingleOrDefault(global::System.Nullable<int> Id)
        {
            global::System.Linq.IQueryable<global::ApplicationData.Implementation.Order> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::ApplicationData.Implementation.Order>("Orders_All"),
                (o) => (Id.HasValue && (o.Id == Id)));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::ApplicationData.Implementation.Order> Orders_All()
        {
            global::System.Linq.IQueryable<global::ApplicationData.Implementation.Order> query;
            query = base.CreateQuery<global::ApplicationData.Implementation.Order>("[Orders]").AsQueryable();
            return query;
        }
    
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::ApplicationData.Implementation.Product))
            {
                return new global::ApplicationData.Implementation.Product();
            }
            if (type == typeof(global::ApplicationData.Implementation.Customer))
            {
                return new global::ApplicationData.Implementation.Customer();
            }
            if (type == typeof(global::ApplicationData.Implementation.Order))
            {
                return new global::ApplicationData.Implementation.Order();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::ApplicationData.Implementation.ApplicationDataObjectContext CreateObjectContext()
        {
            return new global::ApplicationData.Implementation.ApplicationDataObjectContext(base.GetEntityConnectionString(
                "_IntrinsicData", 
                "res://*/ApplicationData.csdl|res://*/ApplicationData.ssdl|res://*/ApplicationData.msl",
                "System.Data.SqlClient"));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Product))
            {
                return new global::ApplicationData.Implementation.Product();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Customer))
            {
                return new global::ApplicationData.Implementation.Customer();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Order))
            {
                return new global::ApplicationData.Implementation.Order();
            }
            return null;
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Product) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.Product);
            }
            if (typeof(global::LightSwitchApplication.Customer) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.Customer);
            }
            if (typeof(global::LightSwitchApplication.Order) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.Order);
            }
            return null;
        }
    }
}

namespace ApplicationData.Implementation
{

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Product :
        global::LightSwitchApplication.Product.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Product.DetailsClass.IImplementation.Orders
        {
            get
            {
                return this.Orders;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Customer :
        global::LightSwitchApplication.Customer.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Customer.DetailsClass.IImplementation.Orders
        {
            get
            {
                return this.Orders;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.DataAnnotations.MetadataType(typeof(global::ApplicationData.Implementation.Order.Metadata))]
    public partial class Order :
        global::LightSwitchApplication.Order.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Order.DetailsClass.IImplementation.Customer
        {
            get
            {
                return this.Customer;
            }
            set
            {
                this.Customer = (global::ApplicationData.Implementation.Customer)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Customer");
                }
            }
        }
        
        partial void OnOrder_CustomerChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Customer");
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Order.DetailsClass.IImplementation.Product
        {
            get
            {
                return this.Product;
            }
            set
            {
                this.Product = (global::ApplicationData.Implementation.Product)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Product");
                }
            }
        }
        
        partial void OnOrder_ProductChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Product");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
        
        internal class Metadata
        {
            [global::System.ServiceModel.DomainServices.Server.Include]
            public global::ApplicationData.Implementation.Customer Customer { get; set; }
        
            [global::System.ServiceModel.DomainServices.Server.Include]
            public global::ApplicationData.Implementation.Product Product { get; set; }
        
        }
    }
    
}
