using System;

namespace ProyectoAsistencia.Models
{
    public class Historial
    {
        public int Id { get; set; }
        public string Accion { get; set; } = string.Empty; // Inicialización predeterminada
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; } = string.Empty; // Inicialización predeterminada
    }
}
