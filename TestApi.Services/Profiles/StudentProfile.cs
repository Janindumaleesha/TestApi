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
    public class StudentProfile : Profile
    {
        public StudentProfile() 
        {
            CreateMap<Student, StudentViewModel>();
        }
    }
}
