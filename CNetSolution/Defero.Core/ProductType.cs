using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Defero.Core
{
    public class ProductType
    {
        public ICollection<ProductSpecializationFeature> SpecializationFeatures { get; set; }
        public ICollection<ProductFeature> DefinitionFeatures { get; set; }

        public string Name { get; set; }
    }
}
