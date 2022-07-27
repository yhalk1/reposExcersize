using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQAPracticeCheckBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/checkbox";

            driver.FindElement(By.XPath("//button[@title='Toggle']")).Click();

            driver.FindElement(By.XPath("(//button[@title='Toggle'])[3]")).Click();

            driver.FindElement(By.XPath("(//button[@title='Toggle'])[4]")).Click();

            driver.FindElement(By.XPath("//label[@for='tree-node-angular']")).Click();

            IWebElement checkActual = driver.FindElement(By.XPath("//input[@id='tree-node-angular']"));
            var str = driver.FindElement(By.XPath("//span[@class='text-success']")).Text;
            Console.WriteLine(str);

            Console.WriteLine("Checkbox is checked? - " + checkActual.Selected);

            System.Threading.Thread.Sleep(5000);

            driver.Quit();
        }
    }
}
