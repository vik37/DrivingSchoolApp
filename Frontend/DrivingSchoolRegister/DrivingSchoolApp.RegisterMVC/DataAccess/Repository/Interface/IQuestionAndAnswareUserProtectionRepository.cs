using DrivingSchoolApp.RegisterMVC.DataAccess.Entities;
using DrivingSchoolApp.RegisterMVC.DataAccess.Entities.Enums;

namespace DrivingSchoolApp.RegisterMVC.DataAccess.Repository.Interface
{
    public interface IQuestionAndAnswareUserProtectionRepository
    {
        Task<QuestionAnswareUserProtection> GetQuestionAndAnswareById(string id);
        Task<QuestionAnswareUserProtection> FindQuestionAndAnsware(Question question,string answare);
        Task Add(QuestionAnswareUserProtection questionAnswareUserProtection);
    }
}
