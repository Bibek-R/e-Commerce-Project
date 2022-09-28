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
        private static IWebElement s_element;

        public static IWebElement AddToCart(IWebDriver _driver)//add this product to cart
        {
            s_element = _driver.FindElement(By.Name("add-to-cart"));
            return s_element;
        }
        public static IWebElement Cart(IWebDriver _driver)//navigates to cart page
        {
            s_element = _driver.FindElement(By.LinkText("Cart"));
            return s_element;
        }
    }
}
