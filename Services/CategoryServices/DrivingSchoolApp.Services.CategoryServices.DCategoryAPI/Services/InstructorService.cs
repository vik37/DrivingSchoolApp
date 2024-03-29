﻿using AutoMapper;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Repository.Interfaces;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Dtos.Models;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Services.Interfaces;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Services;

public class InstructorService : BaseService, IInstructorService
{
	private readonly IInstructorRepository _instructorRepository;
	public InstructorService(IMapper mapper, IInstructorRepository instructorRepository)
		: base(mapper)
	{
		_instructorRepository = instructorRepository;
	}

	public async Task<InstructorDto> GetInstructorById(int id, int instructorId)
	{
		try
		{
			var	instructor = await _instructorRepository.GetById(id, instructorId);
			if (instructor == null)
				throw new CategoryDException("Instructor does not exist");
			return _mapper.Map<InstructorDto>(instructor);
		}
		catch (CategoryDException ex)
		{
			throw new CategoryDException(ex.Message);
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}
}