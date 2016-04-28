using Delta.Core;
using Delta.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Persistence
{
    public abstract class Repository<T> : IDisposable where T : Entity
    {
        protected readonly Context dbContext;
        public Repository(Context dbContext)
        {
            this.dbContext = dbContext;
        }
        public IQueryable<T> Contents
        {
            get { return this.Store; }
        }
        public abstract DbSet<T> Store { get; }
        public void Add(T entry)
        {
            this.Store.Add(entry);
        }
        public void Delete(T entry)
        {
            this.Store.Remove(entry);
        }
        public void Update(T entry)
        {
            dbContext.Update(entry);
        }
        public bool Exists(long id)
        {
            return this.Store.Exists(id);
        }
        public T Find(long id)
        {
            return this.Store.Find(id);
        }
        public Task<T> FindAsync(long id)
        {
            return this.Store.FindAsync(id);
        }
        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }
        public Task<int> SaveChangesAsync()
        {
            return dbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
