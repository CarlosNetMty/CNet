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
    public class ProductCodeRepository : 
        Repository<ProductCode>,
        IReadOnlyRepository<ProductCode>,
        IRepository<ProductCode>
    {
        public ProductCodeRepository(Context dbContext) : base(dbContext)
        { }
        public override DbSet<ProductCode> Store
        {
            get { return dbContext.ProductCodes; }
        }
    }
}
