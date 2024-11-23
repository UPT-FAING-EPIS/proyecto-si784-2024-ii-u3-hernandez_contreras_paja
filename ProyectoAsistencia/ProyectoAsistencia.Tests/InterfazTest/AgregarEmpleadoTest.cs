using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using System.Threading;

namespace ProyectoAsistencia.Tests
{
    public class AdminPanelTests : IDisposable
    {
        private readonly IWebDriver driver;

        public AdminPanelTests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Fact]
        public void AgregarYVerEmpleado()
        {
            driver.Navigate().GoToUrl("http://localhost:5273/");
            var adminLink = driver.FindElement(By.LinkText("Administrador"));
            adminLink.Click();
            Thread.Sleep(2000);

            var gestionEmpleadosButton = driver.FindElement(By.LinkText("Gestión de Empleados"));
            gestionEmpleadosButton.Click();
            Thread.Sleep(2000);

            var agregarEmpleadoButton = driver.FindElement(By.LinkText("Agregar Empleado"));
            agregarEmpleadoButton.Click();
            Thread.Sleep(2000);

            var nombreUsuarioInput = driver.FindElement(By.Id("NombreUsuario"));
            var contrasenaInput = driver.FindElement(By.Id("Contraseña"));
            nombreUsuarioInput.SendKeys("nuevoEmpleado");
            contrasenaInput.SendKeys("Contraseña123");

            var guardarButton = driver.FindElement(By.CssSelector("button[type='submit']"));
            guardarButton.Click();
            Thread.Sleep(3000);

            driver.Navigate().GoToUrl("http://localhost:5273/Admin/GestionEmpleados");
            Thread.Sleep(2000);

            var empleadoFila = driver.FindElement(By.XPath("//table/tbody/tr/td[text()='nuevoEmpleado']"));
            Assert.NotNull(empleadoFila);
        }

        public void Dispose()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}
