using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UnitTestProjectEK
{
   /* [TestFixture]
    public class WaitBasket

    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Test]
        public void WaitForBasket()
        {
            driver.Url = "http://localhost:8080/litecart/";

            for (int i = 0; i < 3; i++)
            {
                WebDriverWait waitall = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                IWebElement product = waitall.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=manufacturer]")));
                IList<IWebElement> allproducts = driver.FindElements(By.ClassName("manufacturer"));
                allproducts[i].Click();
                WebDriverWait waitaButton = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                IWebElement button = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[name=add_cart_product]")));
                button.Click();
                WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                IWebElement element = wait3.Until(ExpectedConditions.ElementExists(By.ClassName("quantity")));
                driver.Navigate().GoToUrl("http://localhost:8080/litecart/");
            }

           WebDriverWait waitcart = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
           IWebElement cart = waitcart.Until(ExpectedConditions.ElementExists(By.ClassName("quantity")));
           cart.Click();
           

            for (int j = 0; j < 3; j++)
            {

               
                WebDriverWait waitpr = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                IWebElement pr = waitpr.Until(ExpectedConditions.ElementIsVisible(By.Name("remove_chart_item")));
                pr.Click();
                IWebElement result = waitpr.Until(ExpectedConditions.ElementExists(By.CssSelector("[tag=table]")));
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
