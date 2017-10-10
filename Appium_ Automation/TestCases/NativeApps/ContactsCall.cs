using Appium__Automation.TestData;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appium__Automation;

namespace Appium__Automation.TestCases.NativeApps
{
    public class ContactsCall : ITestCase
    {
        KeyFunctions KeyGeneric = new KeyFunctions();
        DesiredCapabilities capabilities = new DesiredCapabilities();
        ContactsPage contactsElement = new ContactsPage();
        public static AppiumDriver<AndroidElement> driver;

        public void Execute()
        {

            KeyGeneric.CapabilitiesContacts(capabilities);
            driver = new AndroidDriver<AndroidElement>(new Uri(ConfigurationManager.AppSettings["URL"]), capabilities);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            PageFactory.InitElements(driver, contactsElement);
            contactsElement.ActionButton.Click();
            contactsElement.contactname.SendKeys(KeyGeneric.EnterRandomText(7) + "\t");
            contactsElement.PhoneTextbox.SendKeys(KeyGeneric.EnterRandomNo() + "\t");
            contactsElement.SaveMenu.Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            contactsElement.CallIcon.Click();
        }
        

    }
}
