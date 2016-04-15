using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Defero.Core;

namespace Defero.Model
{
    public class ProductCategory : ModelBase
    {
        public string Name { get; set; }
        public ICollection<ProductType> Types { get; set; }
        public ICollection<ProductFeature> Features 
        {
            get 
            {
                return Types
                    .SelectMany(item => item.Features)
                    .Distinct(new GuidDefiniedObjectComparer()) as ICollection<ProductFeature>;
            }
        }
    }
}
