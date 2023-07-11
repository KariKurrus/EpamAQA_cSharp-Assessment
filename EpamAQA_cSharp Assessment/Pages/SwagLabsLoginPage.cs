using OpenQA.Selenium;
using static EpamAQA_cSharp_Assessment.DriverCovering;
using static EpamAQA_cSharp_Assessment.TextLogger;

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
            TextLogger.GenerateLogMessage($"{GetmethodCaller()}");
            return _usernameField.GetAttribute("value");
        }

        public string GetPasswordFieldValue()
        {
            _passwordField.WaitUntilExist();
            TextLogger.GenerateLogMessage($"{GetmethodCaller()}");
            return _passwordField.GetAttribute("value");
        }

        public void EnterUsername(string value)
        {
            _usernameField.WaitUntilExist();
            _usernameField.SendKeys(value);
            TextLogger.GenerateLogMessage($"{GetmethodCaller()}");
        }

        public void EnterPassword(string value)
        {
            _passwordField.WaitUntilExist();
            _passwordField.SendKeys(value);
            TextLogger.GenerateLogMessage($"{GetmethodCaller()}");
        }

        public void ClearUsernameInput()
        {
            _usernameField.WaitUntilExist();
            _usernameField.SendKeys(Keys.Control + "A");
            _usernameField.SendKeys(Keys.Delete);
            TextLogger.GenerateLogMessage($"{GetmethodCaller()}");
        }

        public void ClearPasswordInput()
        {
            _passwordField.WaitUntilExist();
            _passwordField.SendKeys(Keys.Control + "A");
            _passwordField.SendKeys(Keys.Delete);
            TextLogger.GenerateLogMessage($"{GetmethodCaller()}");
        }

        public string GetErrorMassageText()
        {
            _errorMassageField.WaitUntilExist();
            TextLogger.GenerateLogMessage($"{GetmethodCaller()}");
            return _errorMassageField.Text;
        }

        public void ClickOnLoginButton()
        {
            _loginButton.WaitUntilExist();
            _loginButton.Click();
            TextLogger.GenerateLogMessage($"{GetmethodCaller()}");
        }
    }
}
