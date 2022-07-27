using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoQA
{
    public class PageManager
    {
        public static T GetPage<T>(IWebDriver driver) where T : new() 
        {
            var page = new T();
            PageFactory.InitElements(driver, page);
            return page;
        }

    }
}
