using System.ComponentModel.DataAnnotations;

namespace Jezoori.Models
{
    public class Order : BaseEntity
    {
        //[Key]
        //public int OrderId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string CustomerName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public decimal TotalAmount { get; set; }

        // Navigation Property
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }

}
