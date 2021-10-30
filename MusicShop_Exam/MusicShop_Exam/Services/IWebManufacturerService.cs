using MusicShop_Exam.Models.Manufacturer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services
{
    public interface IWebManufacturerService
    {
        List<ManufacturerViewModel> GetAll();
        ManufacturerViewModel GetById(int id);
        void Update(ManufacturerViewModel manufacturer);
        void Create(ManufacturerViewModel manufacturer);
        void RemoveById(int id);
    }
}
