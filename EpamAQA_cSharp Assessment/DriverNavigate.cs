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
