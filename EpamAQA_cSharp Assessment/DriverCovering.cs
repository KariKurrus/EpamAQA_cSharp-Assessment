using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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
