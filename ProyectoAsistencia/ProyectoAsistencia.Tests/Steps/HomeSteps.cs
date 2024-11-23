using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using TechTalk.SpecFlow;
using ProyectoAsistencia;


namespace ProyectoAsistencia.Tests.Steps
{
    [Binding]
    public class HomeSteps
    {
        private readonly WebApplicationFactory<Program> _factory;
        private HttpClient _client;
        private HttpResponseMessage _response;

        public HomeSteps(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Given(@"estoy en el cliente HTTP")]
        public void DadoEstoyEnElClienteHTTP()
        {
            _client = _factory.CreateClient();
        }

        [When(@"realizo una petición GET a ""(.*)""")]
        public async Task CuandoRealizoUnaPeticionGETA(string url)
        {
            _response = await _client.GetAsync(url);
        }

        [Then(@"obtengo un código de respuesta exitoso")]
        public void EntoncesObtengoUnCodigoDeRespuestaExitoso()
        {
            NUnit.Framework.Assert.IsTrue(_response.IsSuccessStatusCode, "La respuesta no es exitosa");
        }

        [Then(@"obtengo un código de respuesta (.*)")]
        public void EntoncesObtengoUnCodigoDeRespuesta(int expectedStatusCode)
        {
            NUnit.Framework.Assert.AreEqual(expectedStatusCode, (int)_response.StatusCode, "El código de respuesta no coincide");
        }
    }
}
