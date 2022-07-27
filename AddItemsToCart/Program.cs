using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AddItemsToCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Url = "https://demos.bellatrix.solutions/";

            var addFalcon9 = driver.FindElement(By.XPath("//A[@href='?add-to-cart=28']"));
            addFalcon9.Click();
            System.Threading.Thread.Sleep(5000);
            
            var protonRocket = driver.FindElement(By.XPath("//A[@href='?add-to-cart=12']"));
            protonRocket.Click();
            System.Threading.Thread.Sleep(5000);

            var checkCart = driver.FindElement(By.XPath("//A[@href='https://demos.bellatrix.solutions/cart/']"));
            checkCart.Click();
            System.Threading.Thread.Sleep(5000);

            driver.Quit();
                
             //var logInButton = driver.FindElement(By.XPath("//button[@name = 'login']"));
            //logInButton.Click();

            //Console.WriteLine("Is Log In button displayed: " + logInButton.Displayed);
        }
    }
}
