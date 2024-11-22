using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoAsistencia.Models;

namespace ProyectoAsistencia.Views.Asistencia
{
    public class FiltrarPorFechaModel
    {
        public List<ProyectoAsistencia.Models.Asistencia> Asistencias { get; set; } = new List<ProyectoAsistencia.Models.Asistencia>();

        public void OnGet()
        {
            // Método vacío para pruebas.
        }

        public void OnPost(DateTime fechaInicio, DateTime fechaFin)
        {
            Asistencias = Asistencias.Where(a => a.Fecha >= fechaInicio && a.Fecha <= fechaFin).ToList();
        }
    }
}
