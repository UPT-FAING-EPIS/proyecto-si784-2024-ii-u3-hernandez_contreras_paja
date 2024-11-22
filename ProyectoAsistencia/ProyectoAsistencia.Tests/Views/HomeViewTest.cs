using Xunit;
using Moq;
using ProyectoAsistencia.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProyectoAsistencia.Tests
{
    public class HomeControllerTests
    {
        #region Index Tests

        [Fact]
        public void Index_ReturnsViewResult()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<HomeController>>(); // Crear un mock de ILogger
            var controller = new HomeController(mockLogger.Object); // Pasar el mock al controlador

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result); // Verifica que se devuelve un ViewResult
        }

        #endregion

        #region Privacy Tests

        [Fact]
        public void Privacy_ReturnsViewResult()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<HomeController>>(); // Crear un mock de ILogger
            var controller = new HomeController(mockLogger.Object); // Pasar el mock al controlador

            // Act
            var result = controller.Privacy();

            // Assert
            Assert.IsType<ViewResult>(result); // Verifica que se devuelve un ViewResult
        }

        #endregion
    }
}
