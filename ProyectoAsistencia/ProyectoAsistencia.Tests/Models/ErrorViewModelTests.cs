using Xunit;
using ProyectoAsistencia.Models;

namespace ProyectoAsistencia.Tests.Models
{
    public class ErrorViewModelTests
    {
        [Fact]
        public void ShowRequestId_ShouldReturnFalse_WhenRequestIdIsNull()
        {
            // Arrange
            var model = new ErrorViewModel { RequestId = null };

            // Act
            var result = model.ShowRequestId;

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ShowRequestId_ShouldReturnFalse_WhenRequestIdIsEmpty()
        {
            // Arrange
            var model = new ErrorViewModel { RequestId = string.Empty };

            // Act
            var result = model.ShowRequestId;

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ShowRequestId_ShouldReturnTrue_WhenRequestIdIsNotEmpty()
        {
            // Arrange
            var model = new ErrorViewModel { RequestId = "ValidRequestId" };

            // Act
            var result = model.ShowRequestId;

            // Assert
            Assert.True(result);
        }
    }
}
