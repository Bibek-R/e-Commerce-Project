using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Practise.POM
{
    internal class OrdersHistory
    {
		//get list of orders from order history
		public static List<string> GetOrderNoFromOrdersPage(IWebDriver _driver)
		{
			IWebElement _ordersTable = _driver.FindElement(By.CssSelector(".woocommerce-orders-table.woocommerce-MyAccount-orders.shop_table.shop_table_responsive.my_account_orders.account-orders-table"));
			List<IWebElement> _orders = new List<IWebElement>(_ordersTable.FindElements(By.TagName("tr")));
			List<string> _orderNumbers = new List<string>();
			foreach (var tr in _orders) //tr is table row(html tag)
			{
				_orderNumbers.Add(tr.FindElement(By.XPath("/html//article[@id='post-7']/div[@class='entry-content']//table/tbody/tr[1]/td[@class='woocommerce-orders-table__cell woocommerce-orders-table__cell-order-number']")).Text);
			}
			//extracts order no from each order in the order list 
			return _orderNumbers;
		}

		
		
	}
}
