using System.ComponentModel.DataAnnotations;

namespace Jezoori.Models
{
    public class ProductCategory : BaseEntity
    {
        //[Key]
        //public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation Property
        public ICollection<Product>? Products { get; set; }
    }

}
