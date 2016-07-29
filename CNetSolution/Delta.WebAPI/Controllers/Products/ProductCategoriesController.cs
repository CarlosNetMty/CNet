using Delta.Core;
using Delta.Model;
using Delta.Model.Products;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Delta.WebAPI.Controllers.Products
{
    public class ProductCategoriesController : DeltaApiController<ProductCategory>
    {
        public ProductCategoriesController(IRepository<ProductCategory> repository) : base(repository)
        { }
        // GET: api/ProductCategories
        public IQueryable<ProductCategory> GetProductCategories()
        {
            return All();
        }
        // GET: api/ProductCategories/5
        [ResponseType(typeof(ProductCategory))]
        public async Task<IHttpActionResult> GetProductCategory(long id)
        {
            return await Get(id);
        }
        // PUT: api/ProductCategories/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProductCategory(long id, ProductCategory productCategory)
        {
            return await Put(id, productCategory);
        }
        // POST: api/ProductCategories
        [ResponseType(typeof(ProductCategory))]
        public async Task<IHttpActionResult> PostProductCategory(ProductCategory productCategory)
        {
            return await Post(productCategory);
        }
        // DELETE: api/ProductCategories/5
        [ResponseType(typeof(ProductCategory))]
        public async Task<IHttpActionResult> DeleteProductCategory(long id)
        {
            return await Delete(id);
        }
    }
}