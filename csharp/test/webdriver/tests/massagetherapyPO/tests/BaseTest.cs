using csharp.test.webdriver.tests.massagetherapyPO.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.tests.massagetherapyPO.tests
{
    class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            /*
            var options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(options);
            */
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(AbstractPage.baseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
