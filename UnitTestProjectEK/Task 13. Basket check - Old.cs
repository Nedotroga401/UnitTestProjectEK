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
    public class BasketCheckOld

    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public bool IsPriceNull(IWebElement element)
        {
            string price = driver.FindElement(By.CssSelector("[class=price]")).GetAttribute("price");
            if (price != "0")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsSizePresent(IWebElement element)
        {
            IList<IWebElement> size = driver.FindElements(By.Name("option[Size]"));
            if (size.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        [Test]
        public void WaitForBasketOld()
        {
            //driver.Url = "http://localhost:8080/litecart/";
            driver.Url = "https://litecart.stqa.ru/en/";

            for (int i = 0; i < 3; i++)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                IWebElement product = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=manufacturer]")));
                IList<IWebElement> allproducts = driver.FindElements(By.ClassName("manufacturer"));
                allproducts[i].Click();

                if (IsSizePresent(allproducts[i]))
                {
                    IWebElement sizeoption = driver.FindElement(By.Name("option[Size]"));
                    SelectElement selector = new SelectElement(sizeoption);
                    selector.SelectByIndex(1);
                }

                if (!IsPriceNull(allproducts[i]))
                {
                    IWebElement button = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[name=add_cart_product]")));
                    button.Click();
                    driver.Navigate().Refresh();
                    IWebElement cartitems = driver.FindElement(By.CssSelector("[class=quantity]"));
                    string ii = i.ToString();
                    wait.Until(ExpectedConditions.TextToBePresentInElementValue(cartitems, ii));
                    driver.Navigate().Back();
                }
            }

            IWebElement cart = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=quantity]")));
            cart.Click();
            IList<IWebElement> table = driver.FindElements(By.CssSelector("[class=shortcut]"));
            int number = table.Count;

            for (int j = 0; j < number; j++)
            {

                IWebElement pr = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("remove_chart_item")));
                pr.Click();
                IWebElement result = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[tag=table]")));
            }

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("[tag=table]")));
        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }


    }*/
}
