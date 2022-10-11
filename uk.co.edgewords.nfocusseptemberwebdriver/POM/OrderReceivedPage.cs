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
        //private static IWebElement s_element; //private field
        //public static IWebElement GetOrderNo(IWebDriver _driver) //retrieve order no after placing order
        //{
        //    s_element = _driver.FindElement(By.CssSelector(".woocommerce-order-overview__order > strong:nth-child(1)"));
        //    return s_element;
        //}
        //public static IWebElement MyAccountMenuItem(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.LinkText("My account"));
        //    return s_element;
        //}
    }
}
