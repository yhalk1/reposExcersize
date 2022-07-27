using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQAPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/text-box";
            var fullName = driver.FindElement(By.Id("userName"));
            fullName.SendKeys("321");

            var currentAddress = driver.FindElement(By.Id("currentAddress"));
            currentAddress.SendKeys("2312");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");

            var submit = driver.FindElement(By.Id("submit"));
            submit.Click();

            string actualResult = driver.FindElement(By.XPath("//p[@id='name']")).Text.Trim('N','a','m','e',':');
            Console.WriteLine("String: " + actualResult);

            System.Threading.Thread.Sleep(5000);

            driver.Quit();
        }
    }
}
