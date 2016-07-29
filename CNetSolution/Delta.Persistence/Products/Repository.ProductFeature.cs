using Delta.Core;
using Delta.Model;
using Delta.Model.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Persistence.Products
{
    public class ProductFeatureRepository : 
        Repository<ProductFeature>,
        IReadOnlyRepository<ProductFeature>,
        IRepository<ProductFeature>
    {
        public ProductFeatureRepository(Context dbContext) : base(dbContext)
        { }
        public override DbSet<ProductFeature> Store
        {
            get { return dbContext.ProductFeatures; }
        }
    }
}
