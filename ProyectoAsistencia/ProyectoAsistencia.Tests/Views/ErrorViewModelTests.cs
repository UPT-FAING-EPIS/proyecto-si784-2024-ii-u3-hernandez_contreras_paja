using Xunit;
using ProyectoAsistencia.Models; // Asegúrate de que el espacio de nombres sea correcto

namespace ProyectoAsistencia.Tests
{
    public class ErrorViewModelTests
    {
        [Fact]
        public void ShowRequestId_ShouldReturnTrue_WhenRequestIdIsNotNullOrEmpty()
        {
            // Arrange
            var errorViewModel = new ErrorViewModel
            {
                RequestId = "12345"
            };

            // Act
            var result = errorViewModel.ShowRequestId;

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ShowRequestId_ShouldReturnFalse_WhenRequestIdIsNullOrEmpty()
        {
            // Arrange
            var errorViewModel = new ErrorViewModel
            {
                RequestId = null
            };

            // Act
            var result = errorViewModel.ShowRequestId;

            // Assert
            Assert.False(result);
        }
    }
}
