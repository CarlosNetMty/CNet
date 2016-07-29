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
    public class ProductFeatureValueRepository : 
        Repository<ProductFeatureValue>,
        IReadOnlyRepository<ProductFeatureValue>,
        IRepository<ProductFeatureValue>
    {
        public ProductFeatureValueRepository(Context dbContext) : base(dbContext)
        { }
        public override DbSet<ProductFeatureValue> Store
        {
            get { return dbContext.ProductFeatureValues; }
        }
    }
}
