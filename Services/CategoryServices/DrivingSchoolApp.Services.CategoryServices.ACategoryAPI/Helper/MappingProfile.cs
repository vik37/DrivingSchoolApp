using AutoMapper;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Dto.Models;
using Microsoft.AspNetCore.Routing.Constraints;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryA, CategoryADto>()
                .ForMember(x => x.Lessons, src => src.MapFrom(x => x.CategoryLessons.Select(y => y.Lessons).ToList()))
                .ForMember(x => x.Motorcycles, src => src.MapFrom(x => x.MotorcyclePerCity.Select(y => y.Motorcycle).ToList()))
                .ReverseMap()
                .ForMember(dest => dest.MotorcyclePerCity, src => src.Ignore())
                .ForMember(dest => dest.CategoryLessons, src => src.Ignore());

            CreateMap<Instructor, InstructorDto>()
                .ReverseMap();
            CreateMap<Lesson, LessonDto>()
                .ReverseMap()
                .ForMember(dest => dest.CategoryLessons, src => src.Ignore());
            CreateMap<Motorcycle, MotorcycleDto>()
                .ReverseMap()
                .ForMember(dest => dest.MotorsPerCity,src => src.Ignore());
        }
    }
}
