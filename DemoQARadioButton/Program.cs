using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQARadioButton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //todo check that radiobutton is checked and also check the text and 
            //check No radiobutton disabled

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/radio-button";

            driver.FindElement(By.XPath("//label[@for='yesRadio']")).Click();

            IWebElement checkActual = driver.FindElement(By.XPath("//input[@id='yesRadio']"));
            Console.WriteLine("Checkbox is checked? - " + checkActual.Selected);
            Console.WriteLine("Enabled? " + checkActual.Enabled);

            var str = driver.FindElement(By.XPath("//span[@class='text-success']")).Text;
            Console.WriteLine(str);

            IWebElement checkActualEn = driver.FindElement(By.XPath("//input[@id='noRadio']"));
            Console.WriteLine("Radio is enabled? - " + checkActualEn.Enabled);

            System.Threading.Thread.Sleep(5000);

            driver.Quit();

        }
    }
}
