using MusicShop_Exam.Models.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.String
{
    public interface IWebStringService
    {
        List<StringViewModel> GetAll();
        StringViewModel GetById(int id);
        void Update(StringViewModel @string);
        void Create(StringViewModel @string);
        void RemoveById(int id);
    }
}
