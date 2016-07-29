using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Service.Model
{
    public abstract class QueryResponse<T>
    {
        public bool IsSucceed { get; set; }
    }
}
