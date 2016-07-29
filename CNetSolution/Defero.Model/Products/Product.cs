using Delta.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Delta.Model.Products
{
    public class Product  : Entity
    {
        [Required] public ProductCategory Category { get; set; }
        [Required] public ProductType Type { get; set; }    
        [Required, MaxLength(200)] public string Name { get; set; }
        public virtual ICollection<ProductCode> Codes { get; set; }
        public virtual ICollection<ProductFeatureValue> Definition { get; set; }
    }
}
