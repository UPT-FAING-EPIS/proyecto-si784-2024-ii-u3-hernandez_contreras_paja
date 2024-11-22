using System.ComponentModel.DataAnnotations;

namespace ProyectoAsistencia.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required]
        public string NombreUsuario { get; set; } = string.Empty; // Inicialización predeterminada

        [Required]
        public string Contraseña { get; set; } = string.Empty; // Inicialización predeterminada
    }
}
