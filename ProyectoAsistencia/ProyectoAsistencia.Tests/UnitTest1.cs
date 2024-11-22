using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using ProyectoAsistencia;

namespace ProyectoAsistencia.Tests
{
    public class UnitTest1 : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public UnitTest1(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Get_HomeIndex_ReturnsSuccessStatusCode()
        {
            // Act
            var response = await _client.GetAsync("/");

            // Assert
            response.EnsureSuccessStatusCode(); // Verifica que el código de respuesta sea 2xx
        }

        [Fact]
        public async Task Get_NonExistingPage_ReturnsNotFound()
        {
            // Act
            var response = await _client.GetAsync("/non-existing-page");

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
