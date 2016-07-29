using Delta.Core;
using Delta.Model;
using Delta.Model.Products;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Delta.WebAPI.Controllers.Products
{
    public class ProductCodesController : DeltaApiController<ProductCode>
    {
        public ProductCodesController(IRepository<ProductCode> repository) : base(repository)
        { }
        // GET: api/ProductCodes
        public IQueryable<ProductCode> GetProductCodes()
        {
            return All();
        }
        // GET: api/ProductCodes/5
        [ResponseType(typeof(ProductCode))]
        public async Task<IHttpActionResult> GetProductCode(long id)
        {
            return await Get(id);
        }
        // PUT: api/ProductCodes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProductCode(long id, ProductCode productCode)
        {
            return await Put(id, productCode);
        }
        // POST: api/ProductCodes
        [ResponseType(typeof(ProductCode))]
        public async Task<IHttpActionResult> PostProductCode(ProductCode productCode)
        {
            return await Post(productCode);
        }
        // DELETE: api/ProductCodes/5
        [ResponseType(typeof(ProductCode))]
        public async Task<IHttpActionResult> DeleteProductCode(long id)
        {
            return await Delete(id);
        }
    }
}