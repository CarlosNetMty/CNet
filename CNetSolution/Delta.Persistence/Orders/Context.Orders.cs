using Delta.Model.Orders;
using System.Data.Entity;

namespace Delta.Persistence
{
    public partial class Context
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
