using Appium__Automation.TestCases.NativeApps;
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

namespace Appium__Automation.TestCases.AndroidApps.Healthify
{
   public class HealthyFiMe : ITestCase
    {
        public static AppiumDriver<AndroidElement> driver;
        KeyFunctions KeyGeneric = new KeyFunctions();
        DesiredCapabilities capabilities = new DesiredCapabilities();
        ContactsPage contactsElement = new ContactsPage();
        LoginPageElements pageElemnts = new LoginPageElements();
       
      public  void Execute()
      {

          KeyGeneric.CapabilitiesHealthi(capabilities);
          driver = new AndroidDriver<AndroidElement>(new Uri(ConfigurationManager.AppSettings["URL"]), capabilities);
          Thread.Sleep(15000);
          PageFactory.InitElements(driver, pageElemnts);
        
          pageElemnts.loginButton.Click();
          Thread.Sleep(5000);
          pageElemnts.Username.SendKeys("healthyfi787@gmail.com" + "\t\t");
          driver.Navigate().Back();
          Thread.Sleep(5000);
          pageElemnts.password.SendKeys("787healthyfi" + "\t\t");
          Thread.Sleep(5000);
          driver.Navigate().Back();
          //driver.HideKeyboard();
          pageElemnts.SubmitButton.Click();
          Thread.Sleep(20000);
          string Dashboardtext = pageElemnts.Todaytext.Text;
          Console.WriteLine(Dashboardtext);
          Assert.AreEqual("Today", Dashboardtext);
          pageElemnts.MenuHealthyfi.Click();
          pageElemnts.addFoodicon.Click();
          Thread.Sleep(5000);
          pageElemnts.Whatdidyoueat.Click();
          pageElemnts.foodSearch.SendKeys("Rice");
          Thread.Sleep(5000);
          pageElemnts.foodSearchOne.Click();

          }

      }
    }

