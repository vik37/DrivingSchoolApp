using DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Entities;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.DataAccess.Repository.Interface
{
	public interface IInstructorRepository : IRepository<Instructor>
	{
		Task<Instructor> GetById(int id, int instructorId);
	}
}
