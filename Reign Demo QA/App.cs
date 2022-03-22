using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using Reign_Demo_QA.ActivityObjects;
using Reign_Demo_QA.Helpers;
using Reign_Demo_QA.Views;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reign_Demo_QA
{

   static class App
    {
        public static AndroidDriver<AndroidElement> driver;
        public static LoginView Login;
        public static HomeView Home;
        public static SitesView Site;
        public static GalleryView Gallery;
        public static CommentsView Comment;
        public static WaitHelper Wait = new WaitHelper();
        public static ScrollHelper Scroll = new ScrollHelper();
        public static SelectorHelpers Selector = new SelectorHelpers();

        public static void Setup()
        {

            AppiumOptions options = new AppiumOptions();
            options.PlatformName = "Android";
            options.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Samsung A32");
            options.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            options.AddAdditionalCapability(MobileCapabilityType.App, AppDomain.CurrentDomain.BaseDirectory + @"APK\app.apk");
            Uri url = new Uri("http://127.0.0.1:4723/wd/hub");

            driver = new AndroidDriver<AndroidElement>(url, options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Init();
            driver.LaunchApp();
        }


        public static void Init()
        {

            Login = new LoginView(driver);
            Home = new HomeView(driver);
            Site = new SitesView(driver);
            Gallery = new GalleryView(driver);
            Comment = new CommentsView(driver);
        }
    }
}
