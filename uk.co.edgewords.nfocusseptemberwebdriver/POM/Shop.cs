using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Practise.POM
{
    internal class Shop  
    {
        private static IWebElement s_element;

        public static IWebElement ProductSelection(IWebDriver _driver) //navigates to products info page
        {
            s_element = _driver.FindElement(By.CssSelector("li.product:nth-child(3)"));
            return s_element;
        }
    }
}
