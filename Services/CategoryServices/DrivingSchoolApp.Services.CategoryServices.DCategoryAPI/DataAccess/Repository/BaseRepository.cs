namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Repository;

public class BaseRepository
{
	protected readonly CategoryDDbContext _db;
	public BaseRepository(CategoryDDbContext db)
	{
		_db = db;
	}
}
