using System.Collections.Generic;
using ProyectoAsistencia.Models;

namespace ProyectoAsistencia.Views.Asistencia
{
    public class HistorialModel
    {
        public List<Historial> HistorialCambios { get; set; } = new List<Historial>();

        public void OnGet()
        {
            // Método vacío para pruebas.
        }
    }
}
