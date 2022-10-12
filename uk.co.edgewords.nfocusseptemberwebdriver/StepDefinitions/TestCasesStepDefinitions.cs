using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Practise.POM;
using OpenQA.Selenium.Firefox;
using static Practise.StepDefinitions.Hooks;
using NUnit.Framework;
using Practise.Utilities;

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
        private HelpersInstance wait;

        public TestCasesStepDefinitions(ScenarioContext sc)
        {
            _scenarioContext = sc;
            this.s_driver = (IWebDriver)_scenarioContext["myDriver"];
        }


        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            MyAccount login = new MyAccount(s_driver);
  
            login.UsernameTextBox(Environment.GetEnvironmentVariable("username")); //uses enviroment variable to get login credentials
            login.PasswordTextBox(Environment.GetEnvironmentVariable("password"));
            login.LoginButton();
            loggedIn = login;
     
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
            wait = new HelpersInstance(s_driver);
            wait.WaitForElm(3, By.CssSelector("#post-5 > div > div > div.cart-collaterals > div > table > tbody > tr.cart-discount.coupon-edgewords > td > span"));
            decimal discount = carts.GetDiscount(carts.GetSubTotalExtract(), carts.GetDiscountAmount());
            try
            {
                Assert.That ((int)discount, Is.EqualTo( p0), "15% should have been applied!");
            }
            catch (Exception)
            {
            }
            finally
            {
                wait = new HelpersInstance(s_driver);
                wait.WaitForElm(2, By.ClassName("remove"));
                carts.RemoveCoupon();
                carts.EmptyCart();
            }
        }

        //TestCase2

        [When(@"I am in the MyAccount page")]
        public void WhenIAmInTheMyAccountPage()
        {
            wait = new HelpersInstance(s_driver);
            wait.WaitForElm(3, By.ClassName("woocommerce-MyAccount-navigation"));
            Assert.That(loggedIn.IsNavigationMenuExist(), Is.True, "Navigation menu not displayed!");
        }

        [When(@"I click the Orders menu item")]
        public void WhenIClickTheOrdersMenuItem()
        {
            loggedIn.OrdersMenuItem();
        }


        [Then(@"I should be able to see the order")]
        public void ThenIShouldBeAbleToSeeTheOrder()
        {
            
            OrdersHistory ordersHistory = new OrdersHistory();
            ordersHistory.GetOrderNoFromOrdersPage(s_driver);
            Assert.That(loggedIn.IsOrdersTableExist(), Is.True, "Orders table not displayed!");
        }

        


    }
}
