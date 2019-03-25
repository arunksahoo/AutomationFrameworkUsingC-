using AutomationTesting.CustomMethods;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.TestClass
{
    class ExcuteTest
    {
        
        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Intilize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("User able to redirect page");
        }

        [Test]
        public void Excute()
        {
            BasePageObject page = new BasePageObject();
            page.txtInitial.SendKeys("arun");
            page.btnSave.Click();


            //Title
         //   SeleniumSetMethods.SelectDropdown("TitleId", "Mr.", PropertyType.Id);
            //Intial
        //    SeleniumSetMethods.EnterText("Initial", "arun", PropertyType.Name);
         //   Console.WriteLine("The value from my title is :" +  SeleniumGetMethods.DropdownListText("TitleId", PropertyType.Id));
         //   Console.WriteLine("The value from my Name is :" +  SeleniumGetMethods.GetText("Initial", PropertyType.Name));
            // Click
         //   SeleniumSetMethods.Click("Save", PropertyType.Name);
            Console.WriteLine("User able save data");

        }
        [TearDown]
        public void CloseBrowser()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Browser is closed");
        }

    }
}
