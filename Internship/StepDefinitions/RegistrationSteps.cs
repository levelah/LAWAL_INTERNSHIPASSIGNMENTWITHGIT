using Internship.PageObjects;
using Internship.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Internship.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {

        PageObjectRegistration registration;

       public RegistrationSteps()
{
            registration = new PageObjectRegistration();
             }




            [Given(@"I open the Giftrete website")]
        public void GivenIOpenTheGiftreteWebsite()
        {
            Hooks.Driver.Navigate().GoToUrl("https://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();


           }
        
        [Given(@"I click on register")]
        public void GivenIClickOnRegister()
        {
            registration.ClickOnRegister();
        }
        
        [Given(@"I input firstname")]
        public void GivenIInputFirstname()
        {
            registration.EnterFirstName();
        }
        
        [Given(@"I input lastname")]
        public void GivenIInputLastname()
        {
            registration.EnterLasttName();
        }
        

        
        [Given(@"I enter email ""(.*)""")]
        public void GivenIEnterEmail(string p0)
        {
          
        }
        
        [Given(@"I enter mobile number")]
        public void GivenIEnterMobileNumber()
        {
           
        }
        
        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            
        }
        
        [Given(@"I enter confirm password")]
        public void GivenIEnterConfirmPassword()
        {
         
        }
        
        [When(@"I click on signup")]
        public void WhenIClickOnSignup()
        {
          
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
           
        }
    }
}
