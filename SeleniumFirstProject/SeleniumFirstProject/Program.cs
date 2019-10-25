using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SeleniumFirstProject
{
 
    class Program
    {
      

        [SetUp]
        public void SetUp()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/site/wp-login.php");
            Console.WriteLine("I set up");
        }

        [Test]
        public void ExecuteTest()
        {
            EAPageObject page = new EAPageObject();
            UserPageObject userPage = page.Login("samchukicat@gmail.com", "test123TestR!");
            

            //SeleniumSetMethod.Click("user_login", PropertyType.Id);
            //SeleniumSetMethod.EnterText("user_login", PropertyType.Id, "test1@gmail.com");
            //SeleniumSetMethod.Click("user_pass", PropertyType.Id);
            //SeleniumSetMethod.EnterText("user_pass", PropertyType.Id, "username");
            //Console.WriteLine("The value from my login field is: " +SeleniumGetMethods.GetText("user_login", PropertyType.Id));
            //Console.WriteLine("The value from my password fields is:" + SeleniumGetMethods.GetText("user_pass", PropertyType.Id));
            //SeleniumSetMethod.Click("rememberme", PropertyType.Id);
            //SeleniumSetMethod.Click("wp-submit", PropertyType.Id);
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Quit();
            Console.WriteLine("I close the test");
        }
    }
}
