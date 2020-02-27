using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Amazon1.Base;
using Amazon1.Page;


namespace Amazon1.Step
{
    [Binding]
    [Scope(Tag = "AmazonSignin") ]
    public class Sign_In : Basepage
    {
        public IWebDriver browser;
        AmazonSignin Signin1;

        [Given(@"I navigate to Amazon")]
        public void GivenINavigateToAmazon()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://amazon.co.uk");
        }

        [When(@"I Click SignIn with valid username and password")]
        public void WhenIClickSignInWithValidUsernameAndPassword()
        {
            browser = driver;
            Signin1 = new AmazonSignin(browser);
            Signin1.AmazonSign();
            Signin1.EnterDetails();
        }

        [Then(@"I Sign-In successfully")]
        public void ThenISign_InSuccessfully()
        {
            Signin1.VerifyDetails();
        }

    }
}
