using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProjectEK
{
    [TestFixture]
    public class GoogleCheck
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
        public void Google()
        {
            driver.Url = "http://www.google.com/";
        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }


    }
}
