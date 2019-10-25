using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;

namespace SeleniumFirstProject
{
  public class UserPageObject
    {
        public UserPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
    }
}
