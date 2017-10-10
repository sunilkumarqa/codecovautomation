using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium__Automation.TestData
{
   public class CalculatorElements
    {
        [FindsBy(How = How.Id, Using = "com.android.calculator2:id/formula")]
        public IWebElement CalculatorTextField { get; set; }

        [FindsBy(How = How.Id, Using = "com.android.calculator2:id/digit_7")]
        public IWebElement Digit7 { get; set; }

        [FindsBy(How = How.Id, Using = "com.android.calculator2:id/digit_8")]
        public IWebElement Digit8 { get; set; }

        [FindsBy(How = How.Id, Using = "com.android.calculator2:id/op_add")]
        public IWebElement CalculatorADD { get; set; }

        [FindsBy(How = How.Id, Using = "com.android.calculator2:id/op_sub")]
        public IWebElement CalculatorSub { get; set; }


        [FindsBy(How = How.Id, Using = "com.android.calculator2:id/eq")]
        public IWebElement CalculatorEqual { get; set; }
    }

}
