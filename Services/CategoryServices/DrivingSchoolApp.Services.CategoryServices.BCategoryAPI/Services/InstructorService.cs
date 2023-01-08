﻿using AutoMapper;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Repository.Interface;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Dto.Models;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Helper.CustomExceptions;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Services.Interfaces;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Services
{
	public class InstructorService : BaseService, IInstructorService
	{
		private readonly IRepository<Instructor> _instructorRepository;
		public InstructorService(IMapper mapper, IRepository<Instructor> instructorRepository)
			: base(mapper)
		{
			_instructorRepository = instructorRepository;
		}

		public async Task<InstructorDto> GetInstructorById(int id)
		{
			try
			{
				var instructor = await _instructorRepository.GetById(id);
				if (instructor == null)
					throw new CategoryBExceptions("Instructor thoes not exist");
				return _mapper.Map<InstructorDto>(instructor);
			}
			catch (CategoryBExceptions ex)
			{
				throw new CategoryBExceptions(ex.Message);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
