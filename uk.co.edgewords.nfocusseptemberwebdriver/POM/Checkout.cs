using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace Practise.POM
{
    internal class Checkout
    {
        IWebDriver driver;  //Field for service methods to use

        //Constructor to get driver from test for use in the class
        public Checkout(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locators

        IWebElement _setfirstName => driver.FindElement(By.Name("billing_first_name"));
        IWebElement _setlastName => driver.FindElement(By.Name("billing_last_name"));
        IWebElement _setstreetAddress => driver.FindElement(By.Name("billing_address_1"));
        IWebElement _setTown => driver.FindElement(By.Name("billing_city"));
        IWebElement _setPostcode => driver.FindElement(By.Name("billing_postcode"));
        IWebElement _setPhone => driver.FindElement(By.Name("billing_phone"));
        IWebElement paymentMethod => driver.FindElement(By.CssSelector(".payment_method_cheque.wc_payment_method > label"));
        IWebElement placeOrder => driver.FindElement(By.Id("place_order"));
        IWebElement _setEmail => driver.FindElement(By.Name("billing_email"));
        IWebElement cashonDelivery => driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[1]/main/article/div/div/form[2]/div[2]/div/ul/li[2]/label"));


        //Service Methods

        public Checkout setfirstName(string value)  //Method to set FirstName
        {
            _setfirstName.Clear();
            _setfirstName.SendKeys(value);
            return this;

        }
        public Checkout setlastName(string value)   //Method to set LastName
        {
            _setlastName.Clear();
            _setlastName.SendKeys(value);
            return this;

        }
        public Checkout setstreetAddress(string value)   //Method to set Address
        {
            _setstreetAddress.Clear();
            _setstreetAddress.SendKeys(value);
            return this;

        }
        public Checkout setTown(string value)      //Method to set Town
        {
            _setTown.Clear();
            _setTown.SendKeys(value);
            return this;

        }
        public Checkout setPostcode(string value)    //Method to set Postcode
        {
            _setPostcode.Clear();
            _setPostcode.SendKeys(value);
            return this;

        }
        public Checkout setPhone(string value)     //Method to set Phone number
        {
            _setPhone.Clear();
            _setPhone.SendKeys(value);
            return this;

        }
        public Checkout setEmail(string value)    //Method to set the email
        {
            _setEmail.Clear();
            _setEmail.SendKeys(value);
            return this;

        }

        //method to get checkout information
        public void details(string firstname, string lastname, string address, string town, string postcode, string phone, string email)
        {
            setfirstName(firstname);
            setlastName(lastname);
            setstreetAddress(address);
            setTown(town);
            setPostcode(postcode);
            setPhone(phone);
            setEmail(email);
        }    
        

        public void PaymentMethod()      //method to select the payment method
        {
            paymentMethod.Click();
        }
        public void PlaceOrder()    //method to place order
        {
            placeOrder.Click();
        }

        public void CashOnDelivery()
        {
            cashonDelivery.Click();
        }
    }
}
