using Microsoft.AspNetCore.Mvc;
using ProyectoAsistencia.Models;
using System.Collections.Generic;

namespace ProyectoAsistencia.Controllers
{
    public class EmpleadoController : Controller
    {
        private static List<Empleado> empleados = new List<Empleado>();

        // Acción para agregar un nuevo empleado
        public IActionResult AgregarEmpleado()
        {
            return View();
        }

        // Acción POST para agregar un nuevo empleado
        [HttpPost]
        public IActionResult AgregarEmpleado(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                empleado.Id = empleados.Count + 1;
                empleados.Add(empleado); // Agregar el empleado a la lista
                return RedirectToAction("VerEmpleados");
            }

            return View(empleado);
        }

        // Acción para ver todos los empleados registrados
        public IActionResult VerEmpleados()
        {
            return View(empleados);
        }

        // Método para obtener los empleados registrados
        public static List<Empleado> ObtenerEmpleados()
        {
            return empleados;
        }
    }
}
