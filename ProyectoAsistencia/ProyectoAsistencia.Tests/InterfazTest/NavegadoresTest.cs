using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Xunit;
using System;

namespace ProyectoAsistencia.Tests
{
    public class WebDriverFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        public void InitializeDriver(string navegador)
        {
            Driver?.Quit();
            Driver = navegador switch
            {
                "Chrome" => new ChromeDriver(),
                "Edge" => new EdgeDriver(),
                "Firefox" => new FirefoxDriver(),
                _ => throw new ArgumentException("Navegador no soportado")
            };
        }

        public void Dispose()
        {
            Driver?.Quit();
            Driver?.Dispose();
        }
    }

    public class NavegadoresTest : IClassFixture<WebDriverFixture>, IDisposable
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private readonly WebDriverFixture fixture;

        public NavegadoresTest(WebDriverFixture fixture)
        {
            this.fixture = fixture;
        }

        [Theory]
        [InlineData("Chrome")]
        [InlineData("Edge")]
        [InlineData("Firefox")]
        public void VerInterfaces(string navegador)
        {
            fixture.InitializeDriver(navegador);
            driver = fixture.Driver;
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

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
            fixture.Dispose();
        }
    }
}
