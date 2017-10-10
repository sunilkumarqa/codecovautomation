using NUnit.Framework;
using PNUnit.Framework;
using System;
using System.Web;
using System.Text;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System.IO;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;

namespace Appium__Automation
{
    [TestFixture()]
    public class Appium_TestNG_Sample_One
    {
        AndroidDriver<AndroidElement> driver;

        [SetUp]
        void HomepageLogin()
        {
            AppiumDriver<AndroidElement> driver;
            string app = "C:\\Users\\105798\\testapplications\\HealthifyMe.apk";

            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("deviceName", "emulator-5554");
            capabilities.SetCapability(CapabilityType.Version, "6.0");
            capabilities.SetCapability(CapabilityType.BrowserName, "Android");
            capabilities.SetCapability(CapabilityType.Platform, "Android");
            capabilities.SetCapability("appPackage", "com.healthifyme.basic");
            capabilities.SetCapability("appActivity", "com.healthifyme.basic.activities.NewLoginSignupActivity");

            capabilities.SetCapability("NEW_COMAND_TIMEOUT", "50000");
            capabilities.SetCapability("app", "C:\\Users\\105798\\testapplications\\HealthifyMe.apk");

            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
        }
          [Test]

    }
}