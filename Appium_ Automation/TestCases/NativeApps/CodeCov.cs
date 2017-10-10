using Appium__Automation.TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Appium__Automation.TestCases.NativeApps
{
    public class CodeCov : ITestCase
    {
        KeyFunctions KeyGeneric = new KeyFunctions();
        DesiredCapabilities capabilities = new DesiredCapabilities();
        CalculatorElements calculatorobj = new CalculatorElements();
        public static AppiumDriver<AndroidElement> driver;

        public void Execute()
        {

            KeyGeneric.CapabilitiesCalculator(capabilities);
            driver = new AndroidDriver<AndroidElement>(new Uri(ConfigurationManager.AppSettings["URL"]), capabilities);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.FindElementById("com.writer.aspiring.unittestingdemo:id/UserName").SendKeys("Olivia");
            driver.FindElementById("com.writer.aspiring.unittestingdemo:id/UserName").SendKeys("Dunham");
            driver.FindElementById("com.writer.aspiring.unittestingdemo:id/text_signin").Click();
            driver.FindElementById("com.writer.aspiring.unittestingdemo:id/UserName").SendKeys("Oliviaa");
            driver.FindElementById("com.writer.aspiring.unittestingdemo:id/UserName").SendKeys("Dunham");
        }
    }
}