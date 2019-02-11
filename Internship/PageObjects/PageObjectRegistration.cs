using Internship.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.PageObjects
{
    class PageObjectRegistration
    {
        public PageObjectRegistration()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }


        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement register { get; set; }

        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement firstName { get; set; }

        [FindsBy(How = How.Name, Using = "last_name")]
        private IWebElement lastName { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement emailAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text-center > button")]
        private IWebElement signUp { get; set; }

        [FindsBy(How = How.Name, Using = "mobile")]
        private IWebElement mobile { get; set; }


        public void EnterMobile()
        {
            mobile.SendKeys("074568906");

        }


            public void ClickSignUP()
        {
            signUp.Click();
        }
        public void ClickOnRegister()
        {
            register.Click();
        }
        public void EnterFirstName()
        {
            firstName.SendKeys("Lawal");

        }
        public void EnterLasttName()
        {

            lastName.SendKeys("Ola");
        }


        public void EnterEmaillAddress(string email)
        {
            emailAddress.SendKeys("email");
        }

    }

    
   }