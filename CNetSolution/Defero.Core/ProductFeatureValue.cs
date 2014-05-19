using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Defero.Core
{
    public class ProductFeatureValue
    {
        public string Value { get; set; }
        public bool HasValue 
        {
            get { !return string.IsNullOrEmpty(Value); } 
        }
    }
}
