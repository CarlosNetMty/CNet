using Delta.Core;
using Delta.Model;
using Delta.Model.Products;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Delta.WebAPI.Controllers.Products
{
    public class ProductsController : DeltaApiController<Product>
    {
        public ProductsController(IRepository<Product> repository) : base(repository)
        { }
        // GET: api/Products
        public IQueryable<Product> GetProducts()
        {
            return All();
        }
        // GET: api/Products/5
        [ResponseType(typeof(Product))]
        public async Task<IHttpActionResult> GetProduct(long id)
        {
            return await Get(id);
        }
        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProduct(long id, Product product)
        {
            return await Put(id, product);
        }
        // POST: api/Products
        [ResponseType(typeof(Product))]
        public async Task<IHttpActionResult> PostProduct(Product product)
        {
            return await Post(product);
        }
        // DELETE: api/Products/5
        [ResponseType(typeof(Product))]
        public async Task<IHttpActionResult> DeleteProduct(long id)
        {
            return await Delete(id);
        }
    }
}