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
    public class ProductTypeRepository : 
        Repository<ProductType>,
        IReadOnlyRepository<ProductType>,
        IRepository<ProductType>
    {
        public ProductTypeRepository(Context dbContext) : base(dbContext)
        { }
        public override DbSet<ProductType> Store
        {
            get { return dbContext.ProductTypes; }
        }
    }
}
