using System;
using System.Linq;
using System.Threading.Tasks;

namespace Delta.Core
{
    public interface IReadOnlyRepository<T> : IDisposable where T : Entity
    {
        IQueryable<T> Contents { get; }
        Task<T> FindAsync(long id);
        bool Exists(long id);
        T Find(long id);
    }
    public interface IRepository<T> : IReadOnlyRepository<T> where T : Entity
    {      
        void Add(T entry);
        void Update(T entry);
        void Delete(T entry);
        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}
