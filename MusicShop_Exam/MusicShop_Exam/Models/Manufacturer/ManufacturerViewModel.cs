using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Models.Manufacturer
{
    public class ManufacturerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<GuitarDTO> Guitars { get; set; }
    }
}
