using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Core
{
    public interface IUniqueDefinedObject
    {
        Guid Guid { get; }
    }
}
