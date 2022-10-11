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
      
        //private static IWebElement s_element; //private class field

        //public static IWebElement FirstName(IWebDriver _driver) //selects the first name textbox when clicked
        //{
        //    s_element = _driver.FindElement(By.Name("billing_first_name"));
        //    return s_element;
        //}
        //public static IWebElement LastName(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.Name("billing_last_name"));
        //    return s_element;
        //}
        //public static IWebElement StreetAddress(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.Name("billing_address_1"));
        //    return s_element;
        //}
        //public static IWebElement Town(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.Name("billing_city"));
        //    return s_element;
        //}
        //public static IWebElement Postcode(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.Name("billing_postcode"));
        //    return s_element;
        //}
        //public static IWebElement Phone(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.Name("billing_phone"));
        //    return s_element;
        //}
        //public static IWebElement Email(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.Name("billing_email"));
        //    return s_element;
        //}
        //public static IWebElement PaymentMethod(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.CssSelector("li.wc_payment_method:nth-child(1)>label:nth-child(2)"));
        //    return s_element;
        //}
        //public static IWebElement PlaceOrder(IWebDriver _driver)
        //{
        //    s_element = _driver.FindElement(By.Name("woocommerce_checkout_place_order"));
        //    return s_element;
        //}

    }
}
