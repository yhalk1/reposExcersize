using System;
using DemoQA.POM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA
{

    [TestClass]
    public class UnitTestElements
    {
        IWebDriver driver;
        IJavaScriptExecutor js;
        TextBoxPage TextBoxPage;

        [TestInitialize]
        public void TestInit()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            driver.Manage().Window.Maximize();
            TextBoxPage = PageManager.GetPage<TextBoxPage>(driver);
        }
        
        [TestCleanup]
        public void TestCleanUp()
        {
            driver.Quit();
        }

        [TestMethod]
        [Ignore]
        [DataRow("Hello", "Everybode", "Hello", "Everybode")]
        public void TestTextbox(string inputFN, string inputAdd, string expectedFN, string expectedAdd)
        {
            //todo enter values in the fields and check that they are present after submit
            //assert actual and expected can be done via data row
            //move all elements to TextBoxPage class

            driver.Url = "https://demoqa.com/text-box";

            TextBoxPage
                .EnterFullName(inputFN)
                .EnterAddress(inputAdd);
            js.ExecuteScript("window.scrollTo(window.innerWidth, window.innerHeight)");

            TextBoxPage.ClickSubmit();

            string actualFN = TextBoxPage.ActualFullName();  
            Console.WriteLine("String actual: " + actualFN);

            string actualAdd = TextBoxPage.ActualAddress();
            Console.WriteLine("String actual: " + actualAdd);

            Assert.AreEqual(expectedFN, actualFN, "Expected and Actual results are not equal");
            Assert.AreEqual(expectedAdd, actualAdd, "Expected and Actual results are not equal");

            System.Threading.Thread.Sleep(5000);
        }

        [TestMethod]
        [Ignore]
        [DataRow(true, "angular")]
        public void TestCheckBox(bool isCheckedExpected, string expectedText)
        {
            //todo check that checkbox is checked and also check the text
            
            driver.Url = "https://demoqa.com/checkbox";

            TextBoxPage
                .ClickMainCheckBox()
                .ClickDocumentsCheckBox()
                .ClickWorkspaceCheckBoxCheckBox()
                .ClickAngularCheckBox();

            var isCheckedActual = TextBoxPage.IsAngularCheckBoxChecked();
            Console.WriteLine("Checkbox is checked? " + isCheckedActual);

            var actualText = TextBoxPage.CheckActualText();
            Console.WriteLine(actualText);

            Assert.AreEqual(isCheckedExpected, isCheckedActual, "Expected and Actual results are not equal");
            Assert.AreEqual(expectedText, actualText, "Expected and Actual results are not equal");

            System.Threading.Thread.Sleep(5000);
        }

        [TestMethod]
        [Ignore]
        [DataRow(true, "Yes", false)]
        public void TestRadioButton(bool expectedYesBtn, string expectedText, bool expectedNoBtn)
        {
            //todo check that radiobutton is checked and also check the text and 
            //check No radiobutton disabled

            driver.Url = "https://demoqa.com/radio-button";

            TextBoxPage.ClickRadioButtonYes();

            var actualYesBtn = TextBoxPage.IsRadioButtonYesSelected();
            Console.WriteLine("Radio is selected? - " + actualYesBtn);

            var actualText = TextBoxPage.CheckRadioButtonYesText();
            Console.WriteLine("Text is " + actualText);

            var actualNoBtn = TextBoxPage.IsRadioButtonNoEnabled();
            Console.WriteLine("Radio is enabled? - " + actualNoBtn);

            Assert.AreEqual(expectedYesBtn, actualYesBtn, "Expected and Actual results are not equal");
            Assert.AreEqual(expectedText, actualText, "Expected and Actual results are not equal");
            Assert.AreEqual(expectedNoBtn, actualNoBtn, "Expected and Actual results are not equal");

            System.Threading.Thread.Sleep(5000);

        }

        // add 3 more tests to check titles of text check radio

        [TestMethod]
        //[Ignore]
        [DataRow("https://demoqa.com/radio-button", "Radio Button")]
        [DataRow("https://demoqa.com/text-box", "Text Box")]
        [DataRow("https://demoqa.com/checkbox", "Check Box")]

        public void TestRadioButtonPageTitle(string url, string expectedTitle)
        {
            //todo check that radiobutton is checked and also check the text and 
            //check No radiobutton disabled

            driver.Url = url;

            var actualTitle = TextBoxPage.CheckButtonPageTitle();
            Console.WriteLine("Button page title is " + actualTitle);

            Assert.AreEqual(expectedTitle, actualTitle, "Expected and Actual results are not equal");

            System.Threading.Thread.Sleep(5000);
        }

    }
}
