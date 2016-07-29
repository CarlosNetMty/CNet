using Delta.Core;
using Delta.Model;
using Delta.Model.Products;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Delta.WebAPI.Controllers.Products
{
    public class ProductFeaturesController : DeltaApiController<ProductFeature>
    {
        public ProductFeaturesController(IRepository<ProductFeature> repository) : base(repository)
        { }
        // GET: api/ProductFeatures
        public IQueryable<ProductFeature> GetProductFeatures()
        {
            return All();
        }
        // GET: api/ProductFeatures/5
        [ResponseType(typeof(ProductFeature))]
        public async Task<IHttpActionResult> GetProductFeature(long id)
        {
            return await Get(id);
        }
        // PUT: api/ProductFeatures/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProductFeature(long id, ProductFeature productFeature)
        {
            return await Put(id, productFeature);
        }
        // POST: api/ProductFeatures
        [ResponseType(typeof(ProductFeature))]
        public async Task<IHttpActionResult> PostProductFeature(ProductFeature productFeature)
        {
            return await Post(productFeature);
        }
        // DELETE: api/ProductFeatures/5
        [ResponseType(typeof(ProductFeature))]
        public async Task<IHttpActionResult> DeleteProductFeature(long id)
        {
            return await Delete(id);
        }
    }
}