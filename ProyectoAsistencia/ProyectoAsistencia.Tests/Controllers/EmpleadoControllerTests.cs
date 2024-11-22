using Xunit;
using ProyectoAsistencia.Controllers;
using ProyectoAsistencia.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProyectoAsistencia.Tests.Controllers
{
    public class EmpleadoControllerTests
    {
        // Test para la acción AgregarEmpleado (GET)
        [Fact]
        public void AgregarEmpleado_Get_ReturnsViewResult()
        {
            // Arrange
            var controller = new EmpleadoController();

            // Act
            var result = controller.AgregarEmpleado() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }

        // Test para la acción AgregarEmpleado (POST) con modelo válido
        [Fact]
        public void AgregarEmpleado_Post_ReturnsRedirectToAction_WhenModelIsValid()
        {
            // Arrange
            var controller = new EmpleadoController();
            var empleado = new Empleado
            {
                NombreUsuario = "Carlos López",
                Contraseña = "password123"
            };

            // Act
            var result = controller.AgregarEmpleado(empleado) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("VerEmpleados", result!.ActionName);
            Assert.Contains(empleado, EmpleadoController.ObtenerEmpleados());
        }

        // Test para la acción AgregarEmpleado (POST) con modelo no válido
        [Fact]
        public void AgregarEmpleado_Post_ReturnsViewResult_WhenModelIsInvalid()
        {
            // Arrange
            var controller = new EmpleadoController();
            controller.ModelState.AddModelError("NombreUsuario", "El nombre de usuario es requerido");
            var empleado = new Empleado
            {
                Contraseña = "password123"
            };

            // Act
            var result = controller.AgregarEmpleado(empleado) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(empleado, result!.Model);
        }

        // Test para la acción VerEmpleados
        [Fact]
        public void VerEmpleados_ReturnsViewResult_WithListOfEmpleados()
        {
            // Arrange
            EmpleadoController.ObtenerEmpleados().Clear(); // Limpiar lista de empleados
            EmpleadoController.ObtenerEmpleados().Add(new Empleado { Id = 1, NombreUsuario = "Juan Pérez", Contraseña = "1234" });
            var controller = new EmpleadoController();

            // Act
            var result = controller.VerEmpleados() as ViewResult;

            // Assert
            Assert.NotNull(result);
            var model = Assert.IsAssignableFrom<List<Empleado>>(result!.Model);
            Assert.Single(model); // Verifica que hay exactamente un empleado en la lista
        }

        // Test para validar que se agrega un empleado correctamente a la lista
        [Fact]
        public void AgregarEmpleado_UpdatesEmpleadoList()
        {
            // Arrange
            EmpleadoController.ObtenerEmpleados().Clear();
            var controller = new EmpleadoController();
            var empleado = new Empleado
            {
                NombreUsuario = "Ana Torres",
                Contraseña = "securePass"
            };

            // Act
            var result = controller.AgregarEmpleado(empleado) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            var empleados = EmpleadoController.ObtenerEmpleados();
            Assert.Single(empleados);
            Assert.Equal("Ana Torres", empleados[0].NombreUsuario);
        }
    }
}