using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.old.approach
{
    public abstract class WebDriverTestBase
    {
        protected IWebDriver driver;
        protected String baseURL = "http://localhost:8080/";

        [SetUp]
        public void SetUp()
        {
            var options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(options);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
