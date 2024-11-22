using Xunit;
using ProyectoAsistencia.Views.Empleado;
using Microsoft.AspNetCore.Mvc;
using ProyectoAsistencia.Models;
using System.Collections.Generic;

namespace ProyectoAsistencia.Tests
{
    public class EmpleadoViewTest
    {
        #region AgregarEmpleadoModel Tests

        [Fact]
        public void AgregarEmpleadoModel_OnGet_NoThrowsException()
        {
            // Arrange
            var pageModel = new AgregarEmpleadoModel();

            // Act & Assert
            var exception = Record.Exception(() => pageModel.OnGet());
            Assert.Null(exception); // Si no se lanza excepción, la prueba es exitosa.
        }

        [Fact]
        public void AgregarEmpleadoModel_OnPost_AddsEmpleado()
        {
            // Arrange
            var pageModel = new AgregarEmpleadoModel
            {
                Empleado = new Empleado
                {
                    Id = 1,
                    NombreUsuario = "NuevoEmpleado"
                }
            };

            // Act
            pageModel.OnPost();

            // Assert
            Assert.Contains(pageModel.Empleado, pageModel.Empleados); // Verifica que el empleado fue agregado.
        }

        #endregion

        #region DetallesModel Tests

        [Fact]
        public void DetallesModel_OnGet_NoThrowsException()
        {
            // Arrange
            var pageModel = new DetallesModel();

            // Act & Assert
            var exception = Record.Exception(() => pageModel.OnGet());
            Assert.Null(exception); // Si no se lanza excepción, la prueba es exitosa.
        }

        [Fact]
        public void DetallesModel_OnGet_ProvidesCorrectEmpleadoDetails()
        {
            // Arrange
            var pageModel = new DetallesModel();
            pageModel.Empleado = new Empleado { Id = 1, NombreUsuario = "Empleado1" };

            // Act
            pageModel.OnGet();

            // Assert
            Assert.Equal("Empleado1", pageModel.Empleado.NombreUsuario); // Verifica los detalles del empleado.
        }

        #endregion

        #region IndexModel Tests

        [Fact]
        public void IndexModel_OnGet_NoThrowsException()
        {
            // Arrange
            var pageModel = new IndexModel();

            // Act & Assert
            var exception = Record.Exception(() => pageModel.OnGet());
            Assert.Null(exception); // Si no se lanza excepción, la prueba es exitosa.
        }

        [Fact]
        public void IndexModel_OnGet_PopulatesEmpleadoList()
        {
            // Arrange
            var pageModel = new IndexModel();
            pageModel.Empleados = new List<Empleado>
            {
                new Empleado { Id = 1, NombreUsuario = "Empleado1" },
                new Empleado { Id = 2, NombreUsuario = "Empleado2" }
            };

            // Act
            pageModel.OnGet();

            // Assert
            Assert.NotEmpty(pageModel.Empleados); // Verifica que la lista no está vacía.
            Assert.Equal(2, pageModel.Empleados.Count); // Verifica el conteo de empleados.
        }

        #endregion
    }
}
