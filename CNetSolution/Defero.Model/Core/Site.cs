using Delta.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Model.Core
{
    public class Site : Entity
    {
        [Required, MaxLength(100)] public string Name { get; set; }
        [Required, MaxLength(5)] public string Code { get; set; }
    }
}
