using System.ComponentModel.DataAnnotations;

namespace Jezoori.Models
{
    public class Survey : BaseEntity
    {
        //[Key]
        //public int SurveyId { get; set; }
        public string CustomerName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation Property
        public ICollection<SurveyDetail>? SurveyDetails { get; set; }
    }

}
