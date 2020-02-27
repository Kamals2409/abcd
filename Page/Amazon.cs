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
    public class Amazon
    {
        public IWebDriver Driver;

        public Amazon(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.Id, Using = "nav-logo")]
        public IWebElement K;

        public void Homepage()
        {
            K.Displayed.Should().BeTrue();
        }
    } 

}
  