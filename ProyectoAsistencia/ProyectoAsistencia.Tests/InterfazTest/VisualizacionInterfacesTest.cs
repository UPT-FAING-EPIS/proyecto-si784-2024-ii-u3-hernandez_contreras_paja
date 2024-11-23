using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;
using System;

namespace ProyectoAsistencia.Tests
{
    public class VisualizacionInterfacesTest : IDisposable
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public VisualizacionInterfacesTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Fact]
        public void VerInterfaces()
        {
            driver.Navigate().GoToUrl("http://localhost:5273/");
            
            var adminButton = wait.Until(d => d.FindElement(By.LinkText("Panel de Administrador")));
            var asistenciaButton = wait.Until(d => d.FindElement(By.LinkText("Panel de Asistencia")));
            var privacyLink = wait.Until(d => d.FindElement(By.LinkText("Privacy")));

            Assert.NotNull(adminButton);
            Assert.NotNull(asistenciaButton);
            Assert.NotNull(privacyLink);

            adminButton.Click();
            wait.Until(d => d.Url.Contains("/Admin/Dashboard"));
            Assert.Contains("Administrador", driver.PageSource);

            driver.Navigate().Back();
            wait.Until(d => d.Url.Contains("/"));

            asistenciaButton.Click();
            wait.Until(d => d.Url.Contains("/Asistencia"));
            Assert.Contains("Asistencia", driver.PageSource);

            driver.Navigate().Back();
            wait.Until(d => d.Url.Contains("/"));

            privacyLink.Click();
            wait.Until(d => d.Url.Contains("/Home/Privacy"));
            Assert.Contains("Privacy", driver.PageSource);
        }

        public void Dispose()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}