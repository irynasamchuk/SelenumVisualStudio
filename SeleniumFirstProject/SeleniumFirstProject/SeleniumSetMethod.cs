using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFirstProject
{
    public static class SeleniumSetMethod
    {
        //extention of the custom methods 
        public static void EnterTextOwn(this IWebElement element, string value) {

            element.SendKeys(value);
   
        }

        //extention of the custom methods 
        public static void ClickOwn(this IWebElement element)
        {
            element.Click();
        }

        public static void SelectDropDown(string element, string value)
        {

         //   new SelectElement(element.SelectByText(value));
            
        }
      
    }
}
