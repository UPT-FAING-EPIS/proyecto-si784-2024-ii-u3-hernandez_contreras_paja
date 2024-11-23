using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoAsistencia.Models
{
    public class Historial
    {
        public int Id { get; set; }
        public string Accion { get; set; } = string.Empty; // Inicialización predeterminada
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El usuario es obligatorio")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "El usuario solo puede contener letras y números")]       
        public string Usuario { get; set; } = string.Empty; // Inicialización predeterminada
    }
}
