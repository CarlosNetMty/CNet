using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Delta.Core;

namespace Delta.Model
{
    public class ProductFeatureValue : Entity
    {
        public ProductFeature Feature { get; set; }
        public string Value { get; set; }
    }
}
