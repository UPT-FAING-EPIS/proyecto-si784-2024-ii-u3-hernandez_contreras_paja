using Xunit;
using ProyectoAsistencia.Views.Asistencia;
using Microsoft.AspNetCore.Mvc;
using ProyectoAsistencia.Models;
using System.Collections.Generic;

namespace ProyectoAsistencia.Tests
{
    public class AsistenciaViewTest
    {
        #region AgregarAsistenciaModel Tests

        [Fact]
        public void AgregarAsistenciaModel_OnGet_NoThrowsException()
        {
            // Arrange
            var pageModel = new AgregarAsistenciaModel();

            // Act & Assert
            var exception = Record.Exception(() => pageModel.OnGet());
            Assert.Null(exception); // Si no se lanza excepción, la prueba es exitosa.
        }

        [Fact]
        public void AgregarAsistenciaModel_OnPost_ValidData_ShouldAddAsistencia()
        {
            // Arrange
            var pageModel = new AgregarAsistenciaModel();
            pageModel.Asistencias = new List<Asistencia>();

            // Act
            pageModel.OnPost(new Asistencia { EmpleadoId = 1, Estado = true });

            // Assert
            Assert.NotEmpty(pageModel.Asistencias); // La lista no debe estar vacía
            Assert.Single(pageModel.Asistencias); // Verifica que se agregó una asistencia
        }

        #endregion

        #region FiltrarPorFechaModel Tests

        [Fact]
        public void FiltrarPorFechaModel_OnGet_NoThrowsException()
        {
            // Arrange
            var pageModel = new FiltrarPorFechaModel();

            // Act & Assert
            var exception = Record.Exception(() => pageModel.OnGet());
            Assert.Null(exception); // Si no se lanza excepción, la prueba es exitosa.
        }

        [Fact]
        public void FiltrarPorFechaModel_OnPost_ValidDateRange_ShouldFilterAsistencias()
        {
            // Arrange
            var pageModel = new FiltrarPorFechaModel();
            pageModel.Asistencias = new List<Asistencia>
            {
                new Asistencia { Fecha = new System.DateTime(2024, 1, 1) },
                new Asistencia { Fecha = new System.DateTime(2024, 2, 1) }
            };

            // Act
            pageModel.OnPost(new System.DateTime(2024, 1, 1), new System.DateTime(2024, 1, 31));

            // Assert
            Assert.Single(pageModel.Asistencias); // Solo debe haber una asistencia en enero
        }

        #endregion

        #region HistorialModel Tests

        [Fact]
        public void HistorialModel_OnGet_NoThrowsException()
        {
            // Arrange
            var pageModel = new HistorialModel();

            // Act & Assert
            var exception = Record.Exception(() => pageModel.OnGet());
            Assert.Null(exception); // Si no se lanza excepción, la prueba es exitosa.
        }

        [Fact]
        public void HistorialModel_OnGet_ShouldReturnNonEmptyHistorial()
        {
            // Arrange
            var pageModel = new HistorialModel();
            pageModel.HistorialCambios = new List<Historial>
            {
                new Historial { Accion = "Test Change", Fecha = System.DateTime.Now }
            };

            // Act
            pageModel.OnGet();

            // Assert
            Assert.NotEmpty(pageModel.HistorialCambios); // La lista debe tener al menos un historial
        }

        #endregion

        #region ConfirmacionModel Tests

        [Fact]
        public void ConfirmacionModel_OnGet_NoThrowsException()
        {
            // Arrange
            var pageModel = new ConfirmacionModel();

            // Act & Assert
            var exception = Record.Exception(() => pageModel.OnGet());
            Assert.Null(exception); // Si no se lanza excepción, la prueba es exitosa.
        }

        [Fact]
        public void ConfirmacionModel_OnPost_ValidConfirmation_ShouldSetSuccess()
        {
            // Arrange
            var pageModel = new ConfirmacionModel();

            // Act
            pageModel.OnPost(true);

            // Assert
            Assert.True(pageModel.IsSuccess); // Debe haberse confirmado con éxito
        }

        [Fact]
        public void ConfirmacionModel_OnPost_InvalidConfirmation_ShouldSetFailure()
        {
            // Arrange
            var pageModel = new ConfirmacionModel();

            // Act
            pageModel.OnPost(false);

            // Assert
            Assert.False(pageModel.IsSuccess); // La confirmación debe haber fallado
        }

        #endregion
    }
}
