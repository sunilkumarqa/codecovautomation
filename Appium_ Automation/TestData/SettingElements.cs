using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium__Automation.TestData
{
  public  class AndroidSettingElements
    {
      [FindsBy(How = How.XPath, Using = "//*[@text= 'Apps']")]
      public IWebElement AppLink { get; set; }

    }
}
