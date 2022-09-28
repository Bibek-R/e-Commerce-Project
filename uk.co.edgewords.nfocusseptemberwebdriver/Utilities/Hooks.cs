using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace Practise.Utilities
{
    internal class Hooks
    {
        public static IWebDriver s_driver;

        [SetUp]
        public void Setup()
        { 
                s_driver = new FirefoxDriver();
                s_driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            //driver.Close(); //Close current tab
            // Wait 3s to check everything worked
            s_driver.Quit(); //Close all tabs, windows for session, closes webdriver session.
        }
    }
}
