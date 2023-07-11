using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static EpamAQA_cSharp_Assessment.DriverCovering;

namespace EpamAQA_cSharp_Assessment.Pages
{
    public class SwagLabsLoginPage
    {
        private IWebElement _usernameField => FindElementByXpath("//form//div//input[@placeholder = 'Username']");
        private IWebElement _passwordField => FindElementByXpath("//form//div//input[@placeholder = 'Password']");
        private IWebElement _loginButton => FindElementByXpath("//form//input[@class = 'submit-button btn_action']");
        private IWebElement _errorMassageField => FindElementByXpath("//form//div[@class='error-message-container error']//h3");

        public string GetUsernameFieldValue()
        {
            _usernameField.WaitUntilExist();
            return _usernameField.GetAttribute("value");
        }

        public string GetPasswordFieldValue()
        {
            _passwordField.WaitUntilExist();
            return _passwordField.GetAttribute("value");
        }

        public void SetUsernameAttribute(string value)
        {
            _usernameField.WaitUntilExist();
            _usernameField.SendKeys(value);
        }

        public void SetPasswordAttribute(string value)
        {
            _passwordField.WaitUntilExist();
            _passwordField.SendKeys(value);
        }

        public void RemoveFromUsernameAttribute()
        {
            _usernameField.WaitUntilExist();
            _usernameField.SendKeys(Keys.Control + "A");
            _usernameField.SendKeys(Keys.Delete);
        }

        public void RemoveFromPasswordAttribute()
        {
            _passwordField.WaitUntilExist();
            _passwordField.SendKeys(Keys.Control + "A");
            _passwordField.SendKeys(Keys.Delete);
        }

        public string GetErrorMassageText()
        {
            _errorMassageField.WaitUntilExist();
            return _errorMassageField.Text;
        }

        public void ClickOnLoginButton()
        {
            _loginButton.WaitUntilExist();
            _loginButton.Click();
        }
    }
}
