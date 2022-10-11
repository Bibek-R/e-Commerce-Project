using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Practise.Utilities
{
    internal class HelpersInstance
    {

        IWebDriver driver;

        public HelpersInstance(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void WaitForElm(int Seconds, By Locator)
        {
            WebDriverWait myWait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(Seconds));
            myWait3.Until(drv => drv.FindElement(Locator).Displayed);
        }
    }
}
