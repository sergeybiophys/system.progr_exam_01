using MusicShop_Exam.Models.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.Type
{
    public interface IWebGuitarTypeService
    {
        List<GuitarTypeViewModel> GetAll();
        GuitarTypeViewModel GetById(int id);
        void Update(GuitarTypeViewModel type);
        void Create(GuitarTypeViewModel type);
        void RemoveById(int id);
    }
}
