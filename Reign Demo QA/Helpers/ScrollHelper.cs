using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reign_Demo_QA.Helpers
{
    class ScrollHelper
    {
        public void ScrollToText(string text)
        {
            App.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"" + text + "\").instance(0))"));
        }
    }
}
