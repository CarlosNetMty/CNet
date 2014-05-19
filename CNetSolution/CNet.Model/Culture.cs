using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNet.Model
{
    [Flags]
    public enum AvailableCultures 
    { 
        English = 0x01,
        Spanish = 0x02
    }

    public class Translation
    {
        public AvailableCultures Culture { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
