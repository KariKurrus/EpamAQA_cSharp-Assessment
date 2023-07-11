using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EpamAQA_cSharp_Assessment.BaseTestFixture;

namespace EpamAQA_cSharp_Assessment
{
    public static class Waiters
    {
        public static void WaitUntilExist(this IWebElement elementRef, int timeout = 10)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeout));
            wait.Until(element => elementRef);
        }
    }
}
