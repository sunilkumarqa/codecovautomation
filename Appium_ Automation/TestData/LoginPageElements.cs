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
    class LoginPageElements
    {
       
        [FindsBy(How = How.Id, Using = "com.healthifyme.basic:id/btn_login")]
        public IWebElement loginButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class= 'android.widget.EditText' and @resource-id= 'com.healthifyme.basic:id/et_username']")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "com.healthifyme.basic:id/et_password")]
        public IWebElement password { get; set; }


        [FindsBy(How = How.Id, Using = "com.healthifyme.basic:id/btn_login_signup")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class= 'android.widget.TextView' and @text= 'Today']")]
        public IWebElement Todaytext { get; set; }

        [FindsBy(How = How.Id, Using= "com.healthifyme.basic:id/fab_expand_menu_button")]
        public IWebElement MenuHealthyfi { get; set; }

        [FindsBy(How = How.Id, Using= "com.healthifyme.basic:id/fab_add_food")]
        public IWebElement addFoodicon { get; set; }

        [FindsBy(How = How.Id, Using = "com.healthifyme.basic:id/et_track_food")]
        public IWebElement Whatdidyoueat { get; set; }

        [FindsBy(How = How.Id, Using = "com.healthifyme.basic:id/et_search")]
        public IWebElement foodSearch { get; set; }

        [FindsBy(How = How.Id, Using = "com.healthifyme.basic:id/iv_track_icon")]
        public IWebElement foodSearchOne { get; set; }

    }
}
