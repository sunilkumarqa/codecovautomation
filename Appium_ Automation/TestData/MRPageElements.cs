using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium__Automation.TestData
{
    public class MRPageElements
    {
        //Login Page Elements

         [FindsBy(How = How.XPath, Using = "//*[@id='com.mdi.mdlottery:id/reveal_icon']")]
         public IWebElement MenuOption { get; set; }

         [FindsBy(How = How.Name, Using = "ePlayslip")]
         public IWebElement ePaySlipOption { get; set; }

        [FindsBy(How = How.Name, Using = "New ePlayslip")]
         public IWebElement newEPaySlipOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='android.widget.TextView' and @text='Drawings and Winners']")]
        public IWebElement drawingsOption { get; set; }

        
    }



}
