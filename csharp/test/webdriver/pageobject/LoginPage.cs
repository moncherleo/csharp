using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.pageobject
{
    public class LoginPage : AbstractPage {
        private String url;

        public LoginPage(String url, IWebDriver driver) 
            : base(driver)
        {
            this.url = url;
        }
        public LoginPage Open()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }
        /*
         * public NewsPage LoginAs(User user)
        {
            PrintText("login", user.GetLogin());
            PrintText("password", user.GetPassword());
            Click("loginBtn");
            return new NewsPage(driver);
        }
        */
    }
}
