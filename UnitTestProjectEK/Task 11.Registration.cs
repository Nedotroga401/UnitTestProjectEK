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
    public class Registration

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
        public void RegistrationNew()
        {
            Random rnd = new Random();
            int rnd_user = rnd.Next(100, 200);
            string rnd_name = "Kate" + rnd_user.ToString();
            string rnd_last = "Smith" + rnd_user.ToString();
            string rnd_email = "test" + rnd_user.ToString() + "@test.com";
           
            driver.Url = "http://litecart.stqa.ru/ru/create_account";

            WebDriverWait waitbutton = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            IWebElement button = waitbutton.Until(ExpectedConditions.ElementExists(By.Name("create_account")));

            driver.FindElement(By.Name("firstname")).SendKeys(rnd_name);
            driver.FindElement(By.Name("lastname")).SendKeys(rnd_last);
            driver.FindElement(By.Name("address1")).SendKeys("test adress 1");
            driver.FindElement(By.Name("postcode")).SendKeys("12345");
            driver.FindElement(By.Name("city")).SendKeys("Alabama");
            driver.FindElement(By.CssSelector("[class=select2-selection__rendered]")).Click();
            driver.FindElement(By.CssSelector("[class=select2-search__field]")).SendKeys("United States");
            driver.FindElement(By.CssSelector("[role=treeitem]")).Click();
            driver.FindElement(By.Name("phone")).SendKeys("+1234567890");
            driver.FindElement(By.Name("email")).SendKeys(rnd_email);
            driver.FindElement(By.Name("password")).SendKeys("12345");
            driver.FindElement(By.Name("confirmed_password")).SendKeys("12345");
            button.Click();

            
            IWebElement logout = waitbutton.Until(ExpectedConditions.ElementExists(By.CssSelector("[href$=logout]")));
            logout.Click();

            IWebElement loginemail = waitbutton.Until(ExpectedConditions.ElementExists(By.CssSelector("[name=email]")));
            loginemail.SendKeys(rnd_email);
            driver.FindElement(By.Name("password")).SendKeys("12345");

            IWebElement login_new = waitbutton.Until(ExpectedConditions.ElementExists(By.Name("login")));
            login_new.Click();

            IWebElement check = waitbutton.Until(ExpectedConditions.ElementExists(By.LinkText("Logout")));
           
        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }


    }
}
