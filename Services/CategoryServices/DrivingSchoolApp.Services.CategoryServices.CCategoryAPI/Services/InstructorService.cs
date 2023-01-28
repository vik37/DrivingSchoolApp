using AutoMapper;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Repository.Interfaces;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Dtos.Models;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Services;

public class InstructorService : BaseService, IInstructorService
{
	private readonly IInstructorRepository _instructorRepository;
	public InstructorService(IMapper mapper,IInstructorRepository instructorRepository)
		:base(mapper)
	{
		_instructorRepository = instructorRepository;
	}

	public async Task<InstructorDto> GetInstructorById(int id, int instructorId)
	{
		try
		{
			var instructor = await _instructorRepository.GetById(id, instructorId);
			if (instructor == null)
				throw new CategoryCException("Instructor does not exist");
			return _mapper.Map<InstructorDto>(instructor);
		}
		catch(CategoryCException ex)
		{
			throw new CategoryCException(ex.Message);
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}
}