using Xunit;
using Microsoft.AspNetCore.Mvc;
using ProyectoAsistencia.Controllers;
using ProyectoAsistencia.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoAsistencia.Tests
{
    public class AsistenciaControllerTests2
    {
        [Fact]
        public void Index_ShouldReturnViewWithAsistencias()
        {
            // Arrange
            var controller = new AsistenciaController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<Asistencia>>(result?.Model);
        }

        [Fact]
        public void RegistrarAsistenciaGet_ShouldReturnViewWithEmpleados()
        {
            // Arrange
            var controller = new AsistenciaController();

            // Act
            var result = controller.RegistrarAsistencia() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(result?.ViewData["Empleados"]);
        }

        [Fact]
        public void RegistrarAsistenciaPost_ShouldAddAsistencia_WhenEmpleadoExists()
        {
            // Arrange
            var controller = new AsistenciaController();
            var empleadoId = 1; // Simula un empleado existente
            var estado = true;

            // Act
            var result = controller.RegistrarAsistencia(empleadoId, estado) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Historial", result?.ActionName);
        }

        [Fact]
        public void RegistrarAsistenciaPost_ShouldReturnBadRequest_WhenEmpleadoNotFound()
        {
            // Arrange
            var controller = new AsistenciaController();
            var empleadoId = -1; // Empleado no existente
            var estado = true;

            // Act
            var result = controller.RegistrarAsistencia(empleadoId, estado) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Empleado no encontrado.", result?.Value);
        }

        [Fact]
        public void Historial_ShouldReturnViewWithAsistencias()
        {
            // Arrange
            var controller = new AsistenciaController();

            // Act
            var result = controller.Historial() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<Asistencia>>(result?.Model);
        }
    }
}
