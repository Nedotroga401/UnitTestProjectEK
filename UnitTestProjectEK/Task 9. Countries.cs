using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProjectEK
{
  /*  [TestFixture]
    public class CheckCountries

    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Start()
        {
           driver = new ChromeDriver();
           // driver = new FirefoxDriver();
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
           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement element = driver.FindElement(By.Name("Angola"));
            element.Click();
        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }


    }*/
}
