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
    public class Calculator : ITestCase
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
            PageFactory.InitElements(driver, calculatorobj);
            calculatorobj.CalculatorTextField.SendKeys("9");
            calculatorobj.Digit7.Click();
            calculatorobj.CalculatorSub.Click();
            calculatorobj.Digit8.Click();
            calculatorobj.CalculatorEqual.Click();
            string cal = calculatorobj.CalculatorTextField.Text;
            Assert.AreEqual("89", cal);
            Console.WriteLine(cal);
            Console.ReadLine();
           
        }
    }
}