using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium__Automation.TestData
{
    public class BigBasketElements
    {
        //Login Page Elements

         [FindsBy(How = How.Id, Using = "com.bigbasket.mobileapp:id/btn_login")]
         public IWebElement LoginHomepage { get; set; }

         [FindsBy(How = How.Id, Using = "com.bigbasket.mobileapp:id/email_input")]
         public IWebElement EmailField { get; set; }

         [FindsBy(How = How.Id, Using = "com.bigbasket.mobileapp:id/edit_text_passwd")]
         public IWebElement PasswordField { get; set; }

         [FindsBy(How = How.Id, Using = "com.bigbasket.mobileapp:id/btn_login")]
         public IWebElement LoginButton { get; set; }

        //Dasgboard Page Eleements

         [FindsBy(How = How.Id, Using = "com.bigbasket.mobileapp:id/txtPinnedTitle")]
        public IWebElement DashBoardValidation { get; set; }

         [FindsBy(How = How.Id, Using = "com.bigbasket.mobileapp:id/action_search")]
         public IWebElement searchIcon { get; set; }


         [FindsBy(How = How.Id, Using = "com.bigbasket.mobileapp:id/searchView")]
         public IWebElement searchTextBox { get; set; }

         [FindsBy(How = How.XPath, Using = "//*[@resource-id = 'com.bigbasket.mobileapp:id/txtTerm' and @text= 'milk']")]
         public IWebElement milkOption { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@class = 'android.widget.TextView' and @resource-id = 'com.bigbasket.mobileapp:id/btnAddToBasket'")]
         //public IWebElement NandiniGoodLife { get; set; }

         [FindsBy(How = How.Id, Using = "com.bigbasket.mobileapp:id/btnAddToBasket")]
         public IWebElement NandiniGoodLife { get; set; }

         [FindsBy(How = How.Id, Using = "com.bigbasket.mobileapp:id/viewIncBasketQty")]
         public IWebElement NandiniGoodLifeADDquantity { get; set; }

         [FindsBy(How = How.Id, Using = "com.bigbasket.mobileapp:id/txtInBasket")]
         public IWebElement Noquantity { get; set; }


         [FindsBy(How = How.Id, Using = "com.bigbasket.mobileapp:id/applyFilter")]
         public IWebElement Filter { get; set; }

         [FindsBy(How = How.Id, Using = "com.bigbasket.mobileapp:id/filter_category_expend_collapse_btn")]
         public IWebElement CollapseButton { get; set; }

         [FindsBy(How = How.XPath, Using = "//*[@text= 'Beverages']")]
         public IWebElement BeveragesButton { get; set; }


         [FindsBy(How = How.XPath, Using = "//*[@text= 'Branded  Foods']")]
         public IWebElement BrandedFoodsButton { get; set; }


         [FindsBy(How = How.Id, Using = "com.bigbasket.mobileapp:id/btnApply")]
         public IWebElement DoneButtonCatagories { get; set; }

         [FindsBy(How = How.XPath, Using = "//*[@text= 'Sort by']")]
         public IWebElement sortByTab { get; set; }

         [FindsBy(How = How.Id, Using = "com.bigbasket.mobileapp:id/basketimageview")]
         public IWebElement CartSummary { get; set; }
       

    }



}
