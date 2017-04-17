using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.pageobject
{
    public class NewsPage : AbstractPage
    {
        public NewsPage(IWebDriver driver)
            : base(driver)
        {

        }
        public NewsPage AssertPostsCount(int count)
        {
            ReadOnlyCollection<IWebElement> posts = driver.FindElements(By.ClassName("post"));
            Assert.AreEqual(count, posts.Count);
            return this;
        }
        /*
        public NewsPage AddPost(Post post)
        {
            PrintText("title", post.getTitle());
            PrintText("text", post.getText());
            Click("addPostBtn"); return this;
        }
        */
    }

}
