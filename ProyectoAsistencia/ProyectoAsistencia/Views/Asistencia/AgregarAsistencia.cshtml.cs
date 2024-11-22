using System.Collections.Generic;
using ProyectoAsistencia.Models;

namespace ProyectoAsistencia.Views.Asistencia
{
    public class AgregarAsistenciaModel
    {
        public List<ProyectoAsistencia.Models.Asistencia> Asistencias { get; set; } = new List<ProyectoAsistencia.Models.Asistencia>();

        public void OnGet()
        {
            // Método vacío para pruebas.
        }

        public void OnPost(ProyectoAsistencia.Models.Asistencia nuevaAsistencia)
        {
            Asistencias.Add(nuevaAsistencia);
        }
    }
}
