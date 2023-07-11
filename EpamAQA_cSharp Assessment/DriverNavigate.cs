using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamAQA_cSharp_Assessment
{
    public static class DriverNavigate
    {
        public static void GoToSwagLabs()
        {
            BaseTestFixture.Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
    }
}
