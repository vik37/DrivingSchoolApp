﻿using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Repository
{
	public class InstructorRepository : BaseRepository, IRepository<Instructor>
	{
		public InstructorRepository(CategoryBDbContext db): base(db) {}

		public async Task<IEnumerable<Instructor>> GetAll()
		{
			return await _db.Instructor.ToListAsync();
		}

		public async Task<Instructor> GetById(int id)
		{
			return await _db.Instructor
							.Include(x => x.WorkExperiencePerCompany)
							.SingleOrDefaultAsync(x => x.Id == id);
										
		}

		public async Task<int> Add(Instructor entity)
		{
			try
			{
				if (entity != null)
					_db.Instructor.Add(entity);
				return await _db.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException.Message);
			}
		}

		public async Task<int> Update(Instructor entity)
		{
			try
			{
				if (entity != null)
					_db.Instructor.Update(entity);
				return await _db.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException.Message);
			}
		}
		public async Task<int> Delete(int id)
		{
			try
			{
				var caegory = _db.Instructor.FirstOrDefault(x => x.Id == id);
				if (caegory == null) return -1;

				_db.Instructor.Remove(caegory);
				return await _db.SaveChangesAsync();

			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException.Message);
			}
		}
	}
}