namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccerrss.Repository
{
	public class BaseRepository
	{
		protected readonly CategoryBDbContext _db;
		public BaseRepository(CategoryBDbContext db)
		{
			_db = db;
		}
	}
}
