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
    public class AmazonHeaderPage
    {
        public IWebDriver Driver;

        public AmazonHeaderPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }
        [FindsBy(How = How.PartialLinkText, Using = "AmazonBasics")]
        public IWebElement ClickAmazonBasics;

        [FindsBy(How = How.PartialLinkText, Using = "Today's Deals")]
        public IWebElement ClickTodaysDeal;

        [FindsBy(How = How.PartialLinkText, Using = "Vouchers")]
        public IWebElement ClickVouchers;


      String AmazonBasicsurl = "https://www.amazon.co.uk/stores/node/1649910031/?field-lbr_brands_browse-bin=AmazonBasics&ref_=nav_cs_amazonbasics";

      String TodaysDealurl = "https://www.amazon.co.uk/gp/deals?ref_=nav_cs_gb";

      // String Vouchersurl = "https://www.amazon.co.uk/vouchers-coupons/b/?_encoding=UTF8&node=5522783031&ref_=nav_cs_coupons";

       [FindsBy(How = How.CssSelector, Using = ".bxw-pageheader__title > div > h1")]
       public IWebElement VouchersText;

       // [FindsBy(How = How.CssSelector, Using = "#contentGrid_336757 > div > div > div > div > div > img")]
       // public IWebElement ChristmasShopLogo;

       // [FindsBy(How = How.ClassName, Using = "gbh1 - bold")]
      // public IWebElement TodaysDealText;
        public void ClickHeader(string link)
        {
            switch (link)
            {
                case "AmazonBasics":
                  ClickAmazonBasics.Click();
                    break;
                case "Today'sDeals":
                    ClickTodaysDeal.Click();
                    break;
                case "Vouchers":
                    ClickVouchers.Click();
                    break;
                default:
                    Console.WriteLine("Wrong Selection");
                    break;
            }
        }
        public void VerifyHeader(string link)
        {
            switch (link)
            {
               case "AmazonBasics":
                   Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    // TodaysDealText.Displayed.Should().BeTrue();
                    Driver.Url.Contains(AmazonBasicsurl).Should().BeTrue();
                    break;
                case "Today'sDeals":
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                  //  ChristmasShopLogo.Displayed.Should().BeTrue();
                   Driver.Url.Contains(TodaysDealurl).Should().BeTrue();
                    break;
                case "Vouchers":
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    VouchersText.Displayed.Should().BeTrue();
                    //Driver.Url.Contains(Vouchersurl).Should().BeTrue();
                    break;
                default:
                    Console.WriteLine("Wrong Selection");
                    break;
            }
        }

    }
}
