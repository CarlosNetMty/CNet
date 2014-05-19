using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Defero.Core
{
    public class Product
    {
        public ProductType Type { get; set; }
        
        public string Name { get; set; }
        public IDictionary<ProductCodeTypes, string> Codes { get; set; }

        public ICollection<ProductFeature> DefinitionFeatures { get; set; }
        public ICollection<ProductSpecializationFeature> SpecializationFeatures { get; set; }

        //public string FullName 
        //{ 

        //}
    }
}
