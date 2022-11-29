namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Repository
{
	public class BaseRepo
	{
		protected readonly CategoryADbContext _db;
		public BaseRepo(CategoryADbContext db)
		{
			_db = db;
		}
	}
}
