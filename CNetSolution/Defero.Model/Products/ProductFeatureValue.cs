using Delta.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Delta.Model
{
    public class ProductFeatureValue : Entity
    {
        [Required] public ProductFeature Feature { get; set; }
        [Required, MaxLength(100)] public string Value { get; set; }
    }
}
