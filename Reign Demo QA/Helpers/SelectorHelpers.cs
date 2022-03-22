using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reign_Demo_QA.Helpers
{
    class SelectorHelpers
    {
        public IWebElement RandomSelection(IList<IWebElement>elements)
        {
           return elements[new Random().Next(elements.Count)];
        }


        public IWebElement LastElement(IList<IWebElement> elements)
        {
            return elements[elements.Count-1];
        }


        public void ScrollToText(string text)
        {
            App.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"" + text + "\").instance(0))"));
        }


        public void ScrollUntilEnd( )
        {
            TouchActions action = new TouchActions(App.driver);
            action.Down(10, 10);
            action.Move(50, 50);
            action.Perform();


        }
    }
}
