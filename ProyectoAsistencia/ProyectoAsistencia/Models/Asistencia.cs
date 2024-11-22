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

        public DateTime Fecha { get; set; }

        public bool Estado { get; set; }
    }
}
