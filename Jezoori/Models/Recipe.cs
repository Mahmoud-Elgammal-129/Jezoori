using System.ComponentModel.DataAnnotations;

namespace Jezoori.Models
{
    public class Recipe : BaseEntity
    {
        //[Key]
        //public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string? Description { get; set; }
        public string Ingredients { get; set; }
        public string Steps { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? Image { get; set; }
    }

}
