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
        IWebDriver driver;

        public Products(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement addToCart => driver.FindElement(By.Name("add-to-cart"));
        IWebElement cart => driver.FindElement(By.LinkText("Cart"));


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
