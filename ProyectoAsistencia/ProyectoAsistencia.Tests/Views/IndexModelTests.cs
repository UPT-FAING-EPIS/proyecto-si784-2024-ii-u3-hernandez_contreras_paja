using Xunit;
using ProyectoAsistencia.Views.Asistencia;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProyectoAsistencia.Tests
{
    public class IndexModelTests
    {
        [Fact]
        public void OnGet_Should_Not_Throw_Exception()
        {
            // Arrange
            var indexModel = new IndexModel();

            // Act
            var exception = Record.Exception(() => indexModel.OnGet());

            // Assert
            Assert.Null(exception);
        }
    }
}
