using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharp.test.webdriver
{
    [TestFixture]
    class BaseTest
    {
        IWebDriver driver;
        String baseUrl = "https://google.com/";
        

        [SetUp]
        public void SetUp() {
            /*
            var options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(options);
            */
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown() {
            driver.Quit();
        }

        [Test]
        public void MySeleniumTest() {
            //driver.Navigate().GoToUrl(baseUrl + "search?q=cheese");
            driver.Navigate().GoToUrl(baseUrl);
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("Cheese");
            query.Submit();
            Thread.Sleep(10000); //dangerous hack
            ReadOnlyCollection<IWebElement> webElements;
            webElements = driver.FindElements(By.CssSelector(".r>a"));
            Assert.True(webElements.Count > 0);

        }
    }
}
