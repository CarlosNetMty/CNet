using Delta.Core;
using Delta.Model.Orders;
using System.Data.Entity;

namespace Delta.Persistence.Orders
{
    public class OrderItemRepository :
        Repository<OrderItem>,
        IReadOnlyRepository<OrderItem>,
        IRepository<OrderItem>
    {
        public OrderItemRepository(Context dbContext) : base(dbContext)
        { }
        public override DbSet<OrderItem> Store
        {
            get { return dbContext.OrderItems; }
        }
    }
}
