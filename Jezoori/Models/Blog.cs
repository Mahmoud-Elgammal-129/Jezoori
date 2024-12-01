using System.ComponentModel.DataAnnotations;

namespace Jezoori.Models
{
    public class Blog : BaseEntity
    {
        //[Key]
        //public int BlogId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string? Image { get; set; }

    }

}
