using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Defero.Core;

namespace Defero.Model
{
    public class ProductFeatureValue : ModelBase
    {
        public Product Product { get; set; }
        public ProductFeature Feature { get; set; }
        public string Value { get; set; }
    }
}
