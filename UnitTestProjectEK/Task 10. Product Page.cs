using System;
using System.Collections.Generic;
using System.Linq;
using AngleSharp.Html.Dom;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UnitTestProjectEK
{/*
    [TestFixture]
    public class CheckCountries

    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void checkColors(IWebElement element)
        {
            string greyColor = element.FindElement(By.CssSelector("[class=regular-price]")).GetCssValue("color");
            string redColor = element.FindElement(By.CssSelector("[class=campaign-price]")).GetCssValue("color");
        }

        [Test]
        public void ChekProductPage()
        {
            driver.Url = "http://localhost:8080/litecart/";
            IWebElement button = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("box-campaigns")));
            IWebElement campaignProduct = button.FindElement(By.CssSelector("[class=campaign-price]"));
            IWebElement regularProduct = button.FindElement(By.CssSelector("[class=regular-price]"));

            string nameOnPage = button.FindElement(By.CssSelector("[class=name]")).Text;
          
            string priceOnPage = campaignProduct.Text;
            string regularPrice = regularProduct.Text;

            string gColor = regularProduct.GetCssValue("color");
            var gs = gColor.Split(' ').Select(Int32.Parse).ToArray();
            
            
            if (gs[0] == gs[1] && gs[1] == gs[2])
            {
                Console.WriteLine("Regular color is grey");
            }

            string rColor = campaignProduct.GetCssValue("color");
            
            var rs = rColor.Split(' ').Select(Int32.Parse).ToArray();
            if (rs[1]==0 && rs[2]==0)
            {
                Console.WriteLine("Campaign color is red");
            }

            string greyStyle = regularProduct.GetCssValue("text-decoration");
            
           if (greyStyle.Contains("line-through"))
            {
                Console.WriteLine("Grey text is line-through");
            }
           
            string greyS = regularProduct.GetCssValue("font-size");

            string redS = campaignProduct.GetCssValue("font-size");

            int j = String.Compare(redS, greyS);
            if (j > 0)
            {
                Console.WriteLine("Red text is bigger");
            }

            string redStyle = campaignProduct.GetCssValue("font-weight");
            int.TryParse(redStyle, out int v);
            if (v>550)
                Console.WriteLine("Red text is bold");

            button.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[class=content]")));
            IWebElement regProduct = driver.FindElement(By.CssSelector("[class=regular-price]"));
            IWebElement camProduct = driver.FindElement(By.CssSelector("[class=campaign-price]"));
            string priceAfter = camProduct.Text;
            string regularPriceAfter = regProduct.Text;
            

            string greyColor = regProduct.GetCssValue("color");
           
            string redColor = camProduct.GetCssValue("color");


            var gss = greyColor.Split(' ').Select(Int32.Parse).ToArray();
            if (gss[0] == gs[1] && gss[1] == gs[2])
            {
                Console.WriteLine("Regular color on product page is grey");
            }

            
            var rss = redColor.Split(' ').Select(Int32.Parse).ToArray();
            if (rss[1] == 0 && rss[2] == 0)
            {
                Console.WriteLine("Campaign color on product page is red");
            }

            string redSize = camProduct.GetCssValue("font-size");
            string greySize = regProduct.GetCssValue("font-size");
            int i = String.Compare(redSize, greySize);
            if (i > 0)
            {
                Console.WriteLine("Red text is bigger");
            }

            string greyStylep = regularProduct.GetCssValue("text-decoration");

            if (greyStylep.Contains("line-through"))
            {
                Console.WriteLine("Grey text is line-through");
            }

            string redStylep = campaignProduct.GetCssValue("font-weight");
            int.TryParse(redStylep, out int vv);
            if (vv > 550)
                Console.WriteLine("Red text is bold");


            if (priceOnPage == priceAfter && regularPrice==regularPriceAfter)
            { Console.WriteLine("Price is the same");}

            if (priceOnPage == priceAfter)
            {
                Console.WriteLine("Name is the same");
            }




        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }


    }*/
}
