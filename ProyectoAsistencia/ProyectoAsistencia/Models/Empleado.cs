using System.ComponentModel.DataAnnotations;

namespace ProyectoAsistencia.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
        [MinLength(3, ErrorMessage = "El nombre de usuario debe tener al menos 3 caracteres")]
        public string NombreUsuario { get; set; } = string.Empty; // Inicialización predeterminada

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Contraseña { get; set; } = string.Empty; // Inicialización predeterminada
    }
}
