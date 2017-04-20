using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharp.test.webdriver.tests.massagetherapy
{
    class MassageTherapyRegistrationSmokeTests
    {
        IWebDriver driver;
        String baseUrl = "http://moncherleo.github.io/";
        const String thankYouMessageText = "Thank You!";

        By firstName = By.XPath(".//input[contains(@id,'first')]");
        By middleName = By.XPath(".//input[contains(@id,'middle')][@type='text']");
        By lastName = By.XPath(".//*[@data-type='control_fullname']//*[contains(text(),'Last Name')]/preceding-sibling::input");
        By streetAddress = By.XPath(".//*[@class='form-address-table']//*[contains(@name,'addr_line1')]");
        By streetAddressLine2 = By.XPath(".//*[@class='form-address-table']//*[contains(@name,'addr_line2')]");
        By city = By.CssSelector(".form-address-table input[id$='city']");
        By stateProvince = By.CssSelector(".form-address-table .form-address-state");
        By postalZipCode = By.CssSelector(".form-address-table .form-address-postal");
        By countryDDL = By.CssSelector(".form-address-table .form-address-country");
        By submitButton = By.CssSelector("*[type='submit']");
        By thankYouMessage = By.XPath(@".//span[contains(text(),'" + thankYouMessageText + "')]");

        [SetUp]
        public void SetUp() {
            /*
            var options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(options);
            */
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
        }

        [TearDown]
        public void TearDown() {
            driver.Quit();
        }

        [Test]
        public void FullNameWithAddressPositiveTest() {
            driver.FindElement(firstName).SendKeys("Maxim");
            driver.FindElement(middleName).SendKeys("Mihalych");
            driver.FindElement(lastName).SendKeys("Makhnyk");
            driver.FindElement(streetAddress).SendKeys("Mayakovskogo str.");
            driver.FindElement(streetAddressLine2).SendKeys("91");
            driver.FindElement(city).SendKeys("Kiev");
            driver.FindElement(stateProvince).SendKeys("Kievskaya");
            driver.FindElement(postalZipCode).SendKeys("02232");

            IWebElement select = driver.FindElement(countryDDL);
            SelectElement dropdown = new SelectElement(driver.FindElement(countryDDL));
            dropdown.SelectByText("Ukraine");

            driver.FindElement(submitButton).Click();

            Assert.AreEqual(thankYouMessageText, driver.FindElement(thankYouMessage).Text);

        }


    }
}
