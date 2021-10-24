﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Category:BaseEntity<int>
    {
        public string Name { get; set; }
        List<Guitar> guitars { get; set; }
    }
}
