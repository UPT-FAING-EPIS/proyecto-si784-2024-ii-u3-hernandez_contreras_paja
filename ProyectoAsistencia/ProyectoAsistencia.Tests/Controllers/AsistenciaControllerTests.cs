using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using ProyectoAsistencia.Controllers;

namespace ProyectoAsistencia.Tests.Controllers
{
    [TestClass]
    public class AsistenciaControllerTests
    {
        private AsistenciaController? _controller;

        [TestInitialize]
        public void Setup()
        {
            _controller = new AsistenciaController();
        }

        [TestMethod]
        public void Index_ShouldReturnView()
        {
            // Act
            var result = _controller!.Index() as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Historial_ShouldReturnView()
        {
            // Act
            var result = _controller!.Historial() as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }

        [TestMethod]
        public void RegistrarAsistencia_Get_ShouldReturnView()
        {
            // Act
            var result = _controller!.RegistrarAsistencia() as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
        }

        [TestMethod]
        public void RegistrarAsistencia_Post_ShouldReturnActionResult()
        {
            // Arrange
            int empleadoId = 1; // No importa si es válido o no en esta prueba
            bool estado = true;

            // Act
            var result = _controller!.RegistrarAsistencia(empleadoId, estado);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsInstanceOfType(result, typeof(IActionResult));
        }

        [TestMethod]
        public void Setup_ShouldInitializeController()
        {
            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(_controller);
        }
    }
}
