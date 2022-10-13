using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Practise.Utilities;

namespace Practise.POM
{
    internal class OrdersHistory
    {
		//get list of orders from order history
		public void GetOrderNoFromOrdersPage(IWebDriver _driver)
		{
            IWebElement form = _driver.FindElement(By.CssSelector(".woocommerce-orders-table"));
            HelpersStatic.TakeScreenshotElement(form, "orderhistory");
            TestContext.AddTestAttachment(@"C:\Screenshots\orderhistory.png");
        }

	}
}
