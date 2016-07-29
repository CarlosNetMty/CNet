using Delta.Core;
using Delta.Model;
using Delta.Model.Products;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Delta.WebAPI.Controllers.Products
{
    public class ProductFeatureValuesController : DeltaApiController<ProductFeatureValue>
    {
        public ProductFeatureValuesController(IRepository<ProductFeatureValue> repository) : base(repository)
        { }
        // GET: api/ProductFeatureValues
        public IQueryable<ProductFeatureValue> GetProductFeatureValues()
        {
            return All();
        }
        // GET: api/ProductFeatureValues/5
        [ResponseType(typeof(ProductFeatureValue))]
        public async Task<IHttpActionResult> GetProductFeatureValue(long id)
        {
            return await Get(id);
        }
        // PUT: api/ProductFeatureValues/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProductFeatureValue(long id, ProductFeatureValue productFeatureValue)
        {
            return await Put(id, productFeatureValue);
        }
        // POST: api/ProductFeatureValues
        [ResponseType(typeof(ProductFeatureValue))]
        public async Task<IHttpActionResult> PostProductFeatureValue(ProductFeatureValue productFeatureValue)
        {
            return await Post(productFeatureValue);
        }
        // DELETE: api/ProductFeatureValues/5
        [ResponseType(typeof(ProductFeatureValue))]
        public async Task<IHttpActionResult> DeleteProductFeatureValue(long id)
        {
            return await Delete(id);
        }
    }
}