using Delta.Core;
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

namespace Delta.WebAPI
{
    public abstract class DeltaApiController<T> : ApiController where T : Entity
    {
        readonly IRepository<T> db;
        public DeltaApiController(IRepository<T> repository)
        {
            this.db = repository;
        }
        protected IQueryable<T> All()
        {
            return db.Contents;
        }
        protected async Task<IHttpActionResult> Delete(long id)
        {
            T entity = await db.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            db.Delete(entity);
            await db.FindAsync(id);

            return Ok(entity);
        }
        protected async Task<IHttpActionResult> Get(long id)
        {
            T entity = await db.FindAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }
        protected async Task<IHttpActionResult> Post(T entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Add(entity);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = entity.Id }, entity);
        }
        protected async Task<IHttpActionResult> Put(long id, T entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != entity.Id)
            {
                return BadRequest();
            }

            db.Update(entity);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {               
                if (!db.Exists(id))
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}