using DrivingSchoolApp.RegisterMVC.DataAccess.Entities;
using DrivingSchoolApp.RegisterMVC.DataAccess.Entities.Enums;

namespace DrivingSchoolApp.RegisterMVC.DataAccess.Repository.Interface
{
    public interface IQuestionAndAnswerUserProtectionRepository
    {
        Task<QuestionAnswerUserProtection> GetQuestionAndAnswerById(string id);
        Task<QuestionAnswerUserProtection> FindQuestionAndAnswer(Question question,string answer);
        Task Add(QuestionAnswerUserProtection questionAnswerUserProtection);
    }
}
