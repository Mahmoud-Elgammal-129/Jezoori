using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jezoori.Models
{
    public class Product : BaseEntity
    {
        //[Key]
        //public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public Guid CategoryId { get; set; }
        public string? Image { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation Property
        [ForeignKey("CategoryId")]
        public ProductCategory? Category { get; set; }
    }

}
