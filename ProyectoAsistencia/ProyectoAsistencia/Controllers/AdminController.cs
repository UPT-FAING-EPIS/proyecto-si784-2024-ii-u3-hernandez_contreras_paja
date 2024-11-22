using Microsoft.AspNetCore.Mvc;
using ProyectoAsistencia.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoAsistencia.Controllers
{
    public class AdminController : Controller
    {
        // Listas en memoria
        private static List<Empleado> empleados = new List<Empleado>();
        private static List<Asistencia> asistencias = new List<Asistencia>();
        private static List<Historial> historialCambios = new List<Historial>();

        // Métodos auxiliares para pruebas
        public static void AgregarEmpleadoParaPruebas(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public static void AgregarAsistenciaParaPruebas(Asistencia asistencia)
        {
            asistencias.Add(asistencia);
        }

        public static void LimpiarDatosPruebas()
        {
            empleados.Clear();
            asistencias.Clear();
            historialCambios.Clear();
        }

        // Acción para mostrar el Dashboard
        public IActionResult Dashboard()
        {
            ViewBag.TotalEmpleados = empleados.Count;
            ViewBag.AsistenciasHoy = asistencias.Count(a => a.Fecha.Date == DateTime.Now.Date);
            ViewBag.Presentes = asistencias.Count(a => a.Estado && a.Fecha.Date == DateTime.Now.Date);
            ViewBag.Ausentes = asistencias.Count(a => !a.Estado && a.Fecha.Date == DateTime.Now.Date);
            return View();
        }

        // Gestión de Empleados - Lista
        public IActionResult GestionEmpleados()
        {
            return View(empleados);
        }

        // GET: Formulario para agregar un nuevo empleado
        public IActionResult AgregarEmpleado()
        {
            return View();
        }

        // POST: Agregar un nuevo empleado
        [HttpPost]
        public IActionResult AgregarEmpleado(Empleado empleado)
        {
            if (empleado == null || string.IsNullOrWhiteSpace(empleado.NombreUsuario))
            {
                ModelState.AddModelError("NombreUsuario", "El nombre de usuario es requerido.");
                return View(empleado);
            }

            // Verifica si el empleado ya existe
            if (empleados.Any(e => e.NombreUsuario == empleado.NombreUsuario))
            {
                ModelState.AddModelError("NombreUsuario", "El empleado ya existe.");
                return View(empleado);
            }

            empleado.Id = empleados.Count + 1;
            empleados.Add(empleado);

            // Registrar en el historial
            historialCambios.Add(new Historial
            {
                Id = historialCambios.Count + 1,
                Accion = "Empleado Agregado",
                Fecha = DateTime.Now,
                Usuario = "Admin" // En una aplicación real, esto sería el usuario autenticado
            });

            return RedirectToAction("GestionEmpleados");
        }

        // Gestión de Asistencias - Lista
        public IActionResult GestionAsistencias()
        {
            return View(asistencias);
        }

        // Historial de Cambios - Lista
        public IActionResult HistorialCambios()
        {
            return View(historialCambios);
        }

        // Acción para mostrar los reportes
        public IActionResult Reportes()
        {
            // Calcular Asistencias por Mes
            int[] asistenciasPorMes = new int[12];
            foreach (var asistencia in asistencias)
            {
                int mes = asistencia.Fecha.Month - 1; // Mes (0 = Enero, 11 = Diciembre)
                asistenciasPorMes[mes]++;
            }

            // Calcular Presentes y Ausentes
            int presentes = asistencias.Count(a => a.Estado);
            int ausentes = asistencias.Count(a => !a.Estado);

            // Pasar los datos a la vista
            ViewBag.AsistenciasPorMes = asistenciasPorMes;
            ViewBag.Presentes = presentes;
            ViewBag.Ausentes = ausentes;

            return View();
        }

        // Método para obtener la lista de empleados (usado por otros controladores)
        public static List<Empleado> ObtenerEmpleados()
        {
            return empleados;
        }
    }
}
