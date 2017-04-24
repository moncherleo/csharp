using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.tests.massagetherapyPO.pages
{
    abstract class AbstractPage
    {
        public IWebDriver driver;
        IWebElement webElement;
        public const String baseUrl = "http://moncherleo.github.io/";

        public AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FillInputFieldWith(By fieldLocator, String fieldValue)
        {
            webElement = driver.FindElement(fieldLocator);
            webElement.Clear();
            webElement.SendKeys(fieldValue);
        }
    }
}
