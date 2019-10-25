using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFirstProject
{
    enum PropertyType{
        Id,
        Name,
        LinkText,
        CssText,
        ClassName
    }
    class PropertiesCollection
    {
        public static IWebDriver driver{ get; set; }
    }
}
