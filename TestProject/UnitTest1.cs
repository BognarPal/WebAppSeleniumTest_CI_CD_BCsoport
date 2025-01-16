using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace TestProject
{
    public class Tests
    {
        IWebDriver driver;
        //Environment.GetEnvironmentVariable("windir");

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            driver = new RemoteWebDriver(
                new Uri("http://localhost:4444/wd/hub"),
                options.ToCapabilities()
            );
        }

        [Test]
        public void TitleOfPage()
        {
            driver.Navigate().GoToUrl("http://project-to-test/index.html");
            Assert.That(driver.Title, Is.EqualTo("Test website"));
        }

        [Test]
        public void ButtonsExists()
        {
            driver.Navigate().GoToUrl("http://project-to-test/index.html");
            var buttons = driver.FindElements(By.CssSelector("button[target-color]"));
            Assert.That(buttons.Count(), Is.EqualTo(4));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}