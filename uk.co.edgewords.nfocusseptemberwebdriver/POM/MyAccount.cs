using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Practise.POM
{
    internal class MyAccount
    {
        //private class field
        private static IWebElement s_element = null;


        public static IWebElement UsernameTextBox(IWebDriver _driver) //selects username text box when clicked.
            
        {
            s_element = _driver.FindElement(By.Id("username"));
            return s_element;
        }
        public static IWebElement Shop(IWebDriver _driver)
        {
            s_element = _driver.FindElement(By.LinkText("Shop"));
            return s_element;
        }

        public static IWebElement DismissNotification(IWebDriver _driver)
        {
            s_element = _driver.FindElement(By.CssSelector(".woocommerce-store-notice__dismiss-link"));
            return s_element;
        }

        public static IWebElement PasswordTextBox(IWebDriver _driver)
        {
            s_element = _driver.FindElement(By.Id("password"));
            return s_element;
        }

        public static IWebElement LoginButton(IWebDriver _driver)
        {
            s_element = _driver.FindElement(By.Name("login"));
            return s_element;

        }

        public static IWebElement CheckoutMenuItem(IWebDriver _driver)
        {
            s_element = _driver.FindElement(By.LinkText("Checkout"));
            return s_element;

        }
        public static IWebElement OrdersLink(IWebDriver _driver)
        {
            s_element = _driver.FindElement(By.LinkText("Orders"));
            return s_element;

        }


        public static IWebElement LogoutButton(IWebDriver _driver)
        {
            s_element = _driver.FindElement(By.LinkText("Logout"));
            return s_element;

        }
    }
}
