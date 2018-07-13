using NUnit.Framework;
using SalesForcePOC.Lib;
using SalesForcePOC.Pages;

namespace TestSuite
{
    public class UnitedAirlinesTest:CommonLibrary
    {
        [Test]
        public void BookAFlightTest()
        {
            androidDriver.LaunchApp();
            UAHomePage uahomePage = new UAHomePage(androidDriver);
            uahomePage.ClickBookFlightButton();
        }

        [TearDown]
        public void EndTest()
        {
            //iosDriver.Quit();
            androidDriver.Quit();
            service.Dispose();
        }
    }
}
