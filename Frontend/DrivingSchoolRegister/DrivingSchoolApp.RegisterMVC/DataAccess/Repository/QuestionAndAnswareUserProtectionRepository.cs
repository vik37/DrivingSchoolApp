using DrivingSchoolApp.RegisterMVC.DataAccess.Entities;
using DrivingSchoolApp.RegisterMVC.DataAccess.Entities.Enums;
using DrivingSchoolApp.RegisterMVC.DataAccess.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchoolApp.RegisterMVC.DataAccess.Repository
{
    public class QuestionAndAnswareUserProtectionRepository : BaseRepository, IQuestionAndAnswareUserProtectionRepository
    {
        public QuestionAndAnswareUserProtectionRepository(DrivingSchoolRegisterDbContext dbContext)
        : base(dbContext) { }

        public async Task<QuestionAnswareUserProtection> GetQuestionAndAnswareById(string id)
        {
            return await _db.QuestionAnswareUserProtections.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<QuestionAnswareUserProtection> FindQuestionAndAnsware(Question question, string answare)
        {
            return await _db.QuestionAnswareUserProtections.Where(qa => qa.Question == question && qa.Answare == answare).FirstOrDefaultAsync();
        }
        public async Task Add(QuestionAnswareUserProtection questionAnswareUserProtection)
        {
            _db.Add(questionAnswareUserProtection);
            await _db.SaveChangesAsync();
        }
    }
}
