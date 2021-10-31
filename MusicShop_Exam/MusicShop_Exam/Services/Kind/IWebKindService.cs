using MusicShop_Exam.Models.Kind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.Kind
{
    public interface  IWebKindService
    {
        List<KindViewModel> GetAll();
        KindViewModel GetById(int id);
        void Update(KindViewModel kind);
        void Create(KindViewModel kind);
        void RemoveById(int id);
    }
}
