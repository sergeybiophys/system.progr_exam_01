using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Guitar: BaseEntity<int>
    {
        public string Name { get; set; }   
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int ColourId { get; set; }
        public int GuitarTypeId { get; set; }
        public int KindId { get; set; }
        public int NumberOfFretsId { get; set; }
        public int NumberOfStringId { get; set; }
        public int PickupId { get; set; }
        public int SizeId { get; set; }
        public int Status { get; set; }  
    }
}
