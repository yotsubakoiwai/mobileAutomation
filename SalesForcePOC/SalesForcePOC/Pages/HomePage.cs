using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Threading;
using OpenQA.Selenium.Appium.Android;

namespace SalesForcePOC.Pages
{
    public class HomePage
    {
        //public IOSDriver<IWebElement> driver;

        //public HomePage(IOSDriver<IWebElement> driver)
        //{
        //    this.driver = driver;
        //    PageFactory.InitElements(driver, this);
        //}

        public AndroidDriver<IWebElement> driver;

        public HomePage(AndroidDriver<IWebElement> driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='sidebar-control-handle']")]
        public IWebElement logo;

        public void VerifyHomePageDisplayed()
        {
            Assert.True(logo.Displayed, "Expected: HomePage is displayed");
        }
    }
}
