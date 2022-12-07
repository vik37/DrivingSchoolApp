namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Repository
{
	public class BaseRepository
	{
		protected readonly CategoryCDbContext _db;
		public BaseRepository(CategoryCDbContext db)
		{
			_db = db;
		}
	}
}
