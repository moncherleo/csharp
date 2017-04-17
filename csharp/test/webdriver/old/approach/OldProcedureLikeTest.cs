using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.old.approach
{
    class OldProcedureLikeTest : WebDriverTestBase
    {
        public const String ADMIN_LOGIN = "admin";    
        public const String ADMIN_PASSWORD = "123456";

        [Test]
        public void testCreatePost() {
            driver.Navigate().GoToUrl(baseURL);
            AddPost("Post Title", "Post Text");
        }

        public void AddPost(String title, String text)
        {
            driver.FindElement(By.Id(title)).SendKeys(title);
            driver.FindElement(By.Id(title)).SendKeys(text);
            driver.FindElement(By.Id("addPostBtn")).Click();
        }

    }
}
