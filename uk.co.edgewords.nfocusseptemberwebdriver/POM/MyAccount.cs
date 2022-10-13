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

        //Constructor to get driver from test for use in the class
        public MyAccount(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locators
       IWebElement shop => driver.FindElement(By.LinkText("Shop"));
       IWebElement usernameTextBox => driver.FindElement(By.Id("username"));
       IWebElement passwordTextBox => driver.FindElement(By.Id("password"));
       IWebElement checkoutMenuItem => driver.FindElement(By.LinkText("Checkout"));
       IWebElement loginButton => driver.FindElement(By.Name("login"));
       IWebElement ordersLink => driver.FindElement(By.LinkText("Orders"));
       IWebElement logoutButton => driver.FindElement(By.LinkText("Logout"));
       IWebElement navigationMenu => driver.FindElement(By.ClassName("woocommerce-MyAccount-navigation"));
       IWebElement ordersTable => driver.FindElement(By.CssSelector(".woocommerce-orders-table"));


        //Service Methods
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
        public void OrdersMenuItem()
        {
            ordersLink.Click();
        }
        public void LogoutButton()
        {
            logoutButton.Click();
        }

       public bool IsNavigationMenuExist()
        {
            return navigationMenu.Displayed;
        }
        public bool IsOrdersTableExist()
        {
            return ordersTable.Displayed;
        }

    }
}
