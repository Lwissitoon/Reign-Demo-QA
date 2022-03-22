using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reign_Demo_QA.Views
{
    class GalleryView
    {
        public GalleryView(AndroidDriver<AndroidElement> driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/action_create_photo")]
        public IWebElement CreatePhotoBtn { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/photoImageView")]
        public IWebElement SelectPhotoBtn { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/titleEditText")]
        public IWebElement PhotoTitleText { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/sendButton")]
        public IWebElement SendBtn { get; set; }


        [FindsBy(How = How.XPath, Using = "(//*[@resource-id='android:id/text1'])[2]")]
        public IWebElement CameraOption { get; set; }

        [FindsBy(How = How.Id, Using = "com.sec.android.app.camera:id/okay")]
        [FindsBy(How = How.Id, Using = "android:id/button1")]
        public IWebElement OkBtn { get; set; }

        [FindsBy(How = How.Id, Using = "com.android.permissioncontroller:id/permission_allow_foreground_only_button")]
        [FindsBy(How = How.Id, Using = "com.android.permissioncontroller:id/permission_allow_button")]
        public IWebElement AllowpermissionBtn { get; set; }


        [FindsBy(How = How.Id, Using = "com.sec.android.app.camera:id/normal_center_button")]
        public IWebElement TakePhotoBtn { get; set; }


        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/photoImageView")]
        public IList<IWebElement> Photos { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/titleTextView")]
        public IWebElement PhotoTitleView { get; set; }
    }
}
