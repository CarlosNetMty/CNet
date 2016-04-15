using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Defero.Core;

namespace Defero.Model
{
    public class ProductFeature : ModelBase
    {
        public string Name { get; set; }
        public ICollection<ProductFeatureValue> AvailableValues { get; set; }
    }
}
