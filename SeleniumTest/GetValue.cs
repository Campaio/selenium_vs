using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class GetValue
    {
        public static string GetText(string field, PropertyType fieldType)
        {
            if (fieldType == PropertyType.Id)
                return Utility.driver.FindElement(By.Id(field)).Text;

            if (fieldType == PropertyType.Name)
                return Utility.driver.FindElement(By.Name(field)).Text;
            if (fieldType == PropertyType.Class)
                return Utility.driver.FindElement(By.ClassName(field)).Text;
            else return String.Empty;

        }
    }
}
