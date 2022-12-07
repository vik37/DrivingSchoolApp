using AutoMapper;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Services
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
