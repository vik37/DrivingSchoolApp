namespace DrivingSchoolApp.RegisterMVC.DataAccess.Repository
{
	public class BaseRepository
	{
		protected readonly DrivingSchoolRegisterDbContext _db;
		public BaseRepository(DrivingSchoolRegisterDbContext db)
		{
			_db= db;
		}
	}
}
