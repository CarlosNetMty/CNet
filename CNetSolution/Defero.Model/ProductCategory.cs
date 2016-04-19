using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Delta.Core;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delta.Model
{
    public class ProductCategory : Entity, PersistableEntity
    {
        public string Name { get; set; }
        public virtual ICollection<ProductType> Types { get; set; }
        [NotMapped] public virtual ICollection<ProductFeature> Features 
        {
            get 
            {
                return Types
                    .SelectMany(item => item.Features)
                    .Distinct() as ICollection<ProductFeature>;
            }
        }
        public async Task<bool> Save(IStore store)
        {
            throw new NotImplementedException();
        }
    }
}
