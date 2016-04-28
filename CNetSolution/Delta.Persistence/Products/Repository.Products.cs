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
    public class ProductRepository : 
        Repository<Product>,
        IReadOnlyRepository<Product>,
        IRepository<Product>
    {
        public ProductRepository(Context dbContext) : base(dbContext)
        { }
        public override DbSet<Product> Store
        {
            get { return dbContext.Products; }
        }
    }
}
