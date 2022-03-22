using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using Reign_Demo_QA.Views;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reign_Demo_QA.ActivityObjects
{
     class  SitesView
    {
        public SitesView(AndroidDriver<AndroidElement> driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/card_layout")]
        public  IList<IWebElement> SiteLocationCards { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/siteDescription")]
        public IWebElement SiteLocationDescription { get; set; }

    }
}
