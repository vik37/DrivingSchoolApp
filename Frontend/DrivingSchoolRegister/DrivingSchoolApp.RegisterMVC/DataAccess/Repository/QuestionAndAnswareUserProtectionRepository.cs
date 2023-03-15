using DrivingSchoolApp.RegisterMVC.DataAccess.Entities;
using DrivingSchoolApp.RegisterMVC.DataAccess.Entities.Enums;
using DrivingSchoolApp.RegisterMVC.DataAccess.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.RegisterMVC.DataAccess.Repository
{
    public class QuestionAndAnswareUserProtectionRepository : BaseRepository, IQuestionAndAnswerUserProtectionRepository
    {
        public QuestionAndAnswareUserProtectionRepository(DrivingSchoolRegisterDbContext dbContext)
        : base(dbContext) { }

        public async Task<QuestionAnswerUserProtection> GetQuestionAndAnswerById(string id)
        {
            return await _db.QuestionAnswerUserProtections.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<QuestionAnswerUserProtection> FindQuestionAndAnswer(Question question, string answer)
        {
            return await _db.QuestionAnswerUserProtections.Where(qa => qa.Question == question && qa.Answer == answer).FirstOrDefaultAsync();
        }
        public async Task Add(QuestionAnswerUserProtection questionAnswerUserProtection)
        {
            _db.Add(questionAnswerUserProtection);
            await _db.SaveChangesAsync();
        }
    }
}
