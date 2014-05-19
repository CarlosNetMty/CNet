using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Defero.Core
{
    public class ProductFeature : IGuidDefiniedObject
    {
        public string Name { get; set; }
        public Guid Guid { get; set; }

        public ICollection<ProductFeatureValue> AvailableValues { get; set; }
    }
}
