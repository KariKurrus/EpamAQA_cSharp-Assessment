using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamAQA_cSharp_Assessment
{
    public static class DriverCovering
    {
        public static IWebElement FindElementByXpath(string xpath, int waitTimeInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(BaseTestFixture.Driver, TimeSpan.FromSeconds(waitTimeInSeconds));
            return wait.Until(wait => BaseTestFixture.Driver.FindElement(By.XPath(xpath)));
        }

        public static void CloseDriver()
        {
            BaseTestFixture.Driver.Close();
            BaseTestFixture.Driver.Quit();
        }
    }
}
