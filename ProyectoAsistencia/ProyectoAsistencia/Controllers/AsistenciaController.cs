using Microsoft.AspNetCore.Mvc;
using ProyectoAsistencia.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoAsistencia.Controllers
{
    public class AsistenciaController : Controller
    {
        private static List<Asistencia> asistencias = new List<Asistencia>();

        // Acción para listar todas las asistencias
        public IActionResult Index()
        {
            return View(asistencias);
        }

        // Acción para registrar la asistencia de un empleado
        public IActionResult RegistrarAsistencia()
        {
            ViewBag.Empleados = EmpleadoController.ObtenerEmpleados();
            return View();
        }

        // Acción POST para registrar la asistencia
        [HttpPost]
        public IActionResult RegistrarAsistencia(int empleadoId, bool estado)
        {
            var empleado = EmpleadoController.ObtenerEmpleados().FirstOrDefault(e => e.Id == empleadoId);
            if (empleado == null) return BadRequest("Empleado no encontrado.");

            var asistencia = new Asistencia
            {
                Id = asistencias.Count + 1,
                EmpleadoId = empleado.Id,
                Empleado = empleado,
                Fecha = DateTime.Now,
                Estado = estado
            };

            asistencias.Add(asistencia);
            return RedirectToAction("Historial");
        }

        // Acción para ver el historial de asistencias
        public IActionResult Historial()
        {
            return View(asistencias);
        }
    }
}
