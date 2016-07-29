using Delta.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Model.Products
{
    public class ProductCode : Entity
    {
        [Required] public Product Product { get; set; }
        [Required] public ProductCodeTypes Type { get; set; }
        [Required, MaxLength(100)] public string Code { get; set; }
    }
}
