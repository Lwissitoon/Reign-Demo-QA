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
     class  LoginView
    {
        public LoginView(AndroidDriver<AndroidElement> driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/nameEditText")]
        public  IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/lastNameEditText")]
        public IWebElement Lastname { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/codeEditText")]
        public IWebElement Code { get; set; }

        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/logInButton")]
        public IWebElement LogInBtn { get; set; }

        
        [FindsBy(How = How.Id, Using = "com.uharris.wedding:id/cardView")]
        public IWebElement HomeBtn { get; set; }


        public void Signin(string username, string lastname, string code)
        {
            App.Wait.WaitElement(App.Login.Name);
            App.Login.Name.SendKeys(username);
            App.Wait.WaitElement(App.Login.Lastname);
            App.Login.Lastname.SendKeys(lastname);
            App.Wait.WaitElement(App.Login.Code);
            App.Login.Code.SendKeys(code);
            App.Wait.WaitElement(App.Login.LogInBtn);
            App.Login.LogInBtn.Click();
        }
    }
}
