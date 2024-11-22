using System.ComponentModel.DataAnnotations;

namespace ProyectoAsistencia.Models
{
    public class Administrador
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
