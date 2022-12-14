using AutoMapper;

namespace DrivingSchoolApp.Services.CategoryServices.DCategoryAPI.Services;

public class BaseService
{
	protected readonly IMapper _mapper;
	public BaseService(IMapper mapper)
	{
		_mapper = mapper;
	}
}