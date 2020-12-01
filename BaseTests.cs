using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace SimpleElementsProject
{
    [TestFixture]
    public class BaseTets
    {

        public IWebDriver Driver { get; set; }

        internal SimpleElementsPage SimElemPage { get; set; }
        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

        [SetUp]
        public void SetupBeforeEachTestMethod()
        {
            Driver = GetChromeDriver();
            SimElemPage = new SimpleElementsPage(Driver);
            SimElemPage.Open();
        }

        [TearDown]
        public void CleanUpAfterEveryTestMethod()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}