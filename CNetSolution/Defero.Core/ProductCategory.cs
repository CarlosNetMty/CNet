using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Defero.Core
{
    public class ProductCategory
    {
        public string Name { get; set; }
        public ICollection<ProductType> DomainItems { get; set; }

        public ICollection<ProductFeature> DomainFeatures 
        {
            get 
            {
                return DomainItems.SelectMany(item => item.DefinitionFeatures)
                    .Union(DomainItems.SelectMany(item => item.SpecializationFeatures.Select(subItem => subItem.Feature)))
                    .Distinct(new GuidDefiniedObjectComparer()) as ICollection<ProductFeature>;
            }
        }
    }
}
