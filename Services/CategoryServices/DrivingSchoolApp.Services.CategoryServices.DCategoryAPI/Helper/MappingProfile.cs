using AutoMapper;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Dtos.Models;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Helper;

public class MappingProfile : Profile
{
	public MappingProfile()
	{
		CreateMap<CategoryD, CategoryDDto>()
			.ForMember(dest => dest.Lessons, src => src.MapFrom(x => x.Lessons.Select(y => y.Lesson).ToList()))
			.ReverseMap()
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
			.ForMember(dest => dest.CategoryD, src => src.Ignore());

		CreateMap<Lesson, LessonDto>()
			.ReverseMap()
			.ForMember(dest => dest.CategoryLessons, src => src.Ignore());

		CreateMap<WorkExperience, WorkExperienceDto>()
			.ReverseMap()
			.ForMember(dest => dest.Instructor, src => src.Ignore())
			.ForMember(dest => dest.InstructorId, src => src.Ignore());
	}
}