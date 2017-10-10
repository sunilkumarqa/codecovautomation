using Appium__Automation.TestCases.NativeApps;
using Appium__Automation.TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ImageFormat = System.Drawing.Imaging.ImageFormat;
namespace Appium__Automation.TestCases.AndroidApps.AZappgame
{

    public class MLFunctionality : ITestCase
    {
        public static AndroidDriver<AndroidElement> driver;
        KeyFunctions KeyGeneric = new KeyFunctions();
        DesiredCapabilities capabilities = new DesiredCapabilities();
        GamesElements games = new GamesElements();
        MRPageElements mrPageElements = new MRPageElements();

        public void Execute()
        {

            try
            {
                //Initialize the Arizona mobile app
                KeyGeneric.CapabilitiesMR(capabilities);
                driver = new AndroidDriver<AndroidElement>(new Uri(ConfigurationManager.AppSettings["URL"]), capabilities);
                Thread.Sleep(30000);
                //Click on Menu Option
                driver.FindElementById("com.mdi.mdlottery:id/reveal_icon").Click();
                Thread.Sleep(4000);
                IWebElement wbq = driver.FindElement(By.XPath("//*[@class = 'android.view.View'and @index='0']"));
                driver.Zoom(wbq);
                driver.Zoom(12, 75);
                driver.Pinch(34, 56);
                driver.FindElementByXPath("//*[@class='android.widget.TextView' and @text='Drawings and Winners']").Click();
                Thread.Sleep(4000);
                driver.FindElementByXPath("//*[@class='android.widget.Spinner' and @index='1']").Click();
                Thread.Sleep(4000);
                driver.FindElementByXPath("//*[@id='android:id/text1' and @text='All']").Click();
               
                
            }
            catch
            {

                Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
               
                image.SaveAsFile("C:\\Users\\105798\\Documents\\Visual Studio 2013\\Projects\\Appium_ Automation\\Appium_ Automation\\ScreenShot\\Screenshot.Png", ImageFormat.Png);
            }
        }
          
    }
}