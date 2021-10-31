using MusicShop_Exam.Models.Size;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.Size
{
    public interface IWebSizeService
    {
        List<SizeViewModel> GetAll();
        SizeViewModel GetById(int id);
        void Update(SizeViewModel size);
        void Create(SizeViewModel size);
        void RemoveById(int id);
    }
}
