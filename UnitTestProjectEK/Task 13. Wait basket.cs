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
{/*
    [TestFixture]
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

        public void WaitChange(int i)
        {
            string ii = i.ToString();
            driver.Navigate().Refresh();
            IWebElement element = driver.FindElement(By.CssSelector("[class=quantity]"));
            wait.Until(ExpectedConditions.TextToBePresentInElement(element, ii));
            driver.Navigate().GoToUrl("http://localhost:8080/litecart/");
        }

        [Test]
        public void WaitForBasket()
        {
            driver.Url = "http://localhost:8080/litecart/";

            for (int i = 0; i < 3; i++)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement product = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=manufacturer]")));
                IList<IWebElement> allproducts = driver.FindElements(By.ClassName("manufacturer"));
                allproducts[i].Click();

                string price = driver.FindElement(By.CssSelector("[class=price]")).GetAttribute("price");
                

                if (price != "0")
                {
                    IList<IWebElement> size = driver.FindElements(By.Name("option[Size]"));
                    if (size.Count == 0)
                    {
                        IWebElement button =
                            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[name=add_cart_product]")));
                        button.Click();

                        string ii = i.ToString();
                        driver.Navigate().Refresh();
                        IWebElement element = driver.FindElement(By.CssSelector("[class=quantity]"));
                        wait.Until(ExpectedConditions.TextToBePresentInElement(element, ii));
                        driver.Navigate().GoToUrl("http://localhost:8080/litecart/");
                    }
                    else
                    {
                        IWebElement sizeoption = driver.FindElement(By.Name("option[Size]"));
                        SelectElement selector = new SelectElement(sizeoption);
                        selector.SelectByIndex(1);
                        IWebElement addcart = driver.FindElement(By.CssSelector("[name=add_cart_product]"));
                        addcart.Click();

                        string ii = i.ToString();
                        driver.Navigate().Refresh();
                        IWebElement element = driver.FindElement(By.CssSelector("[class=quantity]"));
                        wait.Until(ExpectedConditions.TextToBePresentInElement(element, ii));
                        driver.Navigate().GoToUrl("http://localhost:8080/litecart/");
                    }
                }
                else
                {
                    i--;
                    driver.Navigate().GoToUrl("http://localhost:8080/litecart/");
                    wait.Until(ExpectedConditions.ElementExists(By.ClassName("manufacturer")));
                }
            }
           
           IWebElement cart = driver.FindElement(By.CssSelector("[class=quantity]"));
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
