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
        IWebDriver driver;  //Field for service methods to use


        //Constructor to get driver from test for use in the class
        public OrderReceivedPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locator
        IWebElement myAccountMenuItem => driver.FindElement(By.LinkText("My account"));


        //Service Method
        public void MyAccountMenuItem()
        {
            myAccountMenuItem.Click();
        }
  
    }
}
