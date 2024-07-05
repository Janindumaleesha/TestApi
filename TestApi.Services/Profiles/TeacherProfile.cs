using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Services.ViewModels;

namespace TestApi.Services.Profiles
{
    public class TeacherProfile : Profile
    {
        public TeacherProfile()
        {
            CreateMap<Teacher, TeacherViewModel>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => $"{src.AddressNo}, {src.Street}, {src.City}"));
        }
    }
}
