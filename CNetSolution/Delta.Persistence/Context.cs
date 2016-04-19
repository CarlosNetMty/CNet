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
    public partial class Context : DbContext
    {
        public Context() : base(Constants.Database.Name) { }
    }
}
