using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using NUnit.Framework;
using ImageFormat=System.Drawing.Imaging.ImageFormat;
using Appium__Automation.TestData;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace Appium__Automation
{
    public class KeyFunctions
    {

        public static AppiumDriver<AndroidElement> driver;
        DesiredCapabilities capabilities = new DesiredCapabilities();
        BigBasketElements BBElement = new BigBasketElements();

        public string EnterRandomText(int length)
        {
            /*var varchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var varRandom = new Random();
            var varResult = new string(Enumerable.Repeat(varchars, i).Select(s => s[varRandom.Next(s.Length)]).ToArray());
            return varResult;*/
            //Define the included characters
            string charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            string randomText = new String(Enumerable.Repeat(charSet, length).Select(set => set[random.Next(set.Length)]).ToArray());
            return randomText;

        }

        public string EnterRandomNo()
        {
            Random random = new Random();
            int tal = random.Next(0, 100000000);
            string randomNumber = tal.ToString();
            return randomNumber;
        }
        public void CapabilitiesHealthi(DesiredCapabilities capabilities)
        {

            capabilities.SetCapability("deviceName", ConfigurationManager.AppSettings["deviceName"]);
            capabilities.SetCapability(CapabilityType.Version, ConfigurationManager.AppSettings["Version"]);
            capabilities.SetCapability(CapabilityType.BrowserName, ConfigurationManager.AppSettings["BrowserName"]);
            capabilities.SetCapability(CapabilityType.Platform, ConfigurationManager.AppSettings["Platform"]);
            capabilities.SetCapability("appPackage", ConfigurationManager.AppSettings["HealthyfiPackage"]);
            capabilities.SetCapability("appActivity", ConfigurationManager.AppSettings["HealthyfiActivity"]);
            capabilities.SetCapability("app", ConfigurationManager.AppSettings["app1"]);


        }

        public void CapabilitiesContacts(DesiredCapabilities capabilities)
        {
            
            capabilities.SetCapability("deviceName", ConfigurationManager.AppSettings["deviceName"]);
            capabilities.SetCapability(CapabilityType.Version, ConfigurationManager.AppSettings["Version"]);
            capabilities.SetCapability(CapabilityType.BrowserName, ConfigurationManager.AppSettings["BrowserName"]);
            capabilities.SetCapability(CapabilityType.Platform, ConfigurationManager.AppSettings["Platform"]);
            capabilities.SetCapability("appPackage", ConfigurationManager.AppSettings["ContactPackage"]);
            capabilities.SetCapability("appActivity", ConfigurationManager.AppSettings["ContactActivity"]);
            capabilities.SetCapability("app", ConfigurationManager.AppSettings["app1"]);
            
        }
        public void CapabilitiesBigBasket(DesiredCapabilities capabilities)
        {

            capabilities.SetCapability("deviceName", ConfigurationManager.AppSettings["deviceName"]);
            capabilities.SetCapability(CapabilityType.Version, ConfigurationManager.AppSettings["Version"]);
            capabilities.SetCapability(CapabilityType.BrowserName, ConfigurationManager.AppSettings["BrowserName"]);
            capabilities.SetCapability(CapabilityType.Platform, ConfigurationManager.AppSettings["Platform"]);
            capabilities.SetCapability("appPackage", ConfigurationManager.AppSettings["BigBasketPackage"]);
            capabilities.SetCapability("appActivity", ConfigurationManager.AppSettings["BigBasketActivities"]);
            capabilities.SetCapability("app", ConfigurationManager.AppSettings["app2"]);


        }
        public void CapabilitiesCalculator(DesiredCapabilities capabilities)
        {

            capabilities.SetCapability("deviceName", ConfigurationManager.AppSettings["deviceName"]);
            capabilities.SetCapability(CapabilityType.Version, ConfigurationManager.AppSettings["Version"]);
            capabilities.SetCapability(CapabilityType.BrowserName, ConfigurationManager.AppSettings["BrowserName"]);
            capabilities.SetCapability(CapabilityType.Platform, ConfigurationManager.AppSettings["Platform"]);
            capabilities.SetCapability("appPackage", ConfigurationManager.AppSettings["CalcualtorPackage"]);
            capabilities.SetCapability("appActivity", ConfigurationManager.AppSettings["CalculatorActivities"]);



        }
        public void CapabilitiesSetting(DesiredCapabilities capabilities)
        {

            capabilities.SetCapability("deviceName", ConfigurationManager.AppSettings["deviceName"]);
            capabilities.SetCapability(CapabilityType.Version, ConfigurationManager.AppSettings["Version"]);
            capabilities.SetCapability(CapabilityType.BrowserName, ConfigurationManager.AppSettings["BrowserName"]);
            capabilities.SetCapability(CapabilityType.Platform, ConfigurationManager.AppSettings["Platform"]);
            capabilities.SetCapability("appPackage", ConfigurationManager.AppSettings["SettingPackage"]);
            capabilities.SetCapability("appActivity", ConfigurationManager.AppSettings["SettingActivities"]);



        }
        public void CapabilitiesGame(DesiredCapabilities capabilities)
        {

            capabilities.SetCapability("deviceName", ConfigurationManager.AppSettings["deviceName"]);
            capabilities.SetCapability(CapabilityType.Version, ConfigurationManager.AppSettings["Version"]);
            capabilities.SetCapability(CapabilityType.BrowserName, ConfigurationManager.AppSettings["BrowserName"]);
            capabilities.SetCapability(CapabilityType.Platform, ConfigurationManager.AppSettings["Platform"]);
            capabilities.SetCapability("appPackage", ConfigurationManager.AppSettings["AZPackage"]);
            capabilities.SetCapability("appActivity", ConfigurationManager.AppSettings["AZActivities"]);
            capabilities.SetCapability("app", ConfigurationManager.AppSettings["app3"]);



        }
        public void CapabilitiesMR(DesiredCapabilities capabilities)
        {

            capabilities.SetCapability("deviceName", ConfigurationManager.AppSettings["deviceName"]);
            capabilities.SetCapability(CapabilityType.Version, ConfigurationManager.AppSettings["Version"]);
            capabilities.SetCapability(CapabilityType.BrowserName, ConfigurationManager.AppSettings["BrowserName"]);
            capabilities.SetCapability(CapabilityType.Platform, ConfigurationManager.AppSettings["Platform"]);
            capabilities.SetCapability("appPackage", ConfigurationManager.AppSettings["MRPackage"]);
            capabilities.SetCapability("appActivity", ConfigurationManager.AppSettings["MRActivities"]);
            capabilities.SetCapability("app", ConfigurationManager.AppSettings["app4"]);

        }
        public void CodeCOVApp(DesiredCapabilities capabilities)
        {

            capabilities.SetCapability("deviceName", ConfigurationManager.AppSettings["deviceName"]);
            capabilities.SetCapability(CapabilityType.Version, ConfigurationManager.AppSettings["Version"]);
            capabilities.SetCapability(CapabilityType.BrowserName, ConfigurationManager.AppSettings["BrowserName"]);
            capabilities.SetCapability(CapabilityType.Platform, ConfigurationManager.AppSettings["Platform"]);
            capabilities.SetCapability("appPackage", ConfigurationManager.AppSettings["codecovpack"]);
            capabilities.SetCapability("appActivity", ConfigurationManager.AppSettings["codecovActivities"]);
            capabilities.SetCapability("app", ConfigurationManager.AppSettings["app5"]);

        }
    }
}

		
