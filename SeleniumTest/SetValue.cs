using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumTest
{
    class SetValue
    {

        public static void EnterText(string field, string value, PropertyType fieldType)
        {
            if (fieldType == PropertyType.Id)
                Utility.driver.FindElement(By.Id(field)).SendKeys(value);

            if (fieldType == PropertyType.Name)
                Utility.driver.FindElement(By.Name(field)).SendKeys(value);
        }

        public static void Click(string field, PropertyType fieldType)
        {
            if (fieldType == PropertyType.Id)
                Utility.driver.FindElement(By.Id(field)).Click();

            if (fieldType == PropertyType.Name)
                Utility.driver.FindElement(By.Name(field)).Click();
        }

        public static void SelectDropDownValue(string field, string value, PropertyType fieldType)
        {
            if (fieldType == PropertyType.Id)
                new SelectElement(Utility.driver.FindElement(By.Id(field))).SelectByValue(value);

            if (fieldType == PropertyType.Name)
                new SelectElement(Utility.driver.FindElement(By.Name(field))).SelectByValue(value);
 
        }
    }
}
