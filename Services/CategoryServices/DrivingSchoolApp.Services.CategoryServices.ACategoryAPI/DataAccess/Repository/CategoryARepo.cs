using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Repository
{
	public class CategoryARepo : BaseRepo, IRepository<CategoryA>
	{
		public CategoryARepo(CategoryADbContext db): base(db)
		{ }
		public async Task<IEnumerable<CategoryA>> GetAll()
		{
			try
			{
				return await _db.CategoryA.ToListAsync();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException.Message);
			}
		}

		public async Task<CategoryA> GetById(int id)
		{
			try
			{
				return await _db.CategoryA.Include(x => x.Instructors)
								.Include(x => x.CategoryLessons)
									.ThenInclude(x => x.Lessons)
								.Include(x => x.MotorcyclePerCity)
									.ThenInclude(x => x.Motorcycle)
								.FirstOrDefaultAsync(x => x.Id == id);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException.Message);
			}
		}
		public async Task<int> Add(CategoryA entity)
		{
			try
			{
				if (entity != null)
					_db.CategoryA.Add(entity);
				return await _db.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException.Message);
			}
		}
		public async Task<int> Update(CategoryA entity)
		{
			try
			{
				if(entity != null)
					_db.CategoryA.Update(entity);
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
				var caegory = _db.CategoryA.FirstOrDefault(x => x.Id == id);
				if(caegory == null) return -1;
					
				_db.CategoryA.Remove(caegory);
				return await _db.SaveChangesAsync();

			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException.Message);
			}
		}		
	}
}
