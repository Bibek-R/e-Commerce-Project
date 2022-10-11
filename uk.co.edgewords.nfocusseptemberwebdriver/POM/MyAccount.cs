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
          IWebDriver driver; //Field for service methods to use

        public MyAccount(IWebDriver driver)
        {
            this.driver = driver;
        }



       

       IWebElement shop => driver.FindElement(By.LinkText("Shop"));
       IWebElement usernameTextBox => driver.FindElement(By.Id("username"));
       IWebElement passwordTextBox => driver.FindElement(By.Id("password"));
       IWebElement checkoutMenuItem => driver.FindElement(By.LinkText("Checkout"));
       IWebElement loginButton => driver.FindElement(By.Name("login"));
       IWebElement ordersLink => driver.FindElement(By.LinkText("Orders"));
       IWebElement logoutButton => driver.FindElement(By.LinkText("Logout"));
     

        public void ShopPage()
        {
            shop.Click();
        }

        public void UsernameTextBox(string username)
        {
            usernameTextBox.SendKeys(username);
        }

        public void PasswordTextBox(string password)
        {
            passwordTextBox.SendKeys(password);
        }

        public void CheckOutMenuItem()
        {
            checkoutMenuItem.Click();
        }
        public void LoginButton()
        {
            loginButton.Click();
        }
        public void Orders()
        {
            ordersLink.Click();
        }
        public void LogoutButton()
        {
            logoutButton.Click();
        }

       


        //Constructor to get driver from test for use in this class
        //public MyAccount(IWebDriver s_driver)

        //{
        //    this.s_driver = s_driver;
        //}

        //Locators

        //IWebElement usernameField => s_driver.FindElement(By.Id("username")); 

        //Service methods

        //public void SetUsername(string username)
        //{

        //    usernameField.SendKeys(username);
        //}

        //private class field
        //private static IWebElement s_element = null;


        //public static IWebElement UsernameTextBox(IWebDriver _driver) //selects username text box when clicked.

        //{
        //    s_element = _driver.FindElement(By.Id("username"));

        //    return s_element;
        //}
        //public static IWebElement Shop(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.LinkText("Shop"));
        //    return s_element;
        //}

        //public static IWebElement DismissNotification(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.CssSelector(".woocommerce-store-notice__dismiss-link"));
        //    return s_element;
        //}

        //public static IWebElement PasswordTextBox(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.Id("password"));
        //    return s_element;
        //}

        //public static IWebElement LoginButton(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.Name("login"));
        //    return s_element;

        //}

        //public static IWebElement CheckoutMenuItem(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.LinkText("Checkout"));
        //    return s_element;

        //}
        //public static IWebElement OrdersLink(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.LinkText("Orders"));
        //    return s_element;

        //}


        //public static IWebElement LogoutButton(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.LinkText("Logout"));
        //    return s_element;

        //}
    }
}
