using AutoMapper;

namespace DrivingSchoolApp.Services.CategoryServices.BCategoryAPI.Services
{
	public class BaseService
	{
		protected readonly IMapper _mapper;
		public BaseService(IMapper mapper)
		{
			_mapper = mapper;
		}
	}
}
