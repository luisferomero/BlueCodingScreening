using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.API.DTO;
using WebApplication.Entities;

namespace WebApplication.API.Mappers
{
    public class MyProfile : Profile
    {
        public MyProfile()
        {
            CreateMap<Person, PersonDTO>().ReverseMap();
            CreateMap<Status, StatusDTO>().ReverseMap();
        }
    }
}
