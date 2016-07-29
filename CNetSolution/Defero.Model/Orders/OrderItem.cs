using Delta.Core;
using System;

namespace Delta.Model.Orders
{
    public abstract class OrderItem : Entity
    {
        public int Amount { get; set; }
    }
}
