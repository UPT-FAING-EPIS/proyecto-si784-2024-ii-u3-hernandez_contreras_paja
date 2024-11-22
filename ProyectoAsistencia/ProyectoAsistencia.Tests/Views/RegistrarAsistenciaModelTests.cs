using Xunit;
using ProyectoAsistencia.Views.Asistencia;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProyectoAsistencia.Tests
{
    public class RegistrarAsistenciaModelTests
    {
        [Fact]
        public void OnGet_Should_Not_Throw_Exception()
        {
            // Arrange
            var registrarAsistenciaModel = new RegistrarAsistenciaModel();

            // Act
            var exception = Record.Exception(() => registrarAsistenciaModel.OnGet());

            // Assert
            Assert.Null(exception); // Verifica que no se haya lanzado ninguna excepción
        }
    }
}
