using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Delta.Core;
using System.Threading.Tasks;

namespace Delta.Model
{
    public class ProductFeature : Entity, PersistableEntity
    {
        public string Name { get; set; }
        public virtual ICollection<ProductFeatureValue> AvailableValues { get; set; }
        public async Task<bool> Save(IStore store)
        {
            throw new NotImplementedException();
        }
    }
}
