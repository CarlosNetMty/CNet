using Delta.Core;
using System.ComponentModel.DataAnnotations;

namespace Delta.Model.Security
{
    public class Role : Entity
    {
        [Required, MaxLength(50)] public string Name { get; set; }
    }
}
