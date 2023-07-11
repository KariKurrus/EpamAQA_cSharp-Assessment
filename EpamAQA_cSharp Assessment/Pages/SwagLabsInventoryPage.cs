﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EpamAQA_cSharp_Assessment.DriverCovering;

namespace EpamAQA_cSharp_Assessment.Pages
{
    public class SwagLabsInventoryPage
    {
        private IWebElement _inventoryTitle => FindElementByXpath("//div[@class ='app_logo']");

        public string GetInventoryTitle()
        {
            return _inventoryTitle.Text;
        }
    }
}