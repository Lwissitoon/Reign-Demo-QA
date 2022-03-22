using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using Reign_Demo_QA.ActivityObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace Reign_Demo_QA
{
    [TestClass]
    public class Tests
    {

        [TestInitialize]
        public void Setup()
        {
            App.Setup();

        }
        [TestMethod]
        [DataRow("test", "test2", "230219")]
        public void Login(string username, string lastname,string code)
        {

            App.Login.Signin(username,lastname,code);

            App.Wait.WaitElement(App.Home.HomeBtn);
            Assert.IsTrue(App.Home.HomeBtn.Displayed);

        }
        [TestMethod]
        [DataRow("test", "test2", "230219")]
        public void ViewLocationDetails(string username, string lastname, string code)
        {
            App.Login.Signin(username, lastname, code);

            App.Wait.WaitElement(App.Home.SitesBtn);
            App.Home.SitesBtn.Click();
            App.Selector.RandomSelection(App.Site.SiteLocationCards).Click();

            App.Wait.WaitElement(App.Site.SiteLocationDescription);
            Assert.IsTrue(App.Site.SiteLocationDescription.Displayed);

        }


        [TestMethod]
        [DataRow("test", "test2", "230219","Sample")]
        public void UploadPhotoGallery(string username, string lastname, string code,string title)
        {
            App.Login.Signin(username, lastname, code);

            App.Wait.WaitElement(App.Home.GalleryBtn);
            App.Home.GalleryBtn.Click();

            App.Wait.WaitElement(App.Gallery.CreatePhotoBtn);
            App.Gallery.CreatePhotoBtn.Click();

            Thread.Sleep(3000);
            App.Wait.WaitElement(App.Gallery.SelectPhotoBtn);
            App.Gallery.SelectPhotoBtn.Click();

            App.Wait.WaitElement(App.Gallery.CameraOption);
            App.Gallery.CameraOption.Click();

            App.Wait.WaitElement(App.Gallery.OkBtn);
            App.Gallery.OkBtn.Click();

            App.Wait.WaitElement(App.Gallery.AllowpermissionBtn);
            App.Gallery.AllowpermissionBtn.Click();

            App.Wait.WaitElement(App.Gallery.OkBtn);
            App.Gallery.OkBtn.Click();

            App.Wait.WaitElement(App.Gallery.AllowpermissionBtn);
            App.Gallery.AllowpermissionBtn.Click();
            
            App.Wait.WaitElement(App.Gallery.TakePhotoBtn);
            App.Gallery.TakePhotoBtn.Click();

            App.Wait.WaitElement(App.Gallery.OkBtn);
            App.Gallery.OkBtn.Click();

            App.Wait.WaitElement(App.Gallery.PhotoTitleText);
            App.Gallery.PhotoTitleText.SendKeys(title);

            App.Wait.WaitElement(App.Gallery.SendBtn);
            App.Gallery.SendBtn.Click();


        }

        [TestMethod]
        [DataRow("test", "test2", "230219")]
        public void ViewPhotoDetails(string username, string lastname, string code)
        {
            App.Login.Signin(username, lastname, code);

            App.Wait.WaitElement(App.Home.GalleryBtn);
            App.Home.GalleryBtn.Click();
            App.Selector.LastElement(App.Gallery.Photos).Click();

            App.Wait.WaitElement(App.Gallery.PhotoTitleView);
            Assert.IsTrue(App.Gallery.PhotoTitleView.Displayed);

        }

        [TestMethod]
        [DataRow("test", "test2", "230219","Hello there")]
        public void WriteComment(string username, string lastname, string code,string comment)
        {
            App.Login.Signin(username, lastname, code);

            App.Wait.WaitElement(App.Home.WishesBtn);
            App.Home.WishesBtn.Click();

            App.Wait.WaitElement(App.Comment.CreateWishBtn);
            App.Comment.CreateWishBtn.Click();

            App.Wait.WaitElement(App.Comment.WishEditText);
            App.Comment.WishEditText.SendKeys(comment);

            App.Wait.WaitElement(App.Comment.SendBtn);
            App.Comment.SendBtn.Click();

            App.Scroll.ScrollToText(comment);

            App.Wait.WaitElement(App.Selector.LastElement(App.Comment.Wishes));
            App.Selector.LastElement(App.Comment.Wishes).Click();

            App.Wait.WaitElement(App.Comment.WishTextView);
            Assert.IsTrue(App.Comment.WishTextView.Text==comment);

        }

        [TestCleanup]
        public void CleanUp()
        {

         App.driver.CloseApp();
         App.driver.Quit();
        }

    }
}
