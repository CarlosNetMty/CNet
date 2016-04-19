using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Core
{
    public static class Utils
    {
        public static bool IsInstanceAndHasValue(this IGuidDefiniedObject instance)
        {
            return instance != null && instance.Guid != null && !string.IsNullOrEmpty(instance.Guid.ToString());
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

        public override int GetHashCode(IGuidDefiniedObject obj)
        {
            return base.GetHashCode();
        }
    }
}
