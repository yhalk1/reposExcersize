using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LoginWrongCredendtials
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

            //var userNameOrMail = driver.FindElement(By.Id("username"));

            var userNameOrMail = driver.FindElement(By.XPath("//input[@name = 'username']"));
            userNameOrMail.SendKeys("Hello World");

            var password = driver.FindElement(By.Id("password"));
            password.SendKeys("Multipass");

            System.Threading.Thread.Sleep(3000);

            var login = driver.FindElement(By.XPath("//button[@name = 'login']"));
            login.Click();

            System.Threading.Thread.Sleep(5000);

            driver.Quit();

        }
    }
}
