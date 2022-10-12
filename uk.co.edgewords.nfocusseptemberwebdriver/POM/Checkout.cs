using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Practise.POM
{
    internal class Checkout
    {
        IWebDriver driver;

        public Checkout(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locators

        IWebElement firstName => driver.FindElement(By.Name("billing_first_name"));
        IWebElement lastName => driver.FindElement(By.Name("billing_last_name"));
        IWebElement streetAddress => driver.FindElement(By.Name("billing_address_1"));
        IWebElement town => driver.FindElement(By.Name("billing_city"));
        IWebElement postcode => driver.FindElement(By.Name("billing_postcode"));
        IWebElement phone => driver.FindElement(By.Name("billing_phone"));
        IWebElement paymentMethod => driver.FindElement(By.CssSelector("li.wc_payment_method:nth-child(1)>label:nth-child(2)"));
        IWebElement placeOrder => driver.FindElement(By.Name("woocommerce_checkout_place_order"));

        //Service Methods

        public void FirstName()
        {
          firstName.Click();
        }
        public void LastName()
        {
            lastName.Click();
        }
        public void StreetAddress()
        {
            streetAddress.Click();
        }
        public void Town()
        {
            town.Click();
        }
        public void Postcode()
        {
            postcode.Click();
        }
        public void Phone()
        {
            phone.Click();
        }
        public void PaymentMethod()
        {
            paymentMethod.Click();
        }
        public void PlaceOrder()
        {
            placeOrder.Click();
        }

    }
}
