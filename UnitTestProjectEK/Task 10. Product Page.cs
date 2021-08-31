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
{
    [TestFixture]
    public class CheckProductPage

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

        public int[] ColorParse(string sColor)
        {
            int[] color = new int[3];
            string gC = sColor.Remove(0, 5).Replace(" ", "");
            string[] gs = gC.Split(',');
            for (int i=0; i<3; i++)
            {
                color[i] = Int32.Parse(gs[i]);
            }
            Console.WriteLine(color[0] + "/" + color[1]+ "/" + color[2]);
            return color;
        }

        [Test]
        public void ChekProductPage()
        {
            driver.Url = "http://localhost:8080/litecart/";
            IWebElement button = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("box-campaigns")));

            //Check Campaign Page
           
            string nameOnPage = button.FindElement(By.CssSelector("[class=name]")).Text;
            IWebElement campaignProduct = button.FindElement(By.CssSelector("[class=campaign-price]"));
            IWebElement regularProduct = button.FindElement(By.CssSelector("[class=regular-price]"));
            string priceOnPage = campaignProduct.Text;
            string regularPrice = regularProduct.Text;
            string gColor = regularProduct.GetCssValue("color");
            int[] gs = ColorParse(gColor);
            string rColor = campaignProduct.GetCssValue("color");
            int[] rs = ColorParse(rColor);
            string greyStyle = regularProduct.GetCssValue("text-decoration");
           
            string greyS = regularProduct.GetCssValue("font-size");
            int.TryParse(greyS, out int greySizeNum);

            string redS = campaignProduct.GetCssValue("font-size");
            int.TryParse(redS, out int redSizeNum);

            
            bool priceSizeCampaign;
             if (redSizeNum > greySizeNum)
             {
                 priceSizeCampaign = true;
             }
             else
             {
                 priceSizeCampaign = false;
             }
             

            string redStyle = campaignProduct.GetCssValue("font-weight");
            int.TryParse(redStyle, out int v);
           

            //Open Product Page
            button.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[class=content]")));
            string nameProduct = button.FindElement(By.CssSelector("[class=name]")).Text;

            IWebElement regProduct = driver.FindElement(By.CssSelector("[class=regular-price]"));
            IWebElement camProduct = driver.FindElement(By.CssSelector("[class=campaign-price]"));

            string greyStyleP = regProduct.GetCssValue("text-decoration");

            string priceAfter = camProduct.Text;
            string regularPriceAfter = regProduct.Text;
            string greyColor = regProduct.GetCssValue("color");
            string redColor = camProduct.GetCssValue("color");
            int[] gss = ColorParse(greyColor);
            int[] rss = ColorParse(redColor);

            string redSize = camProduct.GetCssValue("font-size");
            int.TryParse(redSize, out int redProductSize);
            

            string greySize = regProduct.GetCssValue("font-size");
            int.TryParse(greySize, out int greyProductSize);

            bool priceSizeProduct;
             if (redProductSize > greyProductSize)
             {
                 priceSizeProduct = true;
             }
              else
             {
                 priceSizeProduct = false;
             }

            string greyStylep = regularProduct.GetCssValue("text-decoration");

            if (greyStylep.Contains("line-through"))
            {
                Console.WriteLine("Grey text is line-through");
            }

            string redStylep = campaignProduct.GetCssValue("font-weight");
            int.TryParse(redStylep, out int vv);

            //Compare Part

            //Part a) name
            if (nameProduct == nameOnPage)
            {
                Console.WriteLine("Name is the same on both page");
            }

            //Part b) Price

            if (priceOnPage == priceAfter && regularPrice == regularPriceAfter)
            {
                Console.WriteLine("Price is the same on both page");
            }

            //Part c) Regular Price

            if (gss[0] == gs[1] && gss[1] == gs[2])
            {
                Console.WriteLine("Regular price color is grey on product page");
            }

            if (gs[0] == gs[1] && gs[1] == gs[2])
            {
                Console.WriteLine("Regular price color is grey on main page page");
            }

            if (greyStyle.Contains("line-through") && greyStyleP.Contains("line - through"))
            {
                Console.WriteLine("Regular Price is line-through on both pages");
            }
            

            //Part d) Campaign Price

            if (rss[1] == 0 && rss[2] == 0)
            {
                Console.WriteLine("Campaign price color is red on product page");
            }

            if (rs[1] == 0 && rs[2] == 0)
            {
                Console.WriteLine("Campaign price color is red on main page");
            }


            //Part e) Price size

            if (priceSizeCampaign && priceSizeProduct)
            {
                Console.WriteLine("Red text is bigger on both pages");
            }


        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }


    }
}
