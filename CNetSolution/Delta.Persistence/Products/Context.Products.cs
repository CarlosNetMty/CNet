using Delta.Model.Products;
using System.Data.Entity;

namespace Delta.Persistence
{
    public partial class Context
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<ProductFeatureValue> ProductFeatureValues { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductCode> ProductCodes { get; set; }
    }
}
