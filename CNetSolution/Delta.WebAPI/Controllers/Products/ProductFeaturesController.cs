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
    public class ProductFeaturesController : ApiController
    {
        private Context db = new Context();

        // GET: api/ProductFeatures
        public IQueryable<ProductFeature> GetProductFeatures()
        {
            return db.ProductFeatures;
        }

        // GET: api/ProductFeatures/5
        [ResponseType(typeof(ProductFeature))]
        public async Task<IHttpActionResult> GetProductFeature(long id)
        {
            ProductFeature productFeature = await db.ProductFeatures.FindAsync(id);
            if (productFeature == null)
            {
                return NotFound();
            }

            return Ok(productFeature);
        }

        // PUT: api/ProductFeatures/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProductFeature(long id, ProductFeature productFeature)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productFeature.Id)
            {
                return BadRequest();
            }

            db.Entry(productFeature).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductFeatureExists(id))
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

        // POST: api/ProductFeatures
        [ResponseType(typeof(ProductFeature))]
        public async Task<IHttpActionResult> PostProductFeature(ProductFeature productFeature)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProductFeatures.Add(productFeature);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = productFeature.Id }, productFeature);
        }

        // DELETE: api/ProductFeatures/5
        [ResponseType(typeof(ProductFeature))]
        public async Task<IHttpActionResult> DeleteProductFeature(long id)
        {
            ProductFeature productFeature = await db.ProductFeatures.FindAsync(id);
            if (productFeature == null)
            {
                return NotFound();
            }

            db.ProductFeatures.Remove(productFeature);
            await db.SaveChangesAsync();

            return Ok(productFeature);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductFeatureExists(long id)
        {
            return db.ProductFeatures.Count(e => e.Id == id) > 0;
        }
    }
}