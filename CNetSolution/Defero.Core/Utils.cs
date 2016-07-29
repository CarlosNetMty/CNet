using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Core
{
    public static class Utils
    {
        public static bool IsInstanceAndHasValue(this Entity instance)
        {
            return instance != null && !string.IsNullOrEmpty(instance.Id.ToString());
        }
        public static bool IsInstanceAndHasValue(this IUniqueDefinedObject instance)
        {
            return instance != null && instance.Guid != null && !string.IsNullOrEmpty(instance.Guid.ToString());
        }
    }

    public class GuidDefiniedObjectComparer : EqualityComparer<IUniqueDefinedObject>
    {
        public override bool Equals(IUniqueDefinedObject x, IUniqueDefinedObject y)
        {
            return x.Guid.Equals(y);
        }

        public override int GetHashCode(IUniqueDefinedObject obj)
        {
            return base.GetHashCode();
        }
    }
}
