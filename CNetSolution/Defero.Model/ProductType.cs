using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Defero.Core;

namespace Defero.Model
{
    public class ProductType : ModelBase
    {
        public string Name { get; set; }
        public ICollection<ProductFeature> Features { get; set; }
        public ICollection<ProductCategory> Categories { get; set; }
    }
}
