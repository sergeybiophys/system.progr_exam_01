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
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Colour, ColourDTO>().ReverseMap();
            CreateMap<Guitar, GuitarDTO>().ReverseMap();
            CreateMap<GuitarType, GuitarTypeDTO>().ReverseMap();
            CreateMap<Kind, KindDTO>().ReverseMap();
            CreateMap<Manufacturer, ManufacturerDTO>().ReverseMap();
            CreateMap<NumberOfFrets, NumberOfFretsDTO>().ReverseMap();
            CreateMap<NumberOfString, NumberOfStringDTO>().ReverseMap();
            CreateMap<Pickup, PickupDTO>().ReverseMap();
            CreateMap<Size, SizeDTO>().ReverseMap();
            CreateMap<Status, StatusDTO>().ReverseMap();
        
        }
    }
}
