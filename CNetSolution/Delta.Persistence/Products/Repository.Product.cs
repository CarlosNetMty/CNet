using Delta.Core;
using Delta.Model.Products;
using System.Data.Entity;

namespace Delta.Persistence.Products
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
