using Delta.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Delta.Model.Orders
{
    public class Order : Entity
    {
        [Required] public DateTime Date { get; set; }
        [Required] public decimal Total { get; set; }
        public virtual ICollection<OrderItem> Content { get; set; }
    }
}
