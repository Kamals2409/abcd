using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Amazon1.Base;
using Amazon1.Page;

namespace Amazon1.Step
{
    [Binding]
    [Scope(Tag = "AmazonHeader")]
    public class AmazonHeaderSteps : Basepage
    {
        public IWebDriver browser;
        AmazonHeaderPage Header;

        [Given(@"I have naviagate to Amazon")]
        public void GivenIHaveNaviagateToAmazon()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://amazon.co.uk");
            browser.Navigate().Refresh();
        }

        [When(@"I Click on (.*)")]
        public void WhenIClickOn(string link)
        {
            browser = driver;
            Header = new AmazonHeaderPage(browser);
            Header.ClickHeader(link);
        }

        [Then(@"I can see (.*) Pages")]
        public void ThenICanSeePages(string link)
        {
            Header.VerifyHeader(link);
        }

    }
}
