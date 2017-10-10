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

    public class AZappFunctionality : ITestCase
    {
        public static AndroidDriver<AndroidElement> driver;
        KeyFunctions KeyGeneric = new KeyFunctions();
        DesiredCapabilities capabilities = new DesiredCapabilities();
        GamesElements games = new GamesElements();


        public void Execute()
        {

            try
            {
                //Initialize the Arizona mobile app
                KeyGeneric.CapabilitiesGame(capabilities);
                driver = new AndroidDriver<AndroidElement>(new Uri(ConfigurationManager.AppSettings["URL"]), capabilities);
                Thread.Sleep(20000);
                //Click on Menu Option
                driver.FindElementById("com.mdi.azlottery:id/reveal_icon").Click();
                Thread.Sleep(4000);
                //Games.MenuOption.Click();
                // Click on Prize Store
                //driver.FindElementByXPath("//*[@class='android.widget.TextView' and @text='Prize Store']").Click();
                //Thread.Sleep(20000);
                // Expand Best seller opion
               // driver.FindElementByXPath("//*[@class= 'android.view.View' and @index= '4']").Click();
                //Thread.Sleep(10000);
                //Click on Menu Option
               // driver.FindElementById("com.mdi.azlottery:id/reveal_icon").Click();
                //Thread.Sleep(4000);
                // Click on Help
                driver.FindElementByXPath("//*[@class='android.widget.TextView' and @text='Help']").Click();
                // Click on Rules
                Thread.Sleep(4000);
                driver.FindElementByXPath("//*[@class='android.widget.TextView' and @text='Feedback']").Click();
                Thread.Sleep(4000);
               
                // Enter Name on name text box
                driver.FindElementByXPath("//*[@class='android.widget.EditText' and @index='2']").SendKeys("hjfjfjf");
                Thread.Sleep(4000);
                // Enter Email on email text box
                IWebElement email = driver.FindElementByXPath("//*[@class='android.widget.EditText' and @index='4']");
                email.SendKeys("commentsuser@gmail.com");
                driver.HideKeyboard();
                Thread.Sleep(4000);
                // Enter comments on comments text box
                driver.FindElementByXPath("//*[@class='android.widget.EditText' and @index='6']").SendKeys("Don't Have any comments");
                Thread.Sleep(4000);
                driver.HideKeyboard();
                // Click on Submit button
                driver.FindElementByXPath("//*[@class='android.widget.Button' and @index='7']").Click();
                Thread.Sleep(4000);
                // Verify Successful message after sending comment
                IWebElement textValidation= driver.FindElementByXPath("//*[@class='android.view.View' and @index='0']");
                string expsuccess = "Thank you. Your feedback has been sent.";
                string actsuccess = textValidation.Text;
                
                if (expsuccess.Equals(actsuccess))
                {
                    Assert.AreEqual(expsuccess, actsuccess);
                    Console.WriteLine(actsuccess);
                    Console.ReadLine();
                }
                //Click on menu option
                driver.FindElementById("com.mdi.azlottery:id/reveal_icon").Click();
                Thread.Sleep(4000);
                //Click on Drawings and Winners
                driver.FindElementByXPath("//*[@class='android.widget.TextView' and @text='Drawings and Winners']").Click();
                //Thread.Sleep(30000);
                //driver.Manage().Window.Size = new Size(80, 20);
                //Console.WriteLine();
                //int Height = driver.Manage().Window.Size.Height;
                //int Width = driver.Manage().Window.Size.Width;
                //int starty = (int)(Height * 0.80);
                //int startx = (int)(Height * 0.20);
                //int endy = (int)(Width / 2);
                //driver.Swipe(startx, endy, startx, starty, 5000);

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