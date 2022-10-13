using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise.POM
{
    internal class Products
    {
        IWebDriver driver;   //Field for service methods to use


        //Constructor to get driver from test for use in the class
        public Products(IWebDriver driver)
        {
            this.driver = driver;
        }


        //Locators
        IWebElement addToCart => driver.FindElement(By.Name("add-to-cart"));
        IWebElement cart => driver.FindElement(By.LinkText("Cart"));


        //Service Methods
        public void AddToCart()
        {
            addToCart.Click();
        }

        public void CartMenuItem()
        {
            cart.Click();
        }

    }
}
