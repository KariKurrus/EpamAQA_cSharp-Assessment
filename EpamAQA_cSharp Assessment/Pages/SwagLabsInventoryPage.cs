using OpenQA.Selenium;
using static EpamAQA_cSharp_Assessment.DriverCovering;
using static EpamAQA_cSharp_Assessment.TextLogger;

namespace EpamAQA_cSharp_Assessment.Pages
{
    public class SwagLabsInventoryPage
    {
        private IWebElement _inventoryTitle => FindElementByXpath("//div[@class ='app_logo']");

        public string GetInventoryTitle()
        {
            TextLogger.GenerateLogMessage($"{GetmethodCaller(GetmethodCaller())}");
            return _inventoryTitle.Text;
        }
    }
}
