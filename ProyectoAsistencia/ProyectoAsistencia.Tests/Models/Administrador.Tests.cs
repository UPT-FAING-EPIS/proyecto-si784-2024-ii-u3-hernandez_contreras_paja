using ProyectoAsistencia.Models;
using Xunit;

namespace ProyectoAsistencia.Tests.Models
{
    public class AdministradorTests
    {
        [Fact]
        public void Administrador_IdProperty_ShouldSetAndGetCorrectly()
        {
            // Arrange
            var administrador = new Administrador();

            // Act
            administrador.Id = 123;

            // Assert
            Assert.Equal(123, administrador.Id);
        }

        [Fact]
        public void Administrador_UsernameProperty_ShouldSetAndGetCorrectly()
        {
            // Arrange
            var administrador = new Administrador();

            // Act
            administrador.Username = "TestUser";

            // Assert
            Assert.Equal("TestUser", administrador.Username);
        }

        [Fact]
        public void Administrador_PasswordProperty_ShouldSetAndGetCorrectly()
        {
            // Arrange
            var administrador = new Administrador();

            // Act
            administrador.Password = "SecurePassword";

            // Assert
            Assert.Equal("SecurePassword", administrador.Password);
        }
    }
}
