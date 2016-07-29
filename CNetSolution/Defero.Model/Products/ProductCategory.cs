using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Delta.Core;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delta.Model.Products
{
    public class ProductCategory : Entity
    {
        [Required, MaxLength(100)] public string Name { get; set; }
        public virtual ICollection<ProductType> Types { get; set; }
        [NotMapped] public virtual ICollection<ProductFeature> Features 
        {
            get 
            {
                return Types
                    .SelectMany(item => item.Features)
                    .Distinct() as ICollection<ProductFeature>;
            }
        }
    }
}
