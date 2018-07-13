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
    public class LoginPage
    {
        //public IOSDriver<IWebElement> driver;

        //public LoginPage(IOSDriver<IWebElement> driver)
        //{
        //    this.driver = driver;
        //    PageFactory.InitElements(driver, this);
        //}

        public AndroidDriver<IWebElement> driver;

        public LoginPage(AndroidDriver<IWebElement> driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement usernameInput;

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement passwordInput;

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement loginButton;

        public void Login(string sUserName, string sPassword)
        {
            // Thread.Sleep(5000);
            new WebDriverWait(driver, TimeSpan.FromSeconds(300)).Until(ExpectedConditions.ElementIsVisible((By.Id("submit"))));
            usernameInput.Click();
            usernameInput.SendKeys(sUserName);
            passwordInput.SendKeys(sPassword);
            loginButton.Click();
        }
    }
}
