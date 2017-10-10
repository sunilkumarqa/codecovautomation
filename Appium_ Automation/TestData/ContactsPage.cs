using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium__Automation.TestData
{
    public class ContactsPage
    {
       
        [FindsBy(How = How.Id, Using = "com.android.contacts:id/floating_action_button")]
        public IWebElement ActionButton{ get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class= 'android.widget.EditText' and @text= 'Name']")]
        public IWebElement contactname { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@text='Phone']")]
        public IWebElement PhoneTextbox{ get; set; }

        [FindsBy(How = How.Id, Using = "com.android.contacts:id/menu_save")]
        public IWebElement SaveMenu{ get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='android.widget.ImageButton'])[2]")]
        public IWebElement Markdone { get; set; }
        
        [FindsBy(How = How.Id, Using = "com.android.contacts:id/icon")]
        public IWebElement CallIcon { get; set; }
        
    }


}
