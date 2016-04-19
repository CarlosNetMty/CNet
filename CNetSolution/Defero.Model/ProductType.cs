using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Delta.Core;
using System.Threading.Tasks;

namespace Delta.Model
{
    public class ProductType : Entity, PersistableEntity
    {
        public string Name { get; set; }
        public virtual ICollection<ProductFeature> Features { get; set; }
        public virtual ICollection<ProductCategory> Categories { get; set; }
        public async Task<bool> Save(IStore store)
        {
            throw new NotImplementedException();
        }
    }
}
