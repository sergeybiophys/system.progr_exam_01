﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class NumberOfFrets : BaseEntity<int> 
    {
        public int Number { get; set; }
    }
}
