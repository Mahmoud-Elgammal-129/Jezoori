using System.ComponentModel.DataAnnotations;

namespace Jezoori.Models
{
    public class BaseEntity
    {
        [Key]
        public Guid ID { get; set; } = Guid.NewGuid();

    }
}
