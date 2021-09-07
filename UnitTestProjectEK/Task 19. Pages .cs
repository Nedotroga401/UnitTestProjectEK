using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
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
    public class ProductCheck

    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void LoginAs(string name, string pass)
        {

        }

        [Test]
        public void WaitForBasket()
        {
           // driver.Url = "http://localhost:8080/litecart/";
            driver.Url = "https://litecart.stqa.ru/en/";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement carquantityTemp = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[class=quantity]")));

            for (int i = 0; i < 3; i++)
            {
                IList<IWebElement> allproducts = driver.FindElements(By.ClassName("manufacturer"));
                IWebElement waitpage = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[id=box-latest-products]")));
                allproducts[i].Click();

               IList<IWebElement> size = driver.FindElements(By.CssSelector("select"));
               int s = size.Count;

                if (s!=0)
                {
                    IWebElement sizeElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[class=options]")));
                    sizeElement.Click();
                    IWebElement sizeoption = driver.FindElement(By.CssSelector("select"));
                    SelectElement selector = new SelectElement(sizeoption);
                    sizeoption.Click();
                    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("option")));
                    selector.SelectByIndex(1);
                    
                    IWebElement button1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[name=add_cart_product]")));
                    button1.Click();
                    string ii = (i+1).ToString();
                    IWebElement elementCart = driver.FindElement(By.CssSelector("[class=quantity]"));
                    
                    wait.Until(ExpectedConditions.TextToBePresentInElement(elementCart, ii));
                    driver.Navigate().GoToUrl("https://litecart.stqa.ru/en/");
                }
                else
                {
                    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[class=index]")));
                    IWebElement button = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[name=add_cart_product]")));
                    button.Click();
                    string ii = (i+1).ToString();
                    IWebElement elementCart = driver.FindElement(By.CssSelector("[class=quantity]"));
                    wait.Until(ExpectedConditions.TextToBePresentInElement(elementCart, ii));
                    driver.Navigate().GoToUrl("https://litecart.stqa.ru/en/");
                    
                }
            }

             IWebElement carquantity = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[class=quantity]")));
             carquantity.Click();

             wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=shortcuts]")));
             IWebElement ShortCut = driver.FindElement(By.CssSelector("[class=shortcuts]"));
             IList<IWebElement> ShortCuts = ShortCut.FindElements(By.CssSelector("[class=shortcut]"));
            ShortCuts[0].Click();
            int ShortCutsCount = ShortCuts.Count;

            for (int j = 0; j < ShortCutsCount; j++)
            {
                IList<IWebElement> order = driver.FindElements(By.Id("order_confirmation-wrapper"));
                int orderCount = order.Count;
                
                if (orderCount != 0)
                {
                   IList<IWebElement> elements = order[0].FindElements(By.CssSelector("[class=item]"));
                   string str = elements[j].Text;
                   wait.Until(ExpectedConditions.InvisibilityOfElementWithText(By.CssSelector("[class=item]"), str));
                    
                }

                IWebElement pr = driver.FindElement(By.Name("remove_cart_item"));
                pr.Click();

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
