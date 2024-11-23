using System.ComponentModel.DataAnnotations;

namespace ProyectoAsistencia.Models
{
    public class Administrador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El username es obligatorio")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "El username solo puede contener letras y números")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Password { get; set; } = string.Empty;
    }
}
