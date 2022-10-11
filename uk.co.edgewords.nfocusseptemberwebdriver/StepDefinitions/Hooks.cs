using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using Practise.POM;
using TechTalk.SpecFlow;

namespace Practise.StepDefinitions
{
    [Binding]
    public class Hooks
    {
        private IWebDriver s_driver;
        private readonly ScenarioContext _scenarioContext;
        public Hooks(ScenarioContext sc)
        {
            _scenarioContext = sc;
        }


        [BeforeScenario]
        public void Setup()
        {
            s_driver = new FirefoxDriver();
            s_driver.Url = Environment.GetEnvironmentVariable("url");
            s_driver.Manage().Window.Maximize();
            
            s_driver.FindElement(By.CssSelector(".woocommerce-store-notice__dismiss-link")).Click();
 
            _scenarioContext["myDriver"] = s_driver;
        }

        [AfterScenario]
        public void TearDown()
        {
            //Product remove, coupon remove, logout  
            //Delete all created objects - objectname.dispose()  e.g. carts.dispose();
            // Wait 3s to check everything worked
            //Cart.RemoveCoupon(s_driver).Click();
            //Cart.EmptyCart(s_driver).Click();
            //s_driver.Quit(); //Close all tabs, windows for session, closes webdriver session.
        }
    }
}
