using MusicShop_Exam.Models.Fret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.Fret
{
    public interface IWebFretService
    {
        List<FretsViewModel> GetAll();
        FretsViewModel GetById(int id);
        void Update(FretsViewModel fret);
        void Create(FretsViewModel fret);
        void RemoveById(int id);
    }
}
