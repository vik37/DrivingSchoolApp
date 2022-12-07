using AutoMapper;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Dtos.Models;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Helper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CategoryC, CategoryCDto>()
				.ForMember(dest => dest.Trucks,src => src.MapFrom(x => x.TruckPerCities.Select(y => y.Truck).ToList()))
				.ForMember(dest => dest.Lessons,src => src.MapFrom(x => x.Lessons.Select(y => y.Lessons).ToList()))
				.ReverseMap()
				.ForMember(dest => dest.TruckPerCities,src => src.Ignore())
				.ForMember(dest => dest.Lessons, src => src.Ignore());

			CreateMap<InstructorCategoryLicence, InstructorCategoryLicenceDto>()
				.ReverseMap()
				.ForMember(dest => dest.ÌnstructorId, src => src.Ignore())
				.ForMember(dest => dest.Instructor, src => src.Ignore());

			CreateMap<Instructor, InstructorDto>()
				.ForMember(dest => dest.Fullname, src => src.MapFrom(x => $"{x.Firstname} {x.Lastname}"))
				.ReverseMap()
				.ForMember(dest => dest.Firstname, src => src.MapFrom(x => x.Fullname.Split(" ", StringSplitOptions.None).First()))
				.ForMember(dest => dest.Lastname, src => src.MapFrom(x => x.Fullname.Split(" ", StringSplitOptions.None).Last()))
				.ForMember(dest => dest.CategoryC, src => src.Ignore());

			CreateMap<Lesson, LessonDto>()
				.ReverseMap()
				.ForMember(dest => dest.CategoryLessons,src => src.Ignore());

			CreateMap<Truck, TruckDto>()
				.ReverseMap()
				.ForMember(dest => dest.TruckPerCities,src => src.Ignore());

			CreateMap<WorkExperience, WorkExperienceDto>()
				.ReverseMap()
				.ForMember(dest => dest.Instructor, src => src.Ignore())
				.ForMember(dest => dest.InstructorId,src => src.Ignore());
		}
	}
}
