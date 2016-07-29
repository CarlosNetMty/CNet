using Delta.Core;
using System.Data.Entity;

namespace Delta.Persistence
{
    public partial class Context : DbContext
    {
        public Context() : base(Constants.Database.Name)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);    
        }
        public void Update<T>(T entry) where T : Entity
        {
            Entry<T>(entry).State = EntityState.Modified;
        }
    }
}
