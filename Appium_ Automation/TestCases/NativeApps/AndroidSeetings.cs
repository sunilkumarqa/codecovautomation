using Appium__Automation.TestData;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium__Automation.TestCases.NativeApps
{
  public  class AndroidSeetings : ITestCase
    {
        public static AppiumDriver<AndroidElement> driver;
        KeyFunctions KeyGeneric = new KeyFunctions();
        DesiredCapabilities capabilities = new DesiredCapabilities();
        AndroidSettingElements SettingAndroid = new AndroidSettingElements();
       

        public void Execute()
        {
           
            try
            {
                 // BigBasket LogIn
                KeyGeneric.CapabilitiesSetting(capabilities);
                driver = new AndroidDriver<AndroidElement>(new Uri(ConfigurationManager.AppSettings["URL"]), capabilities);
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                 PageFactory.InitElements(driver, SettingAndroid);
                SettingAndroid.AppLink.Click();
            
           
                
            }
            catch
            {

                Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
                //Save the screenshot
                image.SaveAsFile("C:\\Users\\105798\\Documents\\Visual Studio 2013\\Projects\\Appium_ Automation\\Appium_ Automation\\ScreenShot\\Screenshot.Png", ImageFormat.Png);
            }
        }
    }
}

    

