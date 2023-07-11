using EpamAQA_cSharp_Assessment.Pages;
using FluentAssertions;

namespace EpamAQA_cSharp_Assessment.Steps
{
    public class LoginSteps
    {
        private SwagLabsLoginPage _swagLabsLoginPage;
        private SwagLabsInventoryPage _swagLabsInventoryPage;
        public LoginSteps()
        {
            _swagLabsLoginPage = new SwagLabsLoginPage();
            _swagLabsInventoryPage = new SwagLabsInventoryPage();
        }

        public void LoggingWithEmptyCredentials(string inputCredentials)
        {
            _swagLabsLoginPage.SetUsernameAttribute(inputCredentials);

            _swagLabsLoginPage.RemoveFromUsernameAttribute();

            _swagLabsLoginPage.ClickOnLoginButton();
        }

        public void LoggingWithCredentialsPassingTheUsername(string inputCredentials)
        {
            _swagLabsLoginPage.SetUsernameAttribute(inputCredentials);

            _swagLabsLoginPage.ClickOnLoginButton();
        }

        public void LoggingWithCredentialsPassingThePasswordAndUsername(string inputCredentials, string inputPassword)
        {
            _swagLabsLoginPage.SetUsernameAttribute(inputCredentials);

            _swagLabsLoginPage.SetPasswordAttribute(inputPassword);

            _swagLabsLoginPage.ClickOnLoginButton();
        }

        public void VerifyinventoryTitle(string inputTitleObject)
        {
            var titleObject = _swagLabsInventoryPage.GetInventoryTitle();
            titleObject.Should().Be(inputTitleObject);
        }

        public void VerifyErrorMassage(string expectedMessage = "empty")
        {
            var actualMessage = _swagLabsLoginPage.GetErrorMassageText();
            actualMessage.Should().Contain(expectedMessage);
        }
    }
}
