using Appium__Automation.TestCases.NativeApps;
using Appium__Automation.TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ImageFormat = System.Drawing.Imaging.ImageFormat;

namespace Appium__Automation.TestCases.AndroidApps.BigBasket
{
    public class BigBasketFunctionalities : ITestCase
    {
        public static AppiumDriver<AndroidElement> driver;
        KeyFunctions KeyGeneric = new KeyFunctions();
        DesiredCapabilities capabilities = new DesiredCapabilities();
        BigBasketElements BBElement = new BigBasketElements();
       

        public void Execute()
        {
           
            try
            {
                 // BigBasket LogIn
                KeyGeneric.CapabilitiesBigBasket(capabilities);
                driver = new AndroidDriver<AndroidElement>(new Uri(ConfigurationManager.AppSettings["URL"]), capabilities);
                Thread.Sleep(10000);             
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                PageFactory.InitElements(driver, BBElement);
                BBElement.LoginHomepage.Click();
                string userName = "healthyfi787@gmail.com";
                string password = "787healthyfi";
                BBElement.EmailField.SendKeys(userName);
                BBElement.PasswordField.SendKeys(password);
                driver.HideKeyboard();
                BBElement.LoginButton.Click();
                Thread.Sleep(20000);
                //Home Page Validation
               
                string Dashboardtext = BBElement.DashBoardValidation.Text;
                Console.WriteLine(Dashboardtext);
                Assert.AreEqual("Shop By Category", Dashboardtext);
                
                // Click on search Icon
                BBElement.searchIcon.Click();
                // Enter Text on Search field
                IWebElement milkele = BBElement.searchTextBox;
                milkele.SendKeys("milk" + "\t");
                // Click on milk field
                BBElement.milkOption.Click();
                Thread.Sleep(5000);
                // Click on Add milk
                BBElement.NandiniGoodLife.Click();
                 // Click more quantity
                 BBElement.NandiniGoodLifeADDquantity.Click();

                 string Itemcount = BBElement.Noquantity.Text;
                 Console.WriteLine(Itemcount);
                 //Actions act = new Actions(driver); 
                 //act.MoveToElement(BBElement.CartSummary);
                 BBElement.CartSummary.Click();
                 Thread.Sleep(2000);
                 string CartText = driver.FindElementById("com.bigbasket.mobileapp:id/price_productcount").Text;
                 if (CartText.Contains("Items"))
                 {
                     Console.WriteLine(CartText);
                 }
               //IWebElement zoomObject = driver.FindElementById("com.bigbasket.mobileapp:id/imgProduct");
               // zoomObject.Click();
               // driver.Zoom(zoomObject);
               // driver.Zoom(10,15);
                //BBElement.Filter.Click();
                //BBElement.CollapseButton.Click();
                //BBElement.BeveragesButton.Click();
                //BBElement.BrandedFoodsButton.Click();
                //BBElement.DoneButtonCatagories.Click();
                //((AndroidDriver<AndroidElement>)driver).PressKeyCode(AndroidKeyCode.Keycode_HOME);
           
                
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
