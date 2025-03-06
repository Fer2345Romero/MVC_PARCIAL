using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_PARCIAL.Models
{
    public class Students : BaseModel
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        public int Age { get; set; }

        [StringLength(50)]
        public string Card { get; set; }

        public DateTime DateBirth { get; set; }

        [ForeignKey("Career")]
        public int CareerId { get; set; }
    }
}