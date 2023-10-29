using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheema_1automation.utilities
{
    internal class Utilities
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

    }
}

