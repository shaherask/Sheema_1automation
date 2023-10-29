using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheema_1automation.pages
{
    internal class Home_Page
    {
        public IWebDriver driver;
        public By Loginbutton = By.XPath("//button[@id='u_0_5_le']");
        //PublicWebElement LoginButton { get; set; } = Loginbutton;
        public By email = By.XPath("//input[@id='username");
        public By Password = By.XPath("//input[@id='pass']");

        public void EnterUsername(string username)
        {
            driver.FindElement(email).SendKeys(username);
        }

        public void EnterPassword(string uniquepassword)
        {
            driver.FindElement(Password).SendKeys(uniquepassword);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(Loginbutton).Click();
        }

    }
}
