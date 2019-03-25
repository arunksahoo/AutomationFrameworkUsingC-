using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.CustomMethods
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);

        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement TitleId { get; set; }

        [FindsBy(How = How.Id, Using = "Intial")]
        public IWebElement textIntial { get; set; }

        [FindsBy(How = How.Id, Using = "Save")]
        public IWebElement btnSave { get; set; }
    }
}
