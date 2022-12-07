using DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Dtos.Enums;

namespace DrivingSchoolApp.Services.CategoryServices.CCategoryAPI.Dtos.Models
{
    public class WorkExperienceDto : BaseDto
    {
        public int Experience { get; set; }
        public string Company { get; set; }
        public TypeOfWorkExperience TypeOfWorkExperience { get; set; }
    }
}
