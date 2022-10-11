using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Practise.Utilities
{
    internal static class HelpersStatic
    {
        public static void WaitForElmStatic(IWebDriver driver, int Seconds, By Locator)
        {
            WebDriverWait myWait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(Seconds));
            myWait3.Until(drv => drv.FindElement(Locator).Displayed);
        }

        public static void TakeScreenshot(IWebDriver driver, string FileName)
        {
            ITakesScreenshot ssdriver = driver as ITakesScreenshot;
            Screenshot file = ssdriver.GetScreenshot();
            file.SaveAsFile(@"C:\Screenshots\" + FileName + ".png", ScreenshotImageFormat.Png);
        }

        public static void TakeScreenshotElement(IWebElement elm, string FileName)
        {
            ITakesScreenshot sselm = elm as ITakesScreenshot;
            Screenshot file = sselm.GetScreenshot();
            file.SaveAsFile(@"C:\Screenshots\" + FileName + ".png", ScreenshotImageFormat.Png);
            file.SaveAsFile(@"C:\Screenshots\" + FileName + ".jpg");
        }
    }
}
