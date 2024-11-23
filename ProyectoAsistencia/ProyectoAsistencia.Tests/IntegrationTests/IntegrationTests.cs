using Xunit; // Mantener Xunit para las pruebas
using ProyectoAsistencia.Models;
using System.ComponentModel.DataAnnotations;

// Alias para evitar confusión
using XunitAssert = Xunit.Assert;

namespace ProyectoAsistencia.Tests.Integrations
{
    public class IntegrationTests
    {
        [Fact] // Prueba usando xUnit
        public void CrearEmpleado_DeberiaAsignarValoresCorrectos()
        {
            // Arrange
            var empleado = new Empleado { Id = 1, NombreUsuario = "Usuario1", Contraseña = "1234" };

            // Assert
            XunitAssert.Equal(1, empleado.Id);
            XunitAssert.Equal("Usuario1", empleado.NombreUsuario);
            XunitAssert.Equal("1234", empleado.Contraseña);
        }

        [Fact] // Prueba usando xUnit
        public void CrearAdministrador_DeberiaAsignarValoresCorrectos()
        {
            // Arrange
            var admin = new Administrador { Id = 1, Username = "Admin1", Password = "admin123" };

            // Assert
            XunitAssert.Equal(1, admin.Id);
            XunitAssert.Equal("Admin1", admin.Username);
            XunitAssert.Equal("admin123", admin.Password);
        }

        [Fact] // Prueba usando xUnit
        public void CrearHistorial_DeberiaAsignarValoresCorrectos()
        {
            // Arrange
            var historial = new Historial
            {
                Id = 1,
                Accion = "Creación de Empleado",
                Fecha = DateTime.Now,
                Usuario = "Admin1"
            };

            // Assert
            XunitAssert.Equal(1, historial.Id);
            XunitAssert.Equal("Creación de Empleado", historial.Accion);
            XunitAssert.Equal("Admin1", historial.Usuario);
        }

        [Fact] // Prueba usando xUnit
        public void CrearAsistencia_DeberiaAsignarValoresCorrectos()
        {
            // Arrange
            var empleado = new Empleado { Id = 1, NombreUsuario = "Usuario1" };
            var asistencia = new Asistencia
            {
                Id = 1,
                EmpleadoId = empleado.Id,
                Empleado = empleado,
                Fecha = DateTime.Today,
                Estado = true
            };

            // Assert
            XunitAssert.Equal(1, asistencia.Id);
            XunitAssert.Equal(empleado.Id, asistencia.EmpleadoId);
            XunitAssert.Equal(empleado, asistencia.Empleado);
            XunitAssert.Equal(DateTime.Today, asistencia.Fecha);
            XunitAssert.True(asistencia.Estado);
        }

        [Fact]
        public void CrearEmpleado_SinNombreUsuario_DeberiaFallar()
        {
            // Arrange
            var empleado = new Empleado { Id = 2, Contraseña = "5678" };

            // Act & Assert
            XunitAssert.Throws<ValidationException>(() =>
            {
                Validator.ValidateObject(empleado, new ValidationContext(empleado), true);
            });
        }

        [Fact]
        public void CrearEmpleado_ConNombreUsuarioCorto_DeberiaFallar()
        {
            // Arrange
            var empleado = new Empleado { Id = 1, NombreUsuario = "Us", Contraseña = "1234" };

            // Act & Assert
            XunitAssert.Throws<ValidationException>(() =>
            {
                Validator.ValidateObject(empleado, new ValidationContext(empleado), true);
            });
        }

        [Fact]
        public void CrearAdministrador_SinPassword_DeberiaFallar()
        {
            // Arrange
            var admin = new Administrador { Id = 2, Username = "Admin2" };

            // Act & Assert
            XunitAssert.Throws<ValidationException>(() =>
            {
                Validator.ValidateObject(admin, new ValidationContext(admin), true);
            });
        }

        [Fact]
        public void CrearAdministrador_ConUsernameInvalido_DeberiaFallar()
        {
            // Arrange
            var admin = new Administrador { Id = 3, Username = "##Invalid", Password = "admin123" };

            // Act & Assert
            XunitAssert.Throws<ValidationException>(() =>
            {
                Validator.ValidateObject(admin, new ValidationContext(admin), true);
            });
        }



        [Fact]
        public void CrearHistorial_ConUsuarioInvalido_DeberiaFallar()
        {
            // Arrange
            var historial = new Historial
            {
                Id = 1,
                Accion = "Creación",
                Fecha = DateTime.Now,
                Usuario = "Usuario@Invalido"
            };

            // Act & Assert
            XunitAssert.Throws<ValidationException>(() =>
            {
                Validator.ValidateObject(historial, new ValidationContext(historial), true);
            });
        }

        [Fact]
        public void CrearAsistencia_ConFechaFutura_DeberiaFallar()
        {
            // Arrange
            var empleado = new Empleado { Id = 1, NombreUsuario = "Usuario1", Contraseña = "1234" };
            var asistencia = new Asistencia
            {
                Id = 1,
                EmpleadoId = empleado.Id,
                Empleado = empleado,
                Fecha = DateTime.UtcNow.AddYears(100),
                Estado = true
            };

            // Act & Assert
            XunitAssert.Throws<ValidationException>(() =>
            {
                Validator.ValidateObject(asistencia, new ValidationContext(asistencia), true);
            });
        }

    

        [Fact]
        public void CrearEmpleadoYAsistencia_DeberiaAsignarValoresCorrectos()
        {
            // Arrange
            var empleado = new Empleado { Id = 1, NombreUsuario = "Usuario1", Contraseña = "1234" };
            var asistencia = new Asistencia
            {
                Id = 1,
                EmpleadoId = empleado.Id,
                Empleado = empleado,
                Fecha = DateTime.Today,
                Estado = true
            };

            // Assert
            XunitAssert.Equal(1, empleado.Id);
            XunitAssert.Equal(1, asistencia.EmpleadoId);
            XunitAssert.Equal(empleado, asistencia.Empleado);
        }

        [Fact]
        public void CrearHistorialAsociadoAAdmin_DeberiaAsignarValoresCorrectos()
        {
            // Arrange
            var admin = new Administrador { Id = 1, Username = "Admin1", Password = "admin123" };
            var historial = new Historial
            {
                Id = 1,
                Accion = "Creación",
                Fecha = DateTime.Now,
                Usuario = admin.Username
            };

            // Assert
            XunitAssert.Equal("Creación", historial.Accion);
            XunitAssert.Equal(admin.Username, historial.Usuario);
        }
        [Fact]
        public void CrearEmpleado_DeberiaTenerContraseñaNoVacia()
        {
            // Arrange
            var empleado = new Empleado { Id = 1, NombreUsuario = "Usuario1", Contraseña = "1234" };

            // Assert
            XunitAssert.False(string.IsNullOrEmpty(empleado.Contraseña));
        }

        [Fact]
        public void CrearAdministrador_DeberiaTenerUsernameCorrecto()
        {
            // Arrange
            var admin = new Administrador { Id = 2, Username = "AdminCorrecto", Password = "secure123" };

            // Assert
            XunitAssert.True(admin.Username.StartsWith("Admin"));
        }

        [Fact]
        public void CrearHistorial_DeberiaTenerFechaActual()
        {
            // Arrange
            var historial = new Historial { Fecha = DateTime.Now };

            // Assert
            XunitAssert.True(historial.Fecha.Date == DateTime.Today);
        }

    }
}
