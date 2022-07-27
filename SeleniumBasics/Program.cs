using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Url = "https://demos.bellatrix.solutions/";

            var myAccount = driver.FindElement(By.XPath("//A[@href='https://demos.bellatrix.solutions/my-account/']"));
            myAccount.Click();
            
            var logInButton = driver.FindElement(By.XPath("//button[@name = 'login']"));
            logInButton.Click();

            Console.WriteLine("Is Log In button displayed: " + logInButton.Displayed);

            
        }
    }
}
