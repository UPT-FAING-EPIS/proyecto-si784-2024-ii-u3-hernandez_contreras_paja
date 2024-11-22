using Xunit;
using ProyectoAsistencia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoAsistencia.Tests.Models
{
    public class AsistenciaTests
    {
        [Fact]
        public void Asistencia_Model_ShouldSetAndGetPropertiesCorrectly()
        {
            // Arrange
            var asistencia = new Asistencia();

            // Act
            asistencia.Id = 1;
            asistencia.EmpleadoId = 2;
            asistencia.Empleado = new Empleado { Id = 2 }; // Ajustado a las propiedades disponibles
            asistencia.Fecha = new DateTime(2024, 11, 16);
            asistencia.Estado = true;

            // Assert
            Assert.Equal(1, asistencia.Id);
            Assert.Equal(2, asistencia.EmpleadoId);
            Assert.NotNull(asistencia.Empleado);
            Assert.Equal(2, asistencia.Empleado.Id);
            Assert.Equal(new DateTime(2024, 11, 16), asistencia.Fecha);
            Assert.True(asistencia.Estado);
        }

        [Fact]
        public void Asistencia_Model_ShouldBeValid_WhenAllPropertiesAreSet()
        {
            // Arrange
            var asistencia = new Asistencia
            {
                Id = 1,
                EmpleadoId = 2,
                Empleado = new Empleado { Id = 2 }, // Ajustado a las propiedades disponibles
                Fecha = new DateTime(2024, 11, 16),
                Estado = true
            };

            var context = new ValidationContext(asistencia);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(asistencia, context, results, true);

            // Assert
            Assert.True(isValid);
            Assert.Empty(results);
        }

        [Fact]
        public void Asistencia_Model_ShouldBeInvalid_WhenEmpleadoIsNull()
        {
            // Arrange
            var asistencia = new Asistencia
            {
                Id = 1,
                EmpleadoId = 2,
                Empleado = null, // Empleado es nulo
                Fecha = new DateTime(2024, 11, 16),
                Estado = true
            };

            var context = new ValidationContext(asistencia);
            var results = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(asistencia, context, results, true);

            // Assert
            Assert.False(isValid); // La validación debe fallar
            Assert.Contains(results, r => r.ErrorMessage.Contains("Empleado")); // Verifica el mensaje de error
        }

    }
}
