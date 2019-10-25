using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFirstProject
{
    class SeleniumGetMethods
    {
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");

        }
    }
}
