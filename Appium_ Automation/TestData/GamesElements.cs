using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium__Automation.TestData
{
  public  class GamesElements
    {

      [FindsBy(How = How.XPath, Using = "//*[@id = 'com.mdi.azlottery:id/reveal_icon']")]
      public IWebElement MenuOption { get; set; }

      [FindsBy(How = How.XPath, Using = "//*[@class='android.widget.TextView' and @text='Prize Store']")]
      public IWebElement PrizeStore { get; set; }

      [FindsBy(How = How.XPath, Using = "//*[@class= 'android.view.View' and @index= '3']")]
      public IWebElement BestSellers { get; set; }

      [FindsBy(How = How.XPath, Using = "//*[@class= 'android.view.View' and @index= '4']")]
      public IWebElement OnSale { get; set; }

    }
}
