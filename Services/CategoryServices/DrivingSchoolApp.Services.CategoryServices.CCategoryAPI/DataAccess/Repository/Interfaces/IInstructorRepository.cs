using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Entities;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.DataAccess.Repository.Interfaces
{
	public interface IInstructorRepository : IRepository<Instructor>
	{
		Task<Instructor> GetById(int id, int instructorId);
	}
}
