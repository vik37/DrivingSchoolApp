using DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Entities;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.DataAccess.Repository.Interfaces
{
	public interface IInstructorRepository : IRepository<Instructor>
	{
		Task<Instructor> GetById(int id, int instructorId);
	}
}
