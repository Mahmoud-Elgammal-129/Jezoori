using System.ComponentModel.DataAnnotations;

namespace Jezoori.Models
{
    public class Question : BaseEntity
    {
        //[Key]
        //public int QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionText { get; set; }
        public string? Image { get; set; }

        // Navigation Property
        public ICollection<SurveyDetail>? SurveyDetails { get; set; }
    }

}
