using Delta.Core;
using Delta.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Persistence
{
    public class DeltaContext : DbContext, IStore
    {
        public static readonly string DatabaseName = "SigmaDatabase";
        public DeltaContext() : base(DatabaseName) { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);         
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<ProductFeatureValue> ProductFeatureValues { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        public void Add(Entity entity) { this.Add((dynamic)entity); }
        protected void Add(Product entity) { this.Products.Add(entity); }
        protected void Add(ProductCategory entity) { this.ProductCategories.Add(entity); }
        protected void Add(ProductFeature entity) { this.ProductFeatures.Add(entity); }
        protected void Add(ProductFeatureValue entity) { this.ProductFeatureValues.Add(entity); }
        protected void Add(ProductType entity) { this.ProductTypes.Add(entity); }

        public void Remove(Entity entity) { this.Remove((dynamic)entity); }
        protected void Remove(Product entity) { this.Products.Remove(entity); }
        protected void Remove(ProductCategory entity) { this.ProductCategories.Remove(entity); }
        protected void Remove(ProductFeature entity) { this.ProductFeatures.Remove(entity); }
        protected void Remove(ProductFeatureValue entity) { this.ProductFeatureValues.Remove(entity); }
        protected void Remove(ProductType entity) { this.ProductTypes.Remove(entity); }
        public void Save() { this.SaveChanges(); }
    }
}
