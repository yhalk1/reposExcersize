using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoQA.POM
{
    public class TextBoxPage
    {
        [FindsBy(How = How.Id, Using = "userName")]
        private IWebElement FullNameTextBox;

        [FindsBy(How = How.Id, Using = "currentAddress")]
        private IWebElement AddressTextBox;

        [FindsBy(How = How.Id, Using = "submit")]
        private IWebElement SubmitButton;   

        [FindsBy(How = How.XPath, Using = "//p[@id='name']")]
        private IWebElement ActualFN;

        [FindsBy(How = How.XPath, Using = "//p[@id='currentAddress']")]
        private IWebElement ActualAdd;

        [FindsBy(How = How.XPath, Using = "//button[@title='Toggle']")]
        private IWebElement MainCheckBox;
        
        [FindsBy(How = How.XPath, Using = "//label[@for='tree-node-documents']/preceding-sibling::*[@title='Toggle']")]
        private IWebElement DocumentsCheckBox;

        [FindsBy(How = How.XPath, Using = "//label[@for='tree-node-workspace']/preceding-sibling::*[@title='Toggle']")]
        private IWebElement WorkspaceCheckBox;

        [FindsBy(How = How.XPath, Using = "//label[@for='tree-node-angular']")]
        private IWebElement AngularCheckBox;

        [FindsBy(How = How.XPath, Using = "//input[@id='tree-node-angular']")]
        private IWebElement IsAngularCheckBox;

        [FindsBy(How = How.XPath, Using = "//span[@class='text-success']")]
        private IWebElement ActualText;
        
        [FindsBy(How = How.XPath, Using = "//label[@for='yesRadio']")]
        private IWebElement RadioButtonYes;

        [FindsBy(How = How.XPath, Using = "//input[@id='yesRadio']")]
        private IWebElement RadioButtonYesSelect;

        [FindsBy(How = How.XPath, Using = "//span[@class='text-success']")]
        private IWebElement RadioButtonYesText;

        [FindsBy(How = How.XPath, Using = "//input[@id='noRadio']")]
        private IWebElement RadioButtonNoState;

        [FindsBy(How = How.XPath, Using = "//div[@class='main-header']")]
        private IWebElement ButtonPageTitle;


        public TextBoxPage EnterFullName(string name)
        {
            FullNameTextBox.SendKeys(name);
            return this;
        }

        public TextBoxPage EnterAddress(string address)
        {
            AddressTextBox.SendKeys(address);
            return this;
        }

        public TextBoxPage ClickSubmit()
        {
            SubmitButton.Click();
            return this;
        }   

        public string ActualFullName()
        {
            return ActualFN.Text.Replace("Name:", "");
        }

        public string ActualAddress()
        {
            return ActualAdd.Text.Replace("Current Address :", "");
        }

        public TextBoxPage ClickMainCheckBox()
        {
            MainCheckBox.Click();
            return this;
        }

        public TextBoxPage ClickDocumentsCheckBox()
        {
            DocumentsCheckBox.Click();
            return this;
        }

        public TextBoxPage ClickWorkspaceCheckBoxCheckBox()
        {
            WorkspaceCheckBox.Click();
            return this;
        }
        
        public TextBoxPage ClickAngularCheckBox()
        {
            AngularCheckBox.Click();
            return this;
        }

        public bool IsAngularCheckBoxChecked()
        {
            return IsAngularCheckBox.Selected;
           
        }
        public string CheckActualText()
        {
            return ActualText.Text;

        }

        public TextBoxPage ClickRadioButtonYes()
        {
            RadioButtonYes.Click();
            return this;
        }

        public bool IsRadioButtonYesSelected()
        {
            return RadioButtonYesSelect.Selected;

        }

        public string CheckRadioButtonYesText()
        {
            return RadioButtonYesText.Text;

        }

        public bool IsRadioButtonNoEnabled()
        {
            return RadioButtonNoState.Enabled;

        }

        public string CheckButtonPageTitle()
        {
            return ButtonPageTitle.Text;

        }

    }
}
