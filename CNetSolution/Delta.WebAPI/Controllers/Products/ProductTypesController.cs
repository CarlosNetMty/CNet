using Delta.Core;
using Delta.Model;
using Delta.Model.Products;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Delta.WebAPI.Controllers.Products
{
    public class ProductTypesController : DeltaApiController<ProductType>
    {
        public ProductTypesController(IRepository<ProductType> repository) : base(repository)
        { }
        // GET: api/ProductTypes
        public IQueryable<ProductType> GetProductTypes()
        {
            return All();
        }
        // GET: api/ProductTypes/5
        [ResponseType(typeof(ProductType))]
        public async Task<IHttpActionResult> GetProductType(long id)
        {
            return await Get(id);
        }
        // PUT: api/ProductTypes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProductType(long id, ProductType productType)
        {
            return await Put(id, productType);
        }
        // POST: api/ProductTypes
        [ResponseType(typeof(ProductType))]
        public async Task<IHttpActionResult> PostProductType(ProductType productType)
        {
            return await Post(productType);
        }
        // DELETE: api/ProductTypes/5
        [ResponseType(typeof(ProductType))]
        public async Task<IHttpActionResult> DeleteProducType(long id)
        {
            return await Delete(id);
        }
    }
}