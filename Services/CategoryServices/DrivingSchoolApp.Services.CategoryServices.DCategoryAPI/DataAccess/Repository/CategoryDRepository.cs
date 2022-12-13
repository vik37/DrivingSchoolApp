using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;
using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Repository;

public class CategoryDRepository : BaseRepository, IRepository<CategoryD>
{
	public CategoryDRepository(CategoryDDbContext db)
		: base(db)
	{}
	public async Task<IEnumerable<CategoryD>> GetAll()
	{
		try
		{
			return await _db.CategoryD.ToListAsync();
		}
		catch (Exception ex)
		{
			throw new Exception(ex.InnerException.Message);
		}
	}
	public async Task<CategoryD> GetById(int id)
	{
		try
		{
			return await _db.CategoryD.Include(x => x.Instructors)
										.Include(x => x.Lessons)
											.ThenInclude(x => x.Lesson)
										.FirstOrDefaultAsync(x => x.Id == id);
		}
		catch (Exception ex)
		{
			throw new Exception(ex.InnerException.Message);
		}
	}
	public async Task<int> Add(CategoryD entity)
	{
		try
		{
			if (entity != null)
				_db.CategoryD.Add(entity);
			return await _db.SaveChangesAsync();
		}
		catch (Exception ex)
		{
			throw new Exception(ex.InnerException.Message);
		}
	}
	public async Task<int> Update(CategoryD entity)
	{
		try
		{
			if (entity != null)
				_db.CategoryD.Update(entity);
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
			var caegory = _db.CategoryD.FirstOrDefault(x => x.Id == id);
			if (caegory == null) return -1;

			_db.CategoryD.Remove(caegory);
			return await _db.SaveChangesAsync();

		}
		catch (Exception ex)
		{
			throw new Exception(ex.InnerException.Message);
		}
	}
}

