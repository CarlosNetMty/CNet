using Delta.Core;
using Delta.Model.Orders;
using System.Data.Entity;

namespace Delta.Persistence.Orders
{
    public class OrderRepository :
        Repository<Order>,
        IReadOnlyRepository<Order>,
        IRepository<Order>
    {
        public OrderRepository(Context dbContext) : base(dbContext)
        { }

        public override DbSet<Order> Store
        {
            get { return dbContext.Orders; }
        }
    }
}
