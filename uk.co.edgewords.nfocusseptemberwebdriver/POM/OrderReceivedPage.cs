using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Practise.POM
{
    internal class OrderReceivedPage
    {
        IWebDriver driver;

        public OrderReceivedPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement myAccountMenuItem => driver.FindElement(By.LinkText("My account"));

        public void MyAccountMenuItem()
        {
            myAccountMenuItem.Click();
        }
  
    }
}
