using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    enum PropertyType
    {
        Id, Name, LinkText, CssName,Class
    }

    class Utility
    {


        public static IWebDriver driver { get; set; }
    }
}
