using System;
using System.Collections.Generic;
using System.Linq;
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
    public class LinksCheck

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
        public void CheckAllLinks()
        {
            driver.Url = "http://localhost:8080/litecart/admin/";
            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            driver.FindElement(By.Name("login")).Click();
            driver.Url = "http://localhost:8080/litecart/admin/?app=countries&doc=countries";
            driver.FindElement(By.CssSelector("[href$=country]")).Click();
            IList<IWebElement> links = driver.FindElements(By.CssSelector("[target=_blank]"));
            Console.WriteLine(links.Count.ToString());

            /*string mainWindow = driver.CurrentWindowHandle;
            ICollection<string> oldWindows = driver.WindowHandles;
            int previousWindowCount = driver.WindowHandles.Count;

            wait.Until(driver => driver.WindowHandles.Count == (previousWindowCount + 1));
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            foreach (var oldwindow in oldWindows)
            {
                driver.SwitchTo().Window(oldwindow);
                driver.Close();
                driver.SwitchTo().Window(mainWindow);
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
