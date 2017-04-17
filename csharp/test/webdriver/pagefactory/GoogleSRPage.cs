using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.pagefactory
{
    public class GoogleSRPage
    {
        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement searchBox;

        [FindsByAll]
        [FindsBy(How = How.TagName, Using = "input")]
        [FindsBy(How = How.Id, Using = "elementId")]
        public IWebElement thisElement;

        // Will find the element with the ID attribute matching "elementId", then will find
        // a child element with the ID attribute matching "childElementId".
        [FindsBySequence]
        [FindsBy(How = How.Id, Using = "elementId", Priority = 0)]
        [FindsBy(How = How.Id, Using = "childElementId", Priority = 1)]
        public IWebElement thisElement2;


        public void SearchFor(String text)
        {
            searchBox.SendKeys(text);
            searchBox.Submit();
        }
    }
}
