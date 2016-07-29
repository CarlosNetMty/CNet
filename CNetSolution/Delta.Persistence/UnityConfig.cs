using Delta.Core;
using Delta.Model.Orders;
using Delta.Model.Products;
using Delta.Persistence.Orders;
using Delta.Persistence.Products;
using Microsoft.Practices.Unity;

namespace Delta.Persistence
{
    public static class UnityConfig
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<Context>();
            #region Orders
            container.RegisterType<IRepository<Order>, OrderRepository>();
            container.RegisterType<IRepository<OrderItem>, OrderItemRepository>();
            #endregion
            #region Products
            container.RegisterType<IRepository<Product>, ProductRepository>();
            container.RegisterType<IRepository<ProductCategory>, ProductCategoryRepository>();
            container.RegisterType<IRepository<ProductCode>, ProductCodeRepository>();
            container.RegisterType<IRepository<ProductFeature>, ProductFeatureRepository>();
            container.RegisterType<IRepository<ProductFeatureValue>, ProductFeatureValueRepository>();
            container.RegisterType<IRepository<ProductType>, ProductTypeRepository>();
            #endregion
        }
    }
}
