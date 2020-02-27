using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;
using Shouldly;

namespace Amazon1.Page
{
    public class AmazonSignin
    {
        public IWebDriver Driver;

        public AmazonSignin(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }
        [FindsBy(How = How.ClassName, Using = "nav-line-1")]
        public IWebElement ClickSignIn;

        [FindsBy(How = How.Id, Using = "ap_email")]
        public IWebElement EnterEmail;

        [FindsBy(How = How.Id, Using = "continue")]
        public IWebElement ClickContinue;

        [FindsBy(How = How.Id, Using = "ap_password")]
        public IWebElement EnterPassword;

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        public IWebElement ClickSigninSubmit;

        public string AccountDetails = "Your Account";

        public void AmazonSign()
        {
            ClickSignIn.Click();
        }

        public void EnterDetails()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            EnterEmail.SendKeys("kamalbsharma@gmail.com");
            ClickContinue.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            EnterPassword.SendKeys("Love&amaz156");
            ClickSigninSubmit.Click();
        }

        public void VerifyDetails()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            ClickSignIn.Text.Contains(AccountDetails).Equals("Your Account");
        }
    }
}
