using System.ComponentModel.DataAnnotations;

namespace BuilkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public String? Name { get; set; }

        [Required]
        [MaxLength(250)]
        public  String? Discription { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
