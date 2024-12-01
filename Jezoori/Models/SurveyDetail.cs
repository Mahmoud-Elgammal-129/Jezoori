using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jezoori.Models
{
    public class SurveyDetail : BaseEntity
    {
        //[Key]
        //public int SurveyDetailId { get; set; }
        public Guid SurveyId { get; set; }
        public Guid QuestionId { get; set; }

        // Navigation Properties
        [ForeignKey("SurveyId")]
        public Survey? Survey { get; set; }
        [ForeignKey("QuestionId")]
        public Question? Question { get; set; }
    }

}
