using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Pickup:BaseEntity<int>
    {
        public string Type { get; set; }
    }
}
