using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.tests.massagetherapyPO.pages
{
    class ThankYouPage : AbstractPage
    {
        const String thankYouMessageText = "Thank You!";
        By thankYouMessage = By.XPath(@".//span[contains(text(),'" + thankYouMessageText + "')]");

        public ThankYouPage(IWebDriver driver) : base(driver) { }

        public ThankYouPage AssertConfirmationPageDisplayed() {
            Assert.AreEqual(thankYouMessageText, driver.FindElement(thankYouMessage).Text);
            return this;
        }

        public FormPage ReturnFormPage()
        {
            return new FormPage(driver);
        }
    }
}
