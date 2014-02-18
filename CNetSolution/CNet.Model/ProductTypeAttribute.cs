using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNet.Model
{
    public class ProductType
    {
        [Key] public Guid ProductTypeID { get; set; }
        public string Name { get; set; }

        public bool IsDynamic { get; set; }
        public bool IsPriceModifier { get; set; }
    }

    public class ProductAttribute { }
    public class DynamicProductAttribute : ProductAttribute { }
    public class FixedProductAttribute : ProductAttribute { }
}
