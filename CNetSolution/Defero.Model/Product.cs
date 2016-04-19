using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delta.Core;

namespace Delta.Model
{
    public class Product  : Entity, PersistableEntity
    {
        public ProductCategory Category { get; set; }
        public ProductType Type { get; set; }    
        public string Name { get; set; }
        public IDictionary<ProductCodeTypes, string> Codes { get; set; }
        public virtual ICollection<ProductFeatureValue> Definition { get; set; }
        public async Task<bool> Save(IStore store)
        {
            throw new NotImplementedException();
        }
    }
}
