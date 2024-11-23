using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using System;
using System.Threading;

namespace ProyectoAsistencia.Tests
{
    public class AdminPanelTestsEmpleados : IDisposable
    {
        private readonly IWebDriver driver;

        public AdminPanelTestsEmpleados()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Fact]
        public void GestionDeEmpleadosAsistenciasYHistorial()
        {
            driver.Navigate().GoToUrl("http://localhost:5273/");
            
            var adminLink = driver.FindElement(By.LinkText("Administrador"));
            adminLink.Click();
            Thread.Sleep(2000);

            var gestionEmpleadosButton = driver.FindElement(By.LinkText("Gestión de Empleados"));
            gestionEmpleadosButton.Click();
            Thread.Sleep(2000);

            var gestionEmpleadosTitulo = driver.FindElement(By.TagName("h2"));
            Assert.Contains("Gestión de Empleados", gestionEmpleadosTitulo.Text);

            var regresarAdminLink = driver.FindElement(By.LinkText("Administrador"));
            regresarAdminLink.Click();
            Thread.Sleep(2000);

            var gestionAsistenciasButton = driver.FindElement(By.LinkText("Gestión de Asistencias"));
            gestionAsistenciasButton.Click();
            Thread.Sleep(2000);

            var gestionAsistenciasTitulo = driver.FindElement(By.TagName("h2"));
            Assert.Contains("Gestión de Asistencias", gestionAsistenciasTitulo.Text);

            driver.Navigate().GoToUrl("http://localhost:5273/Admin/Dashboard");
            Thread.Sleep(2000);

            var historialCambiosButton = driver.FindElement(By.LinkText("Historial de Cambios"));
            historialCambiosButton.Click();
            Thread.Sleep(2000);

            var historialCambiosTitulo = driver.FindElement(By.TagName("h2"));
            Assert.Contains("Historial de Cambios", historialCambiosTitulo.Text);

            driver.Navigate().GoToUrl("http://localhost:5273/Admin/Dashboard");
        }

        public void Dispose()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}
