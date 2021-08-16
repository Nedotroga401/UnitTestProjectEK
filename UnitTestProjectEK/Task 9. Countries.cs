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

        [Test]
        public void CheckCountriesList()
        {
            driver.Url = "http://localhost:8080/litecart/admin/";
            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            driver.FindElement(By.Name("login")).Click();
            driver.Url = "http://localhost:8080/litecart/admin/?app=countries&doc=countries";

          
           IList<IWebElement> allCountries = driver.FindElements(By.CssSelector("[class=raw]"));
           int size = allCountries.Count;
           string[] countries = new string[size];
           int[] zones = new int[size];

            for (int i=0; i < size; i++)
            {
                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                IWebElement element = wait2.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=raw]")));
                //countries[i] = allCountries[i].Text;
                
                Console.WriteLine(countries[i]);
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
