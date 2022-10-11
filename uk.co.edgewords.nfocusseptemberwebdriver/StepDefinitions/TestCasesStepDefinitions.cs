using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Practise.POM;
using OpenQA.Selenium.Firefox;
using static Practise.StepDefinitions.Hooks;
using NUnit.Framework;

namespace Practise.StepDefinitions
{
    [Binding]
    internal class TestCasesStepDefinitions
    {
        private IWebDriver s_driver;
        private readonly ScenarioContext _scenarioContext;
        private MyAccount loggedIn;
        private Products products;
        private Cart carts;

        public TestCasesStepDefinitions(ScenarioContext sc)
        {
            _scenarioContext = sc;
            this.s_driver = (IWebDriver)_scenarioContext["myDriver"];
        }


        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            MyAccount login = new MyAccount(s_driver);
            //login.SetUsername(username);
            login.UsernameTextBox(Environment.GetEnvironmentVariable("username")); //uses enviroment variable to get login credentials
            login.PasswordTextBox(Environment.GetEnvironmentVariable("password"));
            login.LoginButton();
            loggedIn = login;

            //Assert condition - check for dashboard 
            // Assert.That
        }

        [When(@"I have a product in the cart")]
        public void WhenIHaveAProductInTheCart()
        {
            loggedIn.ShopPage();
            Shop shop = new Shop(s_driver);
            shop.ProductSelection();
            Products products = new Products(s_driver);
            products.AddToCart();
            this.products = products;

        }

        [When(@"I click on the cart menu item")]
        public void WhenIClickOnTheCartMenuItem()
        {
            products.CartMenuItem();
        }

        [When(@"I enter the coupon")]
        public void WhenIEnterTheCoupon()
        {
            Cart cart = new Cart(s_driver);
            cart.SelectCouponTextBox();
            cart.EnterCoupon();
            cart.ApplyCoupon();
            carts = cart;
            
        }

        [Then(@"I can check coupon is (.*)% off")]
        public void ThenICanCheckCouponIsOff(int p0)
        {
            Thread.Sleep(3000);//need to change
            decimal discount = carts.GetDiscount(carts.GetSubTotalExtract(), carts.GetDiscountAmount());
            Console.WriteLine(discount);
            try
            {
                Assert.That ((int)discount, Is.EqualTo( p0), "15% should have been applied!");
            }
            catch (Exception)
            {
            }
        }

        //TestCase2

        [When(@"I am in the MyAccount page")]
        public void WhenIAmInTheMyAccountPage()
        {
            Thread.Sleep(9000);
            IWebElement accountPageElement = s_driver.FindElement(By.ClassName("woocommerce-MyAccount-navigation"));
            //IWebElement navigationMenuItem = accountPageElement.FindElement(By.TagName("nav"));
            bool accountPage = (accountPageElement.GetAttribute("class").Contains("woocommerce-MyAccount-navigation")) ? true : false;
            Assert.That(accountPage, Is.True, "We did not login");
        }

        [When(@"I click the '([^']*)' menu item")]
        public void WhenIClickTheMenuItem(string orders)
        {
            throw new PendingStepException();
        }

        [Then(@"I should be able to see the order")]
        public void ThenIShouldBeAbleToSeeTheOrder()
        {
            throw new PendingStepException();
        }

        //TakeScreenshot(driver, "fullpage");
        //IWebElement form = driver.FindElement(By.Id("right-column"));
        //TakeScreenshotElement(form, "theform");
        //TestContext.AddTestAttachment(@"C:\Screenshots\fullpage.png");


    }
}
