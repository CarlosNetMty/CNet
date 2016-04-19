using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Core
{
    public interface IStore
    {
        void Add(Entity entity);
        void Remove(Entity entity);
        void Save();
    }
}
