using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Amazon1.Base;
using Amazon1.Page;

namespace Amazon1.Step
{
    [Binding]
    [Scope(Tag = "Amazon")]
    public class Amazonsteps : Basepage
    {
        public IWebDriver browser;
        Amazon Home;

        [Given(@"I navigate to Amazon")]
        public void GivenINavigateToAmazon()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://www.amazon.co.uk");
        }

        [Then(@"I see the page loads")]
        public void ThenISeeThePageLoads()
        {
            Home = new Amazon(browser);
            Home.Homepage();
            
        }

    }

}


