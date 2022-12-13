namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Repository.Interface
{
	public interface IRepository<T> where T : class
	{
		Task<IEnumerable<T>> GetAll();
		Task<T> GetById(int id);
		Task<int> Add(T entity);
		Task<int> Update(T entity);
		Task<int> Delete(int id);
	}
}
