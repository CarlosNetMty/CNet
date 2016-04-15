using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Defero.Core;

namespace Defero.Model
{
    public class Product
    {
        public ProductCategory Category { get; set; }
        public ProductType Type { get; set; }    
        public string Name { get; set; }
        public IDictionary<ProductCodeTypes, string> Codes { get; set; }
        public ICollection<ProductFeatureValue> Definition { get; set; }
    }
}
