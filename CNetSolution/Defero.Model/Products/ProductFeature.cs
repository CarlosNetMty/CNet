using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Delta.Core;
using System.Threading.Tasks;

namespace Delta.Model.Products
{
    public class ProductFeature : Entity
    {
        [Required, MaxLength(100)] public string Name { get; set; }
        public virtual ICollection<ProductFeatureValue> AvailableValues { get; set; }
    }
}
