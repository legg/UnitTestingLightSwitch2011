

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    public sealed partial class Product : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Product entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Product()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Product(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Product> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Product.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Product_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Product_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.Product.DetailsClass.GetValue(this, global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.Product.DetailsClass.SetValue(this, global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool Available
        {
            get
            {
                return global::LightSwitchApplication.Product.DetailsClass.GetValue(this, global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Available);
            }
            set
            {
                global::LightSwitchApplication.Product.DetailsClass.SetValue(this, global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Available, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Available_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Available_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Available_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Name
        {
            get
            {
                return global::LightSwitchApplication.Product.DetailsClass.GetValue(this, global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Name);
            }
            set
            {
                global::LightSwitchApplication.Product.DetailsClass.SetValue(this, global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Name, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Name_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Name_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Name_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Description
        {
            get
            {
                return global::LightSwitchApplication.Product.DetailsClass.GetValue(this, global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Description);
            }
            set
            {
                global::LightSwitchApplication.Product.DetailsClass.SetValue(this, global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Description, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Description_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Description_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Description_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.Order> Orders
        {
            get
            {
                return global::LightSwitchApplication.Product.DetailsClass.GetValue(this, global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Orders);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.Order> OrdersQuery
        {
            get
            {
                return global::LightSwitchApplication.Product.DetailsClass.GetQuery(this, global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Orders);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Product,
                global::LightSwitchApplication.Product.DetailsClass,
                global::LightSwitchApplication.Product.DetailsClass.IImplementation,
                global::LightSwitchApplication.Product.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass>.Entry
                __ProductEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass>.Entry(
                    global::LightSwitchApplication.Product.DetailsClass.__Product_CreateNew,
                    global::LightSwitchApplication.Product.DetailsClass.__Product_Created,
                    global::LightSwitchApplication.Product.DetailsClass.__Product_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Product __Product_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Product> es)
            {
                return new global::LightSwitchApplication.Product(es);
            }
            private static void __Product_Created(global::LightSwitchApplication.Product e)
            {
                e.Product_Created();
            }
            private static bool __Product_AllowSaveWithErrors(global::LightSwitchApplication.Product e)
            {
                bool result = false;
                e.Product_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Product.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, bool> Available
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Available) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, bool>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, string> Name
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Name) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, string> Description
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Description) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, global::LightSwitchApplication.Order> Orders
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Orders) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, global::LightSwitchApplication.Order>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new bool Available { get; set; }
                new string Name { get; set; }
                new string Description { get; set; }
                new global::System.Collections.IEnumerable Orders { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Product.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, int>.Data> c, global::LightSwitchApplication.Product.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.Product e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.Product e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.Product.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.Product.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.Product e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, bool>.Entry
                    Available = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, bool>.Entry(
                        "Available",
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Available_Stub,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Available_ComputeIsReadOnly,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Available_Validate,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Available_GetImplementationValue,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Available_SetImplementationValue,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Available_OnValueChanged);
                private static void _Available_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Product.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, bool>.Data> c, global::LightSwitchApplication.Product.DetailsClass d, object sf)
                {
                    c(d, ref d._Available, sf);
                }
                private static bool _Available_ComputeIsReadOnly(global::LightSwitchApplication.Product e)
                {
                    bool result = false;
                    e.Available_IsReadOnly(ref result);
                    return result;
                }
                private static void _Available_Validate(global::LightSwitchApplication.Product e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Available_Validate(r);
                }
                private static bool _Available_GetImplementationValue(global::LightSwitchApplication.Product.DetailsClass d)
                {
                    return d.ImplementationEntity.Available;
                }
                private static void _Available_SetImplementationValue(global::LightSwitchApplication.Product.DetailsClass d, bool v)
                {
                    d.ImplementationEntity.Available = v;
                }
                private static void _Available_OnValueChanged(global::LightSwitchApplication.Product e)
                {
                    e.Available_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, string>.Entry
                    Name = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, string>.Entry(
                        "Name",
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Name_Stub,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Name_ComputeIsReadOnly,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Name_Validate,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Name_GetImplementationValue,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Name_SetImplementationValue,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Name_OnValueChanged);
                private static void _Name_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Product.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, string>.Data> c, global::LightSwitchApplication.Product.DetailsClass d, object sf)
                {
                    c(d, ref d._Name, sf);
                }
                private static bool _Name_ComputeIsReadOnly(global::LightSwitchApplication.Product e)
                {
                    bool result = false;
                    e.Name_IsReadOnly(ref result);
                    return result;
                }
                private static void _Name_Validate(global::LightSwitchApplication.Product e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Name_Validate(r);
                }
                private static string _Name_GetImplementationValue(global::LightSwitchApplication.Product.DetailsClass d)
                {
                    return d.ImplementationEntity.Name;
                }
                private static void _Name_SetImplementationValue(global::LightSwitchApplication.Product.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Name = v;
                }
                private static void _Name_OnValueChanged(global::LightSwitchApplication.Product e)
                {
                    e.Name_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, string>.Entry
                    Description = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, string>.Entry(
                        "Description",
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Description_Stub,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Description_ComputeIsReadOnly,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Description_Validate,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Description_GetImplementationValue,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Description_SetImplementationValue,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Description_OnValueChanged);
                private static void _Description_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Product.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, string>.Data> c, global::LightSwitchApplication.Product.DetailsClass d, object sf)
                {
                    c(d, ref d._Description, sf);
                }
                private static bool _Description_ComputeIsReadOnly(global::LightSwitchApplication.Product e)
                {
                    bool result = false;
                    e.Description_IsReadOnly(ref result);
                    return result;
                }
                private static void _Description_Validate(global::LightSwitchApplication.Product e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Description_Validate(r);
                }
                private static string _Description_GetImplementationValue(global::LightSwitchApplication.Product.DetailsClass d)
                {
                    return d.ImplementationEntity.Description;
                }
                private static void _Description_SetImplementationValue(global::LightSwitchApplication.Product.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Description = v;
                }
                private static void _Description_OnValueChanged(global::LightSwitchApplication.Product e)
                {
                    e.Description_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, global::LightSwitchApplication.Order>.Entry
                    Orders = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, global::LightSwitchApplication.Order>.Entry(
                        "Orders",
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Orders_Stub,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Orders_GetReferencedEntities,
                        global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties._Orders_GetEntityCollection);
                private static void _Orders_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Product.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, global::LightSwitchApplication.Order>.Data> c, global::LightSwitchApplication.Product.DetailsClass d, object sf)
                {
                    c(d, ref d._Orders, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Order> _Orders_GetReferencedEntities(global::LightSwitchApplication.Product.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass>(global::LightSwitchApplication.Product.DetailsClass.PropertySetProperties.Orders, ref d._Orders);
                }
                private static global::System.Collections.IEnumerable _Orders_GetEntityCollection(global::LightSwitchApplication.Product.DetailsClass d)
                {
                    return d.ImplementationEntity.Orders;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, bool>.Data _Available;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, string>.Data _Name;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, string>.Data _Description;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass, global::LightSwitchApplication.Order>.Data _Orders;
            
        }
    
        #endregion
    }
    
    #endregion
}