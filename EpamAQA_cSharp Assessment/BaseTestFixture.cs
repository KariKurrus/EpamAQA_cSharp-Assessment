using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EpamAQA_cSharp_Assessment
{

    public class BaseTestFixture
    {
        public static string DriverPath;
        [ThreadStatic]
        public static IWebDriver Driver;

        [SetUp]
        public static void Setup()
        {
            DriverPath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
            Driver = new ChromeDriver(DriverPath);
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public static void Teardown()
        {
            DriverCovering.CloseDriver();
        }
    }
}
