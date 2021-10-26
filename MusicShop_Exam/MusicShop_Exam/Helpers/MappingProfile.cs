using AutoMapper;
using Domain.Entity;
using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Helpers
{
    internal sealed class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Account, AccountDTO>().ReverseMap();
        
        }
    }
}
