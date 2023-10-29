using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Sheema_1automation.pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheema_1automation.Tests
{
    internal class Login_Test
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        [TestCase]
          public void TestLogin()
        {
          Home_Page home_Page = new Home_Page();
            home_Page.EnterUsername("sheemaroshini50465@gmail.com");
            home_Page.EnterPassword("1234");
            home_Page.ClickLoginButton();

        }

    }
}






  
    
