﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Core
{
    public abstract class Entity
    {
        [Key] public Int64 Id { get; set; }
    }
}
