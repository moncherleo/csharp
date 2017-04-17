using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.pageobject
{
    public abstract class AbstractPage
    {
        protected IWebDriver driver;

        public AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void PrintText(String textBoxId, String text) {
            IWebElement textBox = driver.FindElement(By.Id(textBoxId));
            textBox.Clear();
            textBox.SendKeys(text);
        }
        public void Click(String id) {
            IWebElement button = driver.FindElement(By.Id(id));
            button.Click();
        }
    }
}
