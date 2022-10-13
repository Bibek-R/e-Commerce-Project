using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Practise.POM
{
    internal class Shop  
    {
        IWebDriver driver;  //Field for service methods to use


        //Constructor to get driver from test for use in the class
        public Shop(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locator
        IWebElement productSelection => driver.FindElement(By.CssSelector("li.product:nth-child(3)"));


        //Service Method
        public void ProductSelection()
        {
            productSelection.Click();
        }

    }
}
