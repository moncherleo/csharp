using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

        public void SetValueToTextField(String value, By locator)
        {
            webElement = driver.FindElement(locator);
            webElement.Clear();
            webElement.SendKeys(value);
            Assert.AreEqual(value, webElement.GetAttribute("value"));
        }

        public void SelectTextFromDropDownList(String value, By listLocator) {
            IWebElement select = driver.FindElement(listLocator);
            SelectElement dropdown = new SelectElement(select);
            dropdown.SelectByText(value);
            Assert.AreEqual(value, dropdown.SelectedOption.GetAttribute("value"));
        }

        public void ClickOn(By element)
        {
            driver.FindElement(element).Click();
        }
    }
}
