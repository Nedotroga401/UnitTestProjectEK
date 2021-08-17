using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UnitTestProjectEK
{
   [TestFixture]
    public class AddDuck

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
        public void AddNewDuck()
        {
           
            driver.Url = "http://localhost:8080/litecart/admin/";
            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            driver.FindElement(By.Name("login")).Click();
            

            WebDriverWait waitbutton = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement waitpage = waitbutton.Until(ExpectedConditions.ElementExists(By.Id("copyright")));

            IWebElement catalog = waitbutton.Until(ExpectedConditions.ElementExists(By.CssSelector("[href$=catalog]")));
            catalog.Click();

            IWebElement addnew = waitbutton.Until(ExpectedConditions.ElementExists(By.CssSelector("[href$=product]")));
            addnew.Click();

            IWebElement save = waitbutton.Until(ExpectedConditions.ElementExists(By.CssSelector("[name=save]")));
            driver.FindElement(By.Name("status")).Click();
            driver.FindElement(By.Name("name[en]")).SendKeys("Batman Duck");
            driver.FindElement(By.Name("code")).SendKeys("bd001");
            driver.FindElement(By.Name("quantity")).Clear();
            driver.FindElement(By.Name("quantity")).SendKeys("25");

            string path = "batmen_duck.jpg";
            string fullpath = Path.GetFullPath(path);
            driver.FindElement(By.CssSelector("[type=file]")).SendKeys(fullpath);
            driver.FindElement(By.CssSelector("[href$=information]")).Click();

            IWebElement editor = waitbutton.Until(ExpectedConditions.ElementExists(By.CssSelector("[class=trumbowyg-editor]")));
            
            driver.FindElement(By.CssSelector("[class=trumbowyg-editor]")).SendKeys("Funny Duck");

            driver.FindElement(By.CssSelector("[href$=prices]")).Click();
            IWebElement prices = waitbutton.Until(ExpectedConditions.ElementIsVisible(By.Name("purchase_price")));
            prices.Clear();
           prices.SendKeys("15");

            driver.FindElement(By.Name("prices[USD]")).SendKeys("15");
            driver.FindElement(By.Name("save")).Click();

            IWebElement duckCheck = waitbutton.Until(ExpectedConditions.ElementExists(By.LinkText("Batman Duck")));
        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }


    }
}
