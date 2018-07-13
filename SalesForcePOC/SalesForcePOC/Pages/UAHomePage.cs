using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Appium.Android;

namespace SalesForcePOC.Pages
{
    public class UAHomePage
    {
        public AndroidDriver<IWebElement> driver;

        public UAHomePage(AndroidDriver<IWebElement> driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ClickBookFlightButton()
        {
            //IWebElement bookFlightBtn = driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().text(\"Book a flight\").instance(0)");
            IWebElement bookFlightBtn = driver.FindElementByAndroidUIAutomator("new UiSelector().text(\"Book a flight\")");
            bookFlightBtn.Click();
        }
    }
}
