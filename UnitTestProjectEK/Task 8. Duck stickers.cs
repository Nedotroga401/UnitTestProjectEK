using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
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
    public class DuckStickers

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
        public void SerchStickers()
        {
            driver.Url = "http://localhost:8080/litecart/";
            IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            IList<IWebElement> allDucks = driver.FindElements(By.CssSelector("[class=image-wrapper]"));
            int count = allDucks.Count;
            for (int i = 0; i < count; i++)
            {

                if (allDucks[i].FindElements(By.CssSelector("[class^=sticker]")).Count == 1)
                {
                    string text = allDucks[i].FindElement(By.CssSelector("[class^=sticker]")).Text.ToString();
                    Console.WriteLine(text);
                }
                else Console.WriteLine("Стикер не один");
                
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
