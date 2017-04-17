using csharp.test.webdriver.tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace csharp.test.webdriver.pagefactory
{
    class GoogleSRPageTest : BasePOTest
    {
        [Test]
        public void searchForQ()
        {
            driver.Navigate().GoToUrl(baseUrl);
            GoogleSRPage googleSRPage = new GoogleSRPage();
            PageFactory.InitElements(driver, googleSRPage);
            googleSRPage.SearchFor("Cheese");
            Thread.Sleep(10000);

            /*Fluent wait below */
            By element0 = By.Id("colorVar");
            var wait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(45),
                Message = "Dude, where's my element?",
                PollingInterval = TimeSpan.FromMilliseconds(250)
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            var myElement = wait.Until(ExpectedConditions.ElementIsVisible(element0));

            /* Custom wait below */

            IWebElement element = driver.FindElement(By.Id("colorVar"));
            DefaultWait<IWebElement> wait2 = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromMinutes(2);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);

            Func<IWebElement, bool> waiter = new Func<IWebElement, bool>((IWebElement ele) =>
            {
                String styleAttrib = element.GetAttribute("style");
                if (styleAttrib.Contains("red"))
                {
                    return true;
                }
                Console.WriteLine("Color is still " + styleAttrib);
                return false;
            });
            wait2.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait2.Until(waiter);
        }
    }
}
