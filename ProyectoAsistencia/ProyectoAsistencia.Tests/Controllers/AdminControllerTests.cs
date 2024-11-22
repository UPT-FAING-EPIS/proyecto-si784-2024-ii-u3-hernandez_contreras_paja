using Xunit;
using ProyectoAsistencia.Controllers;
using ProyectoAsistencia.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ProyectoAsistencia.Tests.Controllers
{
    public class AdminControllerTests
    {
        // Test para la acción Dashboard
        [Fact]
        public void Dashboard_ReturnsViewResult_WithCorrectViewBagValues()
        {
            // Arrange
            AdminController.LimpiarDatosPruebas();
            AdminController.AgregarEmpleadoParaPruebas(new Empleado { Id = 1, NombreUsuario = "Juan Pérez" });
            AdminController.AgregarAsistenciaParaPruebas(new Asistencia { Fecha = DateTime.Now, Estado = true });
            var controller = new AdminController();

            // Act
            var result = controller.Dashboard() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.ViewData["TotalEmpleados"]);
            Assert.Equal(1, result.ViewData["AsistenciasHoy"]);
            Assert.Equal(1, result.ViewData["Presentes"]);
            Assert.Equal(0, result.ViewData["Ausentes"]);
        }

        // Test para la acción GestionEmpleados
        [Fact]
        public void GestionEmpleados_ReturnsViewResult_WithListOfEmpleados()
        {
            // Arrange
            AdminController.LimpiarDatosPruebas();
            AdminController.AgregarEmpleadoParaPruebas(new Empleado { Id = 1, NombreUsuario = "Juan Pérez" });
            var controller = new AdminController();

            // Act
            var result = controller.GestionEmpleados() as ViewResult;

            // Assert
            Assert.NotNull(result);
            var model = Assert.IsAssignableFrom<List<Empleado>>(result!.Model);
            Assert.Single(model); // Verifica que hay exactamente un empleado
        }

        // Test para la acción AgregarEmpleado (GET)
        [Fact]
        public void AgregarEmpleado_ReturnsViewResult()
        {
            // Arrange
            var controller = new AdminController();

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
            var controller = new AdminController();
            var empleado = new Empleado
            {
                NombreUsuario = "Carlos López" // Cambiado de Nombre a NombreUsuario
            };

            // Act
            var result = controller.AgregarEmpleado(empleado) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("GestionEmpleados", result!.ActionName);
        }

        // Test para la acción AgregarEmpleado (POST) con modelo no válido
        [Fact]
        public void AgregarEmpleado_Post_ReturnsViewResult_WhenModelIsInvalid()
        {
            // Arrange
            var controller = new AdminController();
            controller.ModelState.AddModelError("NombreUsuario", "El nombre de usuario es requerido"); // Cambiado de Nombre a NombreUsuario
            var empleado = new Empleado(); // Sin nombre de usuario

            // Act
            var result = controller.AgregarEmpleado(empleado) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(empleado, result!.Model);
        }

        // Test para la acción GestionAsistencias
        [Fact]
        public void GestionAsistencias_ReturnsViewResult_WithListOfAsistencias()
        {
            // Arrange
            AdminController.LimpiarDatosPruebas();
            AdminController.AgregarAsistenciaParaPruebas(new Asistencia { Fecha = DateTime.Now, Estado = true });
            var controller = new AdminController();

            // Act
            var result = controller.GestionAsistencias() as ViewResult;

            // Assert
            Assert.NotNull(result);
            var model = Assert.IsAssignableFrom<List<Asistencia>>(result!.Model);
            Assert.Single(model); // Verifica que hay exactamente una asistencia
        }

        // Test para la acción HistorialCambios
        [Fact]
        public void HistorialCambios_ReturnsViewResult_WithListOfHistorial()
        {
            // Arrange
            var controller = new AdminController();

            // Act
            var result = controller.HistorialCambios() as ViewResult;

            // Assert
            Assert.NotNull(result);
            var model = Assert.IsAssignableFrom<List<Historial>>(result!.Model);
            Assert.NotNull(model);
        }

        // Test para la acción Reportes
        [Fact]
        public void Reportes_ReturnsViewResult_WithCorrectViewBagValues()
        {
            // Arrange
            AdminController.LimpiarDatosPruebas();
            AdminController.AgregarAsistenciaParaPruebas(new Asistencia { Fecha = DateTime.Now, Estado = true });
            AdminController.AgregarAsistenciaParaPruebas(new Asistencia { Fecha = DateTime.Now.AddDays(-1), Estado = false });
            var controller = new AdminController();

            // Act
            var result = controller.Reportes() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.ViewData["Presentes"]);
            Assert.Equal(1, result.ViewData["Ausentes"]);
        }

        // Test para Dashboard con escenarios vacíos
        [Fact]
        public void Dashboard_ReturnsCorrectCounts_WhenNoData()
        {
            // Arrange
            AdminController.LimpiarDatosPruebas();
            var controller = new AdminController();

            // Act
            var result = controller.Dashboard() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(0, result!.ViewData["TotalEmpleados"]);
            Assert.Equal(0, result.ViewData["AsistenciasHoy"]);
            Assert.Equal(0, result.ViewData["Presentes"]);
            Assert.Equal(0, result.ViewData["Ausentes"]);
        }

        // Test para agregar un empleado con duplicados (si se manejan)
      
        [Fact]
