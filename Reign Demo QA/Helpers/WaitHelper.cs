using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reign_Demo_QA.Helpers
{
     class WaitHelper
    {

        public void WaitElement(IWebElement element, int time=10)
        {
            WebDriverWait wait = new WebDriverWait(App.driver, TimeSpan.FromSeconds(time)); 
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
