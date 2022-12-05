using AutoMapper;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Dto.Models;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Helper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CategoryB, CategoryBDto>()
				.ForMember(x => x.Lessons, src => src.MapFrom(x => x.CategoryLessons.Select(y => y.Lessons).ToList()))
				.ForMember(x => x.Cars, src => src.MapFrom(x => x.CarPerCity.Select(y => y.Car).ToList()))
				.ReverseMap()
				.ForMember(dest => dest.CarPerCity, src => src.Ignore())
				.ForMember(dest => dest.CategoryLessons, src => src.Ignore());

			CreateMap<Car, CarDto>()
				.ReverseMap()
				.ForMember(dest => dest.CarsPerCity,src => src.Ignore());

			CreateMap<Instructor, InstructorDto>()
				.ForMember(dest => dest.Fullname, src => src.MapFrom(x => $"{x.Firstname} {x.Lastname}"))
				.ReverseMap()
				.ForMember(dest => dest.Firstname, src => src.MapFrom(x => x.Fullname.Split(" ", StringSplitOptions.None).First()))
				.ForMember(dest => dest.Lastname, src => src.MapFrom(x => x.Fullname.Split(" ", StringSplitOptions.None).Last()))
				.ForMember(dest => dest.WorkExperiencesPerCompany,src => src.Ignore())
				.ForMember(dest => dest.CategoryB, src => src.Ignore());

			CreateMap<Lesson, LessonDto>()
				.ReverseMap()
				.ForMember(dest => dest.CategoryLessons, src => src.Ignore());

			CreateMap<WorkExperience, WorkExperienceDto>()
				.ReverseMap()
				.ForMember(dest => dest.Instructor, src => src.Ignore());
		}
	}
}
