using MusicShop_Exam.Models.Colour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.Colour
{
    public interface IWebColourService
    {
        List<ColourViewModel> GetAll();
        ColourViewModel GetById(int id);
        void Update(ColourViewModel colour);
        void Create(ColourViewModel colour);
        void RemoveById(int id);
    }
}
