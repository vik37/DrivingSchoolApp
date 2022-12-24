using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Repository
{
	public class CategoryBRepository : BaseRepository, IRepository<CategoryB>
	{
		public CategoryBRepository(CategoryBDbContext db): base(db) { }
		
		public async Task<IEnumerable<CategoryB>> GetAll()
		{
			return await _db.CategoryB.ToListAsync();
		}

		public async Task<CategoryB> GetById(int id)
		{
			try
			{
				return await _db.CategoryB
								.Include(x => x.Instructors)
									.ThenInclude(x => x.WorkExperiencePerCompany)
								.Include(x => x.CarPerCity)
									.ThenInclude(x => x.Car)
								.Include(x => x.CategoryLessons)
									.ThenInclude(x => x.Lessons)
								.Where(x => x.Id == id)
								.FirstOrDefaultAsync();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException.Message);
			}
		}

		public async Task<int> Add(CategoryB entity)
		{
			try
			{
				if (entity != null)
					_db.CategoryB.Add(entity);
				return await _db.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException.Message);
			}
		}
		public async Task<int> Update(CategoryB entity)
		{
			try
			{
				if (entity != null)
					_db.CategoryB.Update(entity);
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
				var caegory = _db.CategoryB.FirstOrDefault(x => x.Id == id);
				if (caegory == null) return -1;

				_db.CategoryB.Remove(caegory);
				return await _db.SaveChangesAsync();

			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException.Message);
			}
		}		
	}
}
