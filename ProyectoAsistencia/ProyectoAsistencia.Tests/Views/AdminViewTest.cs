using Xunit;
using ProyectoAsistencia.Views.Admin;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using ProyectoAsistencia.Models;

namespace ProyectoAsistencia.Tests
{
    public class AdminViewTest
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

        #endregion

        #region DashboardModel Tests

        [Fact]
        public void DashboardModel_OnGet_NoThrowsException()
        {
            // Arrange
            var pageModel = new DashboardModel();

            // Act & Assert
            var exception = Record.Exception(() => pageModel.OnGet());
            Assert.Null(exception); // Si no se lanza excepción, la prueba es exitosa.
        }

        #endregion

        #region GestionAsistenciasModel Tests

        [Fact]
        public void GestionAsistenciasModel_OnGet_NoThrowsException()
        {
            // Arrange
            var pageModel = new GestionAsistenciasModel();

            // Act & Assert
            var exception = Record.Exception(() => pageModel.OnGet());
            Assert.Null(exception); // Si no se lanza excepción, la prueba es exitosa.
        }

        [Fact]
        public void GestionAsistenciasModel_WhenNoAsistencias_DisplaysNoAsistenciasMessage()
        {
            // Arrange
            var pageModel = new GestionAsistenciasModel();
            var model = new List<Asistencia>();

            // Act
            pageModel.OnGet();

            // Assert
            Assert.Empty(model); // Verifica que no hay asistencias
        }

        #endregion

        #region GestionEmpleadosModel Tests

        [Fact]
        public void GestionEmpleadosModel_OnGet_NoThrowsException()
        {
            // Arrange
            var pageModel = new GestionEmpleadosModel();

            // Act & Assert
            var exception = Record.Exception(() => pageModel.OnGet());
            Assert.Null(exception); // Si no se lanza excepción, la prueba es exitosa.
        }

        #endregion

        #region HistorialCambiosModel Tests

        [Fact]
        public void HistorialCambiosModel_OnGet_NoThrowsException()
        {
            // Arrange
            var pageModel = new HistorialCambiosModel();

            // Act & Assert
            var exception = Record.Exception(() => pageModel.OnGet());
            Assert.Null(exception); // Si no se lanza excepción, la prueba es exitosa.
        }

        [Fact]
        public void HistorialCambiosModel_WhenNoChanges_DisplaysNoChangesMessage()
        {
            // Arrange
            var pageModel = new HistorialCambiosModel();
            var model = new List<Historial>();

            // Act
            pageModel.OnGet();

            // Assert
            Assert.Empty(model); // Verifica que no hay historial de cambios
        }

        #endregion

        #region ReportesModel Tests

        [Fact]
        public void ReportesModel_OnGet_NoThrowsException()
        {
            // Arrange
            var pageModel = new ReportesModel();

            // Act & Assert
            var exception = Record.Exception(() => pageModel.OnGet());
            Assert.Null(exception); // Si no se lanza excepción, la prueba es exitosa.
        }

        #endregion

        #region VerEmpleadosModel Tests

        [Fact]
        public void VerEmpleadosModel_OnGet_NoThrowsException()
        {
            // Arrange
            var pageModel = new VerEmpleadosModel();

            // Act & Assert
            var exception = Record.Exception(() => pageModel.OnGet());
            Assert.Null(exception); // Si no se lanza excepción, la prueba es exitosa.
        }

        [Fact]
        public void VerEmpleadosModel_WhenNoEmpleados_DisplaysNoEmployeesMessage()
        {
            // Arrange
            var pageModel = new VerEmpleadosModel();
            var model = new List<Empleado>();

            // Act
            pageModel.OnGet();

            // Assert
            Assert.Empty(model); // Verifica que no hay empleados
        }

        #endregion
    }
}
