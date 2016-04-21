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
    public class ProductFeatureValuesController : ApiController
    {
        private Context db = new Context();

        // GET: api/ProductFeatureValues
        public IQueryable<ProductFeatureValue> GetProductFeatureValues()
        {
            return db.ProductFeatureValues;
        }

        // GET: api/ProductFeatureValues/5
        [ResponseType(typeof(ProductFeatureValue))]
        public async Task<IHttpActionResult> GetProductFeatureValue(long id)
        {
            ProductFeatureValue productFeatureValue = await db.ProductFeatureValues.FindAsync(id);
            if (productFeatureValue == null)
            {
                return NotFound();
            }

            return Ok(productFeatureValue);
        }

        // PUT: api/ProductFeatureValues/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProductFeatureValue(long id, ProductFeatureValue productFeatureValue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productFeatureValue.Id)
            {
                return BadRequest();
            }

            db.Entry(productFeatureValue).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductFeatureValueExists(id))
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

        // POST: api/ProductFeatureValues
        [ResponseType(typeof(ProductFeatureValue))]
        public async Task<IHttpActionResult> PostProductFeatureValue(ProductFeatureValue productFeatureValue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProductFeatureValues.Add(productFeatureValue);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = productFeatureValue.Id }, productFeatureValue);
        }

        // DELETE: api/ProductFeatureValues/5
        [ResponseType(typeof(ProductFeatureValue))]
        public async Task<IHttpActionResult> DeleteProductFeatureValue(long id)
        {
            ProductFeatureValue productFeatureValue = await db.ProductFeatureValues.FindAsync(id);
            if (productFeatureValue == null)
            {
                return NotFound();
            }

            db.ProductFeatureValues.Remove(productFeatureValue);
            await db.SaveChangesAsync();

            return Ok(productFeatureValue);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductFeatureValueExists(long id)
        {
            return db.ProductFeatureValues.Count(e => e.Id == id) > 0;
        }
    }
}