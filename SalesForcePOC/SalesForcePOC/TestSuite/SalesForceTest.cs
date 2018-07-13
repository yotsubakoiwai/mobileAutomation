using NUnit.Framework;
using SalesForcePOC.Lib;
using SalesForcePOC.Pages;

namespace TestSuite
{
    public class SalesForceTest:CommonLibrary
    {
        [Test]
        public void LoginTest()
        {

            //Navigate to Sales Force
            //iosDriver.Navigate().GoToUrl("http://ecu--qa.cs58.my.salesforce.com");
            //androidDriver.Navigate().GoToUrl("http://ecu--qa.cs58.my.salesforce.com");
            androidDriver.Navigate().GoToUrl("https://saucelabs.com/beta/login");

            //Login with username and password
            //LoginPage loginPage = new LoginPage(iosDriver);
            LoginPage loginPage = new LoginPage(androidDriver);
            //loginPage.Login("tosca.reviewer@ecu.edu.au.qa", "password2");
            loginPage.Login("jcustodio@planittesting.com", "Saucelabs1");

            //Verify HomePage displayed
            //HomePage homePage = new HomePage(iosDriver);
            //HomePage homePage = new HomePage(androidDriver);
            //homePage.VerifyHomePageDisplayed();

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
