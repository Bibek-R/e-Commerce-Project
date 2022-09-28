using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Practise.POM;
using OpenQA.Selenium.Firefox;

namespace Practise.StepDefinitions
{
    [Binding]
    public class TestCasesStepDefinitions
    {
        IWebDriver s_driver;

        [Given(@"(?i)I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            s_driver = new ChromeDriver();
            s_driver.Url = Environment.GetEnvironmentVariable("url");
        }

        [When(@"I login with '([^']*)' and '([^']*)'")]
        public void WhenILoginWithAnd(string username, string password)
        {
            s_driver.FindElement(By.Id("username")).SendKeys(username);
            s_driver.FindElement(By.Id("password")).SendKeys(password + Keys.Enter);
        }

        [Then(@"(?i)I am logged in")]
        public void ThenIAmLoggedin()
        {
            
            Assert.That(s_driver.Title, Is.EqualTo("My account – Edgewords Shop"), "You are not logged in!");
            Console.WriteLine("You are Logged in!");

        }


        [Given(@"I have a product in the cart")]
        public void GivenIHaveAProductInTheCart()
        {
            s_driver = new FirefoxDriver();
            s_driver.Url = Environment.GetEnvironmentVariable("url");
            MyAccount.DismissNotification(s_driver).Click();
            MyAccount.UsernameTextBox(s_driver).SendKeys(Environment.GetEnvironmentVariable("username"));
            MyAccount.PasswordTextBox(s_driver).SendKeys(Environment.GetEnvironmentVariable("password"));
            Thread.Sleep(1500);
            MyAccount.LoginButton(s_driver).Click();
            Thread.Sleep(1500);
            MyAccount.Shop(s_driver).Click();
            Thread.Sleep(1500);
            Shop.ProductSelection(s_driver).Click();
            Thread.Sleep(1500);
            Products.AddToCart(s_driver).Click();
        }

        [When(@"I click on the cart menu item")]
        public void WhenIClickOnTheCartMenuItem()
        {
            Products.Cart(s_driver).Click();
        }

        [When(@"I enter the coupon")]
        public void WhenIEnterTheCoupon()
        {
            
            Cart.CouponTextBox(s_driver).Click();
            Cart.EnterCoupon(s_driver).SendKeys(Environment.GetEnvironmentVariable("coupon"));
        }



        [Then(@"I can enter the coupon code")]
        public void ThenICanEnterTheCouponCode()
        {
            Cart.ApplyCoupon(s_driver).Click();
            Thread.Sleep(2000);
            string text = s_driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/article/div/div/div[1]/div")).Text;
            Thread.Sleep(3000);
            Assert.IsTrue(text.Contains("Coupon code applied successfully."));
            Console.WriteLine("Coupon code applied successfully.");

        }

        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            s_driver = new ChromeDriver();
            s_driver.Url = Environment.GetEnvironmentVariable("url");
            MyAccount.UsernameTextBox(s_driver).SendKeys(Environment.GetEnvironmentVariable("username"));
            MyAccount.PasswordTextBox(s_driver).SendKeys(Environment.GetEnvironmentVariable("password") + Keys.Enter);
        }

        [When(@"I select the '([^']*)' menu item")]
        public void WhenISelectTheMenuItem(string orders)
        {
            OrderReceivedPage.MyAccountMenuItem(s_driver).Click();
            
        }


        [Then(@"I should be able to see the orders")]
        public void ThenIShouldBeAbleToSeeTheOrders()
        {
            MyAccount.OrdersLink(s_driver).Click();
            //Assert.That(s_driver.FindElement(By.CssSelector(".entry-header")), Is.EqualTo("Orders"), "Unable to see orders.");
        }



    }
}
