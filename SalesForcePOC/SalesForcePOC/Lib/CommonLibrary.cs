using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Service.Exceptions;
using OpenQA.Selenium.Appium.Android;

namespace SalesForcePOC.Lib
{
    public class CommonLibrary
    {
        public AppiumLocalService service;
        //public IOSDriver<IWebElement> iosDriver;
        public AndroidDriver<IWebElement> androidDriver;
        public AppiumServiceBuilder builder;

        public CommonLibrary()
        {

            service = new AppiumServiceBuilder().WithIPAddress("127.0.0.1").UsingAnyFreePort().Build();
            service.Start();

            if (service == null || !service.IsRunning)
            {
                throw new AppiumServerHasNotBeenStartedLocallyException("An appium server node is not started!");
            }

            DesiredCapabilities caps = new DesiredCapabilities();
            //Safari browser
            //caps.SetCapability("platformName", "iOS");
            //caps.SetCapability("deviceName", "iPhone 8");
            //caps.SetCapability("platformVersion", "11.4");
            //caps.SetCapability("browserName", "Safari");
            ////caps.SetCapability("app", "Users/mpatige/Documents/PlanitPOC/Applications/sim/planitApp.app");
            //caps.SetCapability("useNewWDA", true);
            //caps.SetCapability("wdaStartupRetryInterval", 1000);
            //caps.SetCapability("waitForQuiescence", false);
            //caps.SetCapability("shouldUseSingletonTestManager", false);

            //iosDriver = new IOSDriver<IWebElement>(service.ServiceUrl, caps);
            //iosDriver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(60));

            //chromeAndroid browser
            //caps.SetCapability("platformName", "Android");
            //caps.SetCapability("platformVersion", "8.0");
            //caps.SetCapability("deviceName", "Nexus_5X_API_26");
            //caps.SetCapability("browserName", "Chrome");

            //native app (united airlines)
            caps.SetCapability("platformName", "Android");
            caps.SetCapability("platformVersion", "8.0");
            caps.SetCapability("deviceName", "Nexus_5X_API_26");
            caps.SetCapability("fullReset", "false");
            caps.SetCapability("noReset", "true");
            caps.SetCapability("appActivity", "com.united.mobile.android.SplashScreen");
            caps.SetCapability("appPackage", "com.united.mobile.android");

            androidDriver = new AndroidDriver<IWebElement>(service.ServiceUrl, caps);
            androidDriver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(60));
        }
    }
}
