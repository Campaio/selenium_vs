using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTest
{
    class PageObject
    {
        [FindsBy(How=How.Id,Using="TitleId")]
        public IWebElement MyProperty { get; set; }
    }
}
