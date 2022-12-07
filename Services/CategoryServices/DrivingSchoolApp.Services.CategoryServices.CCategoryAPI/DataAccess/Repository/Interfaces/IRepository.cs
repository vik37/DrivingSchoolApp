namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Repository.Interfaces
{
	public interface IRepository<T>
	{
		Task<IEnumerable<T>> GetAll();
		Task<T> GetById(int id);
		Task<int> Add(T entity);
		Task<int> Update(T entity);
		Task<int> Delete(int id);
	}
}
