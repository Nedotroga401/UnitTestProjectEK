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
using OpenQA.Selenium.Support.Events;
using SeleniumExtras.WaitHelpers;

namespace UnitTestProjectEK
{
   [TestFixture]
    public class ProductCheck

    {
        private EventFiringWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Start()
        {
            driver = new EventFiringWebDriver(new ChromeDriver());
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //driver.FindingElement += (sender, e) => Console.WriteLine(e.FindMethod);
            //driver.FindElementCompleted += (sender, e) => Console.WriteLine(e.FindMethod + " found");
           // driver.ExceptionThrown += (sender, e) => Console.WriteLine(e.ThrownException);
        }

        public void getBrowserLogs()
        {
            driver.Url = "http://localhost:8080/litecart/";
            foreach (LogEntry l in driver.Manage().Logs.GetLog("browser"))
            {
                Console.WriteLine(l);
            }
        }

        [Test]
        public void WaitForBasket()
        {
            driver.Url = "http://localhost:8080/litecart/admin/";
            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            driver.FindElement(By.Name("login")).Click();
            driver.Url = "http://localhost:8080/litecart/admin/?app=catalog&doc=catalog&category_id=1";
           

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement contentTemp = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("content")));


            IList<IWebElement> productsTemp = contentTemp.FindElements(By.CssSelector("[href*='app=catalog&doc=edit_product&category_id']"));
            int count = productsTemp.Count;

            for (int i = 0; i < count; i++)
            {
                IWebElement content = wait.Until(ExpectedConditions.ElementExists(By.Id("content")));
                IList<IWebElement> products = content.FindElements(By.CssSelector("[href*='app=catalog&doc=edit_product&category_id']"));
                products[i].Click();
                wait.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=active]")));
                driver.Navigate().GoToUrl("http://localhost:8080/litecart/admin/?app=catalog&doc=catalog&category_id=1");
                i++;

                
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
