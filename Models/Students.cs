using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_PARCIAL.Models
{
    public class Students : BaseModel
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo Edad es obligatorio")]
        public int Age { get; set; }

        [Required(ErrorMessage = "El campo Carnet es obligatorio")]
        public string Card { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Nacimiento es obligatorio")]
        public DateTime DateBirth { get; set; }

        [Required(ErrorMessage = "El campo Carrera es obligatorio")]
        [ForeignKey("Career")]
        public int CareerId { get; set; }
    }
}