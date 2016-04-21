using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Delta.Model;
using Delta.Persistence;

namespace Delta.WebAPI.Controllers.Products
{
    public class ProductCodesController : ApiController
    {
        private Context db = new Context();

        // GET: api/ProductCodes
        public IQueryable<ProductCode> GetProductCodes()
        {
            return db.ProductCodes;
        }

        // GET: api/ProductCodes/5
        [ResponseType(typeof(ProductCode))]
        public async Task<IHttpActionResult> GetProductCode(long id)
        {
            ProductCode productCode = await db.ProductCodes.FindAsync(id);
            if (productCode == null)
            {
                return NotFound();
            }

            return Ok(productCode);
        }

        // PUT: api/ProductCodes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProductCode(long id, ProductCode productCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productCode.Id)
            {
                return BadRequest();
            }

            db.Entry(productCode).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductCodeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ProductCodes
        [ResponseType(typeof(ProductCode))]
        public async Task<IHttpActionResult> PostProductCode(ProductCode productCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProductCodes.Add(productCode);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = productCode.Id }, productCode);
        }

        // DELETE: api/ProductCodes/5
        [ResponseType(typeof(ProductCode))]
        public async Task<IHttpActionResult> DeleteProductCode(long id)
        {
            ProductCode productCode = await db.ProductCodes.FindAsync(id);
            if (productCode == null)
            {
                return NotFound();
            }

            db.ProductCodes.Remove(productCode);
            await db.SaveChangesAsync();

            return Ok(productCode);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductCodeExists(long id)
        {
            return db.ProductCodes.Count(e => e.Id == id) > 0;
        }
    }
}