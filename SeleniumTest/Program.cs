using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace SeleniumTest
{
    class Program
    {
        
        static void Main(string[] args)
        {


        }

        [SetUp]
        public void Init()
        {
            Utility.driver = new FirefoxDriver();
            Utility.driver.Manage().Window.Maximize();
            Utility.driver.Navigate().GoToUrl("http://www.google.ca");
            Console.WriteLine("Init browsers");
        }

        [Test]
        public void MainTest()
        {
            PerformSearch();
            
            Thread.Sleep(3000);
            NavigateToSite();
            
            Thread.Sleep(3000);
            LogIn();
            
            Thread.Sleep(3000);

            string ownerName = GetValue.GetText("_2dpb", PropertyType.Class);

            if(ownerName.Equals("Rustam"))
                Console.WriteLine("The ownername is match : {0}",ownerName);
            else
                Console.WriteLine("The ownername is not match : {0}", ownerName);

        }


        public void PerformSearch()
        {
            IWebElement txtSearch = Utility.driver.FindElement(By.Name("q"));
            txtSearch.SendKeys("facebook");

            IWebElement btnSearch = Utility.driver.FindElement(By.Name("btnK"));
            btnSearch.Submit();

            Console.WriteLine("Perform search");
        }

        public void NavigateToSite()
        {            
            IWebElement link = Utility.driver.FindElement(By.LinkText("Facebook Login"));
            
            string url = link.GetAttribute("text");
            Console.WriteLine("Link text is {0}" , url );

            if (url.Contains("Facebook Login"))
            {
                link.Click();
            }
        }

        public void LogIn()
        {
            // set email
            SetValue.EnterText("email", "campaio2009@gmail.com", PropertyType.Id);

            // set password
            SetValue.EnterText("pass", "Rustam_Lena06", PropertyType.Id);

            // click on Login button
            SetValue.Click("u_0_2", PropertyType.Id);
        }

        [TearDown]
        public void CleanUp()
        {
            //Utility.driver.Close();
            //Console.WriteLine("Close browser");
        }
    }
}
