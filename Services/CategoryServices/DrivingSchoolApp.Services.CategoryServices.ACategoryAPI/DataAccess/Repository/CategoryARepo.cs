using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Etities;
using DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Repository
{
	public class CategoryARepo : BaseRepo, IRepository<CategoryA>
	{
		public CategoryARepo(CategoryADbContext db): base(db)
		{ }
		public IEnumerable<CategoryA> GetAll()
		{
			return _db.CategoryA;
		}

		public CategoryA GetById(int id)
		{
			return _db.CategoryA.Include(x => x.Instructors)
								.Include(x => x.CategoryLessons)
									.ThenInclude(x => x.Lessons)
								.Include(x => x.MotorcyclePerCity)
									.ThenInclude(x => x.Motorcycle)
								.FirstOrDefault(x => x.Id == id);
		}
		public int Add(CategoryA entity)
		{
			throw new NotImplementedException();
		}
		public int Update(CategoryA entity)
		{
			throw new NotImplementedException();
		}
		public int Delete(int id)
		{
			throw new NotImplementedException();
		}		
	}
}
