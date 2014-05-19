using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defero.Core
{
    public static class Utils
    {
        public static bool IsInstanceAndHasValue(this object instance)
        {
            return instance != null;
        }
    }

    public interface IGuidDefiniedObject 
    {
        Guid Guid { get; }
    }

    public class GuidDefiniedObjectComparer : EqualityComparer<IGuidDefiniedObject>
    {
        public override bool Equals(IGuidDefiniedObject x, IGuidDefiniedObject y)
        {
            return x.Guid.Equals(y);
        }
    }
}
