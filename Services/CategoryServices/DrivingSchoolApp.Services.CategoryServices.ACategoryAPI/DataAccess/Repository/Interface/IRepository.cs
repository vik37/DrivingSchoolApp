namespace DrivingSchoolApp.Services.CategoryServices.ACategoryAPI.DataAccess.Repository.Interface
{
	public interface IRepository<T>
	{
		IEnumerable<T> GetAll();
		T GetById(int id);
		int Add(T entity);
		int Update(T entity);
		int Delete(int id);
	}
}
