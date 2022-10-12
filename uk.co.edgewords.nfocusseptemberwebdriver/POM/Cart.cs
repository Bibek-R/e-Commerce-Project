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
        IWebDriver driver; //Field for service methods to use

        //Constructor to get driver from test for use in the class

        public Cart(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locators

        IWebElement couponTextBox => driver.FindElement(By.Id("coupon_code"));
        IWebElement enterCoupon => driver.FindElement(By.Id("coupon_code"));
        IWebElement applyCoupon => driver.FindElement(By.Name("apply_coupon"));
        IWebElement myAccountMenuItem => driver.FindElement(By.LinkText("My account"));
        IWebElement emptyCart => driver.FindElement(By.ClassName("remove"));
        IWebElement removeCoupon => driver.FindElement(By.ClassName("woocommerce-remove-coupon"));
        IWebElement proceedToCheckout => driver.FindElement(By.LinkText("Proceed to checkout"));

        // extract the values for sub total, shipping, and total from the webpage and assign them to string type variable. the "Text[1..]" removes the "£" symbol from the text that FindElement would have extracted  
        string subTotalExtract => driver.FindElement(By.CssSelector(".cart-subtotal>td:nth-child(2)>span:nth-child(1)>bdi:nth-child(1)")).Text[1..];
        
        string discountAmount => driver.FindElement(By.CssSelector("#post-5 > div > div > div.cart-collaterals > div > table > tbody > tr.cart-discount.coupon-edgewords > td > span")).Text[1..];


        //Service Methods
        public decimal GetDiscountAmount()
        {
            return decimal.Parse(discountAmount);
        }
        public decimal GetSubTotalExtract()
        {
          return decimal.Parse(subTotalExtract);
        }
        
        public void SelectCouponTextBox()   //
        {
            couponTextBox.Click();
        }

        public void EnterCoupon()
        {
            enterCoupon.SendKeys("edgewords");
        }

        public void ApplyCoupon()
        {
            applyCoupon.Click();
        }

        public void MyAccountMenuItem()
        {
            myAccountMenuItem.Click();
        }

        public void EmptyCart()
        {
           emptyCart.Click();
        }

        public void RemoveCoupon()
        {
           removeCoupon.Click();
        }
        public void ProceedToCheckout()
        {
          proceedToCheckout.Click();
        }

        //calculates discount percentage
        public decimal GetDiscount(decimal subTotalExtract, decimal discountAmount) 
        {
            decimal _discount = (discountAmount / subTotalExtract) * 100;
            return _discount;

        }

    }
}
