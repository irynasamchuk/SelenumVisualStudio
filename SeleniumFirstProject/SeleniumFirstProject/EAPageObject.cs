using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFirstProject
{
    public class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }


        [FindsBy(How = How.Id, Using = "user_login")]
        public IWebElement txtLogin { get; set; }

        [FindsBy(How = How.Id, Using = "user_pass")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "rememberme")]
        public IWebElement cbRememberMe { get; set; }

        [FindsBy(How = How.Id, Using = "wp-submit")]
        public IWebElement btnLogin { get; set; }


        public UserPageObject Login(string login, string password)
    {
            txtLogin.EnterTextOwn(login);
            txtPassword.EnterTextOwn(password);
            btnLogin.ClickOwn();
            return new UserPageObject();
        }
   }
}
