using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Internship.Utilities
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver Driver;

    

        [BeforeScenario]
        public void BeforeScenario()
        {
             Driver = new ChromeDriver();

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
