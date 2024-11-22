using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using ProyectoAsistencia.Controllers;
using ProyectoAsistencia.Models;

namespace ProyectoAsistencia.Tests.Controllers
{
    public class HomeControllerTests
    {
        private readonly Mock<ILogger<HomeController>> _mockLogger;
        private readonly HomeController _controller;

        public HomeControllerTests()
        {
            _mockLogger = new Mock<ILogger<HomeController>>();
            _controller = new HomeController(_mockLogger.Object);
        }

        [Fact]
        public void Index_ReturnsViewResult()
        {
            // Act
            var result = _controller.Index();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Privacy_ReturnsViewResult()
        {
            // Act
            var result = _controller.Privacy();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Error_ReturnsViewResult_WithErrorViewModel()
        {
            // Arrange
            var defaultHttpContext = new DefaultHttpContext();
            defaultHttpContext.TraceIdentifier = "TestTraceIdentifier"; // Simular un TraceIdentifier
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = defaultHttpContext
            };

            // Act
            var result = _controller.Error() as ViewResult;

            // Assert
            Assert.NotNull(result);

            // Verifica que el modelo sea del tipo ErrorViewModel
            var model = Assert.IsAssignableFrom<ErrorViewModel>(result!.Model);
            Assert.Equal("TestTraceIdentifier", model.RequestId); // Verifica el TraceIdentifier simulado
        }
    }
}
