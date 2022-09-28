using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise.POM
{
    internal class Cart
    {
        private static IWebElement s_element;  //private class field

        public static IWebElement CouponTextBox(IWebDriver _driver)  //selects coupon text box
        {
            s_element = _driver.FindElement(By.Id("coupon_code"));
            return s_element;
        }
        public static IWebElement EnterCoupon(IWebDriver _driver) //returns coupon text box to enter the code
        {
            s_element = _driver.FindElement(By.Id("coupon_code"));
            return s_element;
        }
        public static IWebElement ApplyCoupon(IWebDriver _driver) //applies the code after it has been clicked
        {
            s_element = _driver.FindElement(By.Name("apply_coupon"));
            return s_element;
        }
        public static IWebElement MyAccountMenuItem(IWebDriver _driver) // navigates to myaccount page after clicking
        {
            s_element = _driver.FindElement(By.LinkText("My account"));
            return s_element;
        }
        public static IWebElement EmptyCart(IWebDriver _driver) //empties the cart when clicked
        {
            s_element = _driver.FindElement(By.ClassName("remove"));
            return s_element;
        }
        public static IWebElement RemoveCoupon(IWebDriver _driver) //remove coupon when clicked
        {
            s_element = _driver.FindElement(By.ClassName("woocommerce-remove-coupon"));
            return s_element;
        }
        public static IWebElement ProceedToCheckout(IWebDriver _driver) //navigates to checkout page when clicked
        {
            s_element = _driver.FindElement(By.LinkText("Proceed to checkout"));
            return s_element;
        }
        public static int GetDiscount(IWebDriver _driver) //calculates discount percentage
        {
            // extract the values for sub total, shipping, and total from the webpage and assign them to string type variable. the "Text[1..]" removes the "£" symbol from the text that FindElement would have extracted  
            string subTotalExtract = _driver.FindElement(By.CssSelector(".cart-subtotal>td:nth-child(2)>span:nth-child(1)>bdi:nth-child(1)")).Text[1..];
            string shippingExtract = _driver.FindElement(By.CssSelector("#shipping_method>li:nth-child(1)>label:nth-child(2)>span:nth-child(1)>bdi:nth-child(1)")).Text[1..];
            string totalExtract = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/article/div/div/div[2]/div/table/tbody/tr[4]/td")).Text[1..];

            //// parsing the string values, that were extracted above, into float 
            float _subTotal = float.Parse(subTotalExtract);
            float _shipping = float.Parse(shippingExtract);
            float _total = float.Parse(totalExtract);
            int _discount = (int)((_subTotal + _shipping - _total) / _subTotal * 100);
            return _discount;
        }

        public static string DiscountText(int _discount)  //returns a string message after discount calculation
        {
            return _discount.ToString() + "% discount is applied.";
        }

    }
}
