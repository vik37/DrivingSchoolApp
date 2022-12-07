using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Repository
{
	public class CategoryCRepository : BaseRepository, IRepository<CategoryC>
	{
		public CategoryCRepository(CategoryCDbContext db) : base(db)
		{}
		public async Task<IEnumerable<CategoryC>> GetAll()
		{
			return await _db.CategoryC.ToListAsync();
		}
		public async Task<CategoryC> GetById(int id)
		{
			return await _db.CategoryC.Include(x => x.Instructors)
									  .Include(x => x.TruckPerCities)
										.ThenInclude(x => x.Truck)
									  .Include(x => x.Lessons)
										.ThenInclude(x => x.Lessons)
									  .FirstOrDefaultAsync(x => x.Id == id);
		}
		public async Task<int> Add(CategoryC entity)
		{
			try
			{
				if (entity != null)
					_db.CategoryC.Add(entity);
				return await _db.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException.Message);
			}
		}
		public async Task<int> Update(CategoryC entity)
		{
			try
			{
				if (entity != null)
					_db.CategoryC.Update(entity);
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
				var caegory = _db.CategoryC.FirstOrDefault(x => x.Id == id);
				if (caegory == null) return -1;

				_db.CategoryC.Remove(caegory);
				return await _db.SaveChangesAsync();

			}
			catch (Exception ex)
			{
				throw new Exception(ex.InnerException.Message);
			}
		}		
	}
}
