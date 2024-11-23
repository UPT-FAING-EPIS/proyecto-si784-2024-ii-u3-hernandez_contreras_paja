using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using TechTalk.SpecFlow;
using XunitAssert = Xunit.Assert;
using NUnitAssert = NUnit.Framework.Assert;


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

        [When(@"realizo una petición POST a ""(.*)"" con datos (.*)")]
        public async Task CuandoRealizoUnaPeticionPOSTA(string url, string dataStatus)
        {
            var content = dataStatus == "válidos" ? new StringContent("{\"key\":\"value\"}") : new StringContent("{}");
            _response = await _client.PostAsync(url, content);
        }

        [When(@"realizo una petición DELETE a ""(.*)""")]
        public async Task CuandoRealizoUnaPeticionDELETEA(string url)
        {
            _response = await _client.DeleteAsync(url);
        }

        [When(@"realizo una petición PUT a ""(.*)"" con datos válidos")]
        public async Task CuandoRealizoUnaPeticionPUTA(string url)
        {
            var content = new StringContent("{\"key\":\"updated value\"}");
            _response = await _client.PutAsync(url, content);
        }

        [Then(@"obtengo un código de respuesta exitoso")]
        public void EntoncesObtengoUnCodigoDeRespuestaExitoso()
        {
            XunitAssert.True(_response.IsSuccessStatusCode, "La respuesta no es exitosa.");
        }

        [Then(@"obtengo un código de respuesta (.*)")]
        public void EntoncesObtengoUnCodigoDeRespuesta(int expectedStatusCode)
        {
            XunitAssert.Equal(expectedStatusCode, (int)_response.StatusCode);
        }

    }
}
