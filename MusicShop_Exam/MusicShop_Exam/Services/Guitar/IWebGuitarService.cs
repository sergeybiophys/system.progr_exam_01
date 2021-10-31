using MusicShop_Exam.Models.Guitar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.Guitar
{
    public interface IWebGuitarService
    {
        List<GuitarViewModel> GetAll();
        GuitarViewModel GetById(int id);
        void Update(GuitarViewModel guitar);
        void Create(GuitarViewModel guitar);
        void RemoveById(int id);
    }
}
