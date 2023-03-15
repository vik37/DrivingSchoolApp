using System.ComponentModel.DataAnnotations;

namespace DrivingSchoolApp.RegisterMVC.Main_Module.Account
{
    public class QuestionAnswerViewModel
    {
        [Required]
        public Question? Question { get; set; }
        [Required]
        [MaxLength(499, ErrorMessage = "{0} Maximum length is {1}")]
        public string Answer { get; set; } 
    }
}
