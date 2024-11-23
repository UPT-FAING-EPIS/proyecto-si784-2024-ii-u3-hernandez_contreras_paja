using System.ComponentModel.DataAnnotations;

namespace ProyectoAsistencia.Models
{
    public class Asistencia
    {
        public int Id { get; set; }

        [Required]
        public int EmpleadoId { get; set; }

        [Required] // Asegura que Empleado no puede ser nulo
        public Empleado? Empleado { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "2000-01-01", "2100-12-31", ErrorMessage = "La fecha debe estar entre 01/01/2000 y 31/12/2100")]
        public DateTime Fecha { get; set; }

        [Required]
        public bool Estado { get; set; }
    }
}
