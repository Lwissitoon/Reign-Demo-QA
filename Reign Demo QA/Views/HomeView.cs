using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reign_Demo_QA.Views
{
    class HomeView
    {
        public HomeView(AndroidDriver<AndroidElement> driver)
        {
            PageFactory.InitElements(driver, this);
        }



        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/toolbar_title")]
        public IWebElement TitleBar { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/cardView")]
        public IWebElement HomeBtn { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/navigation_sites")]
        public IWebElement SitesBtn { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/navigation_camera")]
        public IWebElement GalleryBtn { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/navigation_wishes")]
        public IWebElement WishesBtn { get; set; }
    }
}
