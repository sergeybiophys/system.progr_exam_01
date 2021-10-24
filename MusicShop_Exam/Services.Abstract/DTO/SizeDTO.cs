using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract.DTO
{
    public class SizeDTO
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string InstrumentSize { get; set; }
    }
}
