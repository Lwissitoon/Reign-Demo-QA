using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reign_Demo_QA.Views
{
    class  CommentsView
    {

        public CommentsView(AndroidDriver<AndroidElement> driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/action_create_wish")]
        public IWebElement CreateWishBtn { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/nameTextView")]
        public IList<IWebElement> Wishes { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/wishEditText")]
        public IWebElement WishEditText { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/sendButton")]
        public IWebElement SendBtn { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/wishTextView")]
        public IWebElement WishTextView { get; set; }
    }
}
