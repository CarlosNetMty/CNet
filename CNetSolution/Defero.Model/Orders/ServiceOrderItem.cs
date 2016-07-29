using Delta.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Model.Orders
{
    public class ServiceOrderItem : OrderItem
    {
        public Service Service { get; set; }
    }
}