public void AgregarEmpleado_Post_ReturnsError_WhenDuplicateEmpleado()
{
    // Arrange
    AdminController.LimpiarDatosPruebas();
    var empleado = new Empleado { NombreUsuario = "Carlos López" };
    AdminController.AgregarEmpleadoParaPruebas(empleado);

    var controller = new AdminController();

    // Act
    var result = controller.AgregarEmpleado(empleado) as ViewResult;

    // Assert
    Assert.NotNull(result); // Asegura que no sea nulo
    Assert.Equal(empleado, result!.Model); // El modelo debe ser el empleado duplicado
    Assert.False(controller.ModelState.IsValid); // La validación del modelo debe fallar
    Assert.Contains("El empleado ya existe.", 
        controller.ModelState["NombreUsuario"]!.Errors[0].ErrorMessage); // Mensaje de error esperado
}


        // Test para GestionAsistencias con asistencias vacías
        [Fact]
        public void GestionAsistencias_ReturnsEmptyList_WhenNoAsistencias()
        {
            // Arrange
            AdminController.LimpiarDatosPruebas();
            var controller = new AdminController();

            // Act
            var result = controller.GestionAsistencias() as ViewResult;

            // Assert
            Assert.NotNull(result);
            var model = Assert.IsAssignableFrom<List<Asistencia>>(result!.Model);
            Assert.Empty(model);
        }

        // Test para HistorialCambios cuando no hay historial
        [Fact]
        public void HistorialCambios_ReturnsEmptyList_WhenNoHistorial()
        {
            // Arrange
            AdminController.LimpiarDatosPruebas();
            var controller = new AdminController();

            // Act
            var result = controller.HistorialCambios() as ViewResult;

            // Assert
            Assert.NotNull(result);
            var model = Assert.IsAssignableFrom<List<Historial>>(result!.Model);
            Assert.Empty(model);
        }

        // Test para Reportes cuando no hay asistencias
        [Fact]
        public void Reportes_ReturnsCorrectData_WhenNoAsistencias()
        {
            // Arrange
            AdminController.LimpiarDatosPruebas();
            var controller = new AdminController();

            // Act
            var result = controller.Reportes() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new int[12], result!.ViewData["AsistenciasPorMes"]);
            Assert.Equal(0, result.ViewData["Presentes"]);
            Assert.Equal(0, result.ViewData["Ausentes"]);
        }
    }
}
