using EpamAQA_cSharp_Assessment.Steps;

namespace EpamAQA_cSharp_Assessment
{

    [TestFixture]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    [Parallelizable(ParallelScope.All)]
    public class Tests : BaseTestFixture
    {
        public LoginSteps loginSteps;
        public Tests()
        {
            loginSteps = new LoginSteps();
        }

        [Test]
        [TestCase("problem_user", "Username is required")]
        [TestCase("standard_user", "Username is required")]
        [TestCase("performance_glitch_user", "Username is required")]
        public void VerifyLoggingWithEmptyCredentialsTest(string inputUsername, string inputError)
        {
            DriverNavigate.GoToSwagLabs();
            loginSteps.LoggingWithEmptyCredentials(inputUsername);
            loginSteps.VerifyErrorMassage(inputError);
        }

        [TestCase("problem_user", "Password is required")]
        [TestCase("standard_user", "Password is required")]
        [TestCase("performance_glitch_user", "Password is required")]
        [Test]
        public void VerifyLoggingWithCredentialsPassingTheUsernameTest(string inputUsername, string inputError)
        {
            DriverNavigate.GoToSwagLabs();
            loginSteps.LoggingWithCredentialsPassingTheUsername(inputUsername);
            loginSteps.VerifyErrorMassage(inputError);
        }

        [Test]
        [TestCase("problem_user", "secret_sauce", "Swag Labs")]
        [TestCase("standard_user", "secret_sauce", "Swag Labs")]
        [TestCase("performance_glitch_user", "secret_sauce", "Swag Labs")]
        public void VerifyLoggingWithCredentialsPassingThePasswordAndUsernameTest(string inputUsername, string inputPassword, string inputTitle)
        {
            DriverNavigate.GoToSwagLabs();
            loginSteps.LoggingWithCredentialsPassingThePasswordAndUsername(inputUsername, inputPassword);
            loginSteps.VerifyinventoryTitle(inputTitle);
        }
    }
}